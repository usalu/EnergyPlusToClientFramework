﻿using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BH.oM.Adapters.EnergyPlus;
using BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment;
using BH.oM.Adapters.EnergyPlus.SimulationParameters;
using ClientAssemblyGeneration.Builders;
using ClientAssemblyGeneration.Directors;
using EnergyPlus_9_5_0_JsonSchema;
using EnergyPlus_oM;
using Microsoft.CSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClientAssemblyGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientCodeCompileUnitBuilder builder = new BHoMClientCodeCompileUnitBuilder();
            ClientCodeCompileUnitDirector director = new EPClientCodeCompileUnitDirector(EPJsonSchema.GetOfficalEPJsonSchema, builder);
            CodeCompileUnit ePbHoMCodeCompileUnit = director.GetCodeCompileUnit("BH.oM.Adapters.EnergyPlus", 
                new CodeNamespaceImport[]{new CodeNamespaceImport("BH.oM.Base")});

            var ePbHoMcSharpCodeProvider = new CSharpCodeProvider();
            //options for the layout of the generated C# and VB code
            var codeGeneratorOptions = new CodeGeneratorOptions()
            {
                //BracingStyles: "Block", "C"
                BracingStyle = "C",
                BlankLinesBetweenMembers = true,
                IndentString = "    ",
                ElseOnClosing = false,
                VerbatimOrder = true
            };

            StringWriter stringWriterCSharp = new StringWriter();
            ePbHoMcSharpCodeProvider.GenerateCodeFromCompileUnit(ePbHoMCodeCompileUnit, stringWriterCSharp, codeGeneratorOptions);
            string allCode = stringWriterCSharp.ToString();
            File.WriteAllText($@"C:\Git\EPJsonClientCodeGeneration\Output\EnergyPlus.cs", allCode);

            var results = ePbHoMcSharpCodeProvider.CompileAssemblyFromDom(new CompilerParameters
            {
                GenerateExecutable = false,
                OutputAssembly = $@"C:\Git\EPJsonClientCodeGeneration\Output\EnergyPlus.dll",
                GenerateInMemory = false,
                TreatWarningsAsErrors = false,
                ReferencedAssemblies = { "BHoM.dll", "Newtonsoft.Json.dll", "System.Runtime.Serialization.dll" }
            }, ePbHoMCodeCompileUnit);

            string folder = @"C:\Git\EPJsonClientCodeGeneration\Output\Code";

            var ePNamespaces = allCode.Split(new []{ "//------------------------------------------------------------------------------" }, StringSplitOptions.None)[2]
                .Split(new []{"namespace"}, StringSplitOptions.None).Skip(1);
            foreach (var ePNamespace in ePNamespaces)
            {
                var ePNamespaceName = new Regex("^.*\n").Match(ePNamespace).Value.Split(new []{"\r\n"}, StringSplitOptions.None)[0].Split('.').Last();
                string ePNamespaceFolder = folder + "\\" + ePNamespaceName;
                Directory.CreateDirectory(ePNamespaceFolder);
                File.WriteAllText(ePNamespaceFolder + "\\" + ePNamespaceName + ".cs", "namespace" + ePNamespace);
            }

            var epJsonTest = new EnergyPlusJson();
            var building = new Building();
            building.NodeName = "Buildinggg X1";

            var boilers = new List<Boiler_HotWater>();
            var mainBoiler = new Boiler_HotWater();
            mainBoiler.NodeName = "Main boiler1";
            mainBoiler.BoilerFlowMode = Boiler_HotWater_BoilerFlowMode.Empty;
            mainBoiler.NominalThermalEfficiency = 0.5;
            boilers.Add(mainBoiler);
            var secondaryBoiler = new Boiler_HotWater();
            secondaryBoiler.NodeName = "Secondary boiler";
            secondaryBoiler.BoilerFlowMode = Boiler_HotWater_BoilerFlowMode.ConstantFlow;
            secondaryBoiler.FuelType = Boiler_HotWater_FuelType.NaturalGas;
            secondaryBoiler.NominalThermalEfficiency = 0.4;
            boilers.Add(secondaryBoiler);

            epJsonTest.Building = building;
            epJsonTest.Boiler_HotWater_List = boilers;

            string serializedString = JsonConvert.SerializeObject(epJsonTest, Formatting.Indented);

            File.WriteAllText($@"C:\Git\EPJsonClientCodeGeneration\Output\Test_before.json", serializedString);

            JObject jObject = JObject.Parse(serializedString);

            jObject.Property("BHoM_Guid")?.Remove();
            jObject.Property("Name")?.Remove();
            jObject.Property("Fragments")?.Remove();
            jObject.Property("Tags")?.Remove();
            jObject.Property("CustomData")?.Remove();


            JObject newJObject = new JObject(jObject);
            foreach (var ePGroup in jObject.Properties())
            {
                JProperty ePObjectGroup = newJObject.Property(ePGroup.Name);
                JObject newEPObjectGroupValues = new JObject();
                switch (ePGroup.Value.Type)
                {
                    case JTokenType.Array:
                        foreach (var epNode in ePGroup.Values())
                        {
                            newEPObjectGroupValues.Add(GetEPNodeWithNameAsMainProperty((JObject)epNode));
                        }
                        ePObjectGroup.Value = newEPObjectGroupValues;
                        break;
                    default:
                        newEPObjectGroupValues.Add(GetEPNodeWithNameAsMainProperty((JObject)ePGroup.Value));
                        ePObjectGroup.Value = newEPObjectGroupValues;
                        break;
                }
            }

            serializedString = newJObject.ToString();
            //serializedString = serializedString.Replace("\"null\"", "\"\"").Replace("null", "\"\"");

            File.WriteAllText($@"C:\Git\EPJsonClientCodeGeneration\Output\Test_after.json", serializedString);

            string ePExePath = @"C:\EnergyPlusV9-5-0\energyplus.exe";

            string idf = EPJsonToIDFConverter.GetIDF(ePExePath, serializedString);
            Console.WriteLine(idf);
            Console.Read();

        }

        static JToken GetEPNodeWithNameAsMainProperty(JObject ePNode)
        {
            
            string name = ePNode.Property("name").Value.ToString();
            if (name != null)
            {
                var valuesByName = new JObject(ePNode);
                valuesByName.Property("name").Remove();
                var newProperty = new JProperty(name, valuesByName);
                return newProperty;
            }
            return ePNode;
        }

    }
}
