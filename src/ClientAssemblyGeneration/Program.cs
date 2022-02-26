using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BH.oM.Adapters.EnergyPlus;
using BH.oM.Adapters.EnergyPlus.NodeBranchManagement;
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
            StringWriter stringWriterCSharp = new StringWriter();
            ePbHoMcSharpCodeProvider.GenerateCodeFromCompileUnit(ePbHoMCodeCompileUnit, stringWriterCSharp, 
                new CodeGeneratorOptions()
            {
                //BracingStyles: "Block", "C"
                BracingStyle = "C",
                BlankLinesBetweenMembers = true,
                IndentString = "    ",
                ElseOnClosing = false,
                VerbatimOrder = true
            });
            string allCode = stringWriterCSharp.ToString();
            File.WriteAllText($@"C:\Git\EPJsonClientCodeGeneration\Output\EnergyPlus.cs", allCode);

            //Some more settings needed
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

            string epJsonString = EPJson_Engine.GetEPJsonString(GetTestBuilding());

            File.WriteAllText($@"C:\Git\EPJsonClientCodeGeneration\Output\Test.json", epJsonString);

            string ePExePath = @"C:\EnergyPlusV9-5-0\energyplus.exe";

            //string idf = EPJsonToIDFConverter.GetIDF(ePExePath, serializedString);
            //Console.WriteLine(idf);
            //Console.Read();

            string idf = File.ReadAllText(@"C:\Git\EPJsonClientCodeGeneration\Input\EnergyPlusV9-5-0\TestCase\testfile.idf");
            string mergedEPJson = EPJson_Engine.GetIDF(ePExePath,idf,epJsonString);

            File.WriteAllText($@"C:\Git\EPJsonClientCodeGeneration\Output\Merged.idf", mergedEPJson);
            Console.Read();

        }

        private static EPJson GetTestBuilding()
        {
            var epJsonTest = new EPJson();

            //var building = new Building();
            //building.NodeName = "Buildinggg X1";
            //epJsonTest.Building = building;

            var mainBoiler = new Boiler_HotWater();
            mainBoiler.NodeName = "Main boiler1";
            mainBoiler.BoilerFlowMode = Boiler_HotWater_BoilerFlowMode.Empty;
            mainBoiler.NominalThermalEfficiency = 0.5;
            epJsonTest.Boiler_HotWater_List.Add(mainBoiler);
            var secondaryBoiler = new Boiler_HotWater();
            secondaryBoiler.NodeName = "Secondary boiler";
            secondaryBoiler.BoilerFlowMode = Boiler_HotWater_BoilerFlowMode.ConstantFlow;
            secondaryBoiler.FuelType = Boiler_HotWater_FuelType.NaturalGas;
            secondaryBoiler.NominalThermalEfficiency = 0.4;
            epJsonTest.Boiler_HotWater_List.Add(secondaryBoiler);

            //var mainMixedBranch = new Branch();
            //mainMixedBranch.NodeName = "Only Water Loop Mixed Supply Inlet Branch";
            //mainMixedBranch.Components = new List<Branch_Components_Item>();
            //var onlyWaterLoopMixedSupplyPump = new Branch_Components_Item();
            //onlyWaterLoopMixedSupplyPump.ComponentName = "Only Water Loop Mixed Supply Pump";
            //onlyWaterLoopMixedSupplyPump.ComponentObjectType = "Pump:ConstantSpeed";
            //onlyWaterLoopMixedSupplyPump.ComponentInletNodeName = "Only Water Loop Mixed Supply Inlet";
            //onlyWaterLoopMixedSupplyPump.ComponentOutletNodeName = "Only Water Loop Mixed Pump Outlet";
            //mainMixedBranch.Components.Add(onlyWaterLoopMixedSupplyPump);
            //epJsonTest.Branch_List.Add(mainMixedBranch);

            return epJsonTest;
        }


    }
}
