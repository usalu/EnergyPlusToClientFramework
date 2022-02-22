using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClientAssemblyGeneration.Builders;
using ClientAssemblyGeneration.Directors;
using EnergyPlus_9_5_0_JsonSchema;
using EnergyPlus_oM;
using Microsoft.CSharp;
using Newtonsoft.Json;
using BH.oM.Adapters.EnergyPlus;
using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
using BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment;

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
            var testObjects = new Dictionary<string, Boiler_HotWater>();
            var testProperty = new Boiler_HotWater();
            //testProperty.ConstantInternalVaporTransferCoefficient = EmptyNoYes.Empty;
            testProperty.BoilerFlowMode = Boiler_HotWater_BoilerFlowMode.Empty;
            testObjects.Add("Main boiler1", testProperty);
            epJsonTest.Boiler_HotWater_Dictionary = testObjects;
            var settings = new JsonSerializerSettings() { ContractResolver = new NullToEmptyStringResolver() };
            File.WriteAllText($@"C:\Git\EPJsonClientCodeGeneration\Output\Test.json", JsonConvert.SerializeObject(epJsonTest));
            var B = JsonConvert.SerializeObject(epJsonTest, settings);

        }
    }
}
