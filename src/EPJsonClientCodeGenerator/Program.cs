using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

namespace EPJsonClientCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateEPJSONCSharpFramework();
        }

        public static void GenerateEPJSONCSharpFramework()
        {
            string json = File.ReadAllText(@"C:\Git\EPJsonClientCodeGenerator\Input\EnergyPlusV9-5-0\Energy+.schema.epJSON");
            string outputFolder = "";

            //remove unwanted attributes
            //var temp = JObject.Parse(json);
            //temp.Descendants()
            //    .OfType<JProperty>()
            //    .Where(attr => attr.Name == "legacy_idd")
            //    .ToList() // you should call ToList because you're about to changing the result, which is not possible if it is IEnumerable
            //    .ForEach(attr => attr.Remove()); // removing unwanted attributes
            //json = temp.ToString(); // backing result to json

            var schema = EPJsonSchema.FromJson(json);
            GenerateCSharp(schema, outputFolder);

            //settings.SchemaProcessors.Add(new EPJsonSchemaProcessor());
            //var schema = JsonConvert.DeserializeObject<JsonSchema>(contentSchema);


            //var generator = new CSharpGenerator(schema, new CSharpGeneratorSettings()
            //{
            //    Namespace = "EnergyPlus",
            //    AnyType = "EPObject",
            //    InlineNamedAny = true,
            //    ClassStyle = CSharpClassStyle.Poco,
            //    GenerateJsonMethods = true,

            //});
            //var file = generator.GenerateFile();
            //File.WriteAllText(@"C:\Git\EPJsonClientCodeGenerator\Output\EPJson.cs", file);
        }

        public static void GenerateCSharp(EPJsonSchema epJsonSchema, string folder)
        {
            string baseName = "EnergyPlus";

            var cSharpCodeProvider = new CSharpCodeProvider();
            CodeCompileUnit ePCompileUnit = new CodeCompileUnit();

            //Create groupings of all EPObjects according group tag
            var ePGroups =
                from energySchemaProperty in epJsonSchema.Properties
                group energySchemaProperty by energySchemaProperty.Value.EPGroup into newGroup
                orderby newGroup.Key
                select newGroup;

            
            //Create a namespace for each group
            foreach (var ePGroup in ePGroups)
            {
                //Import all other groups
                //NOTE: Not all other namespaces are needed but in order to decide that before hand seems unnecessarily complicated 
                CodeNamespaceImport[] groupsNamespaceImports = ePGroups
                    .Where(x=>x.Key!=ePGroup.Key)
                    .Select(x => new CodeNamespaceImport(baseName + "." + x.Key)).ToArray();
                CodeNamespace ePGroupCodeNamespace = new CodeNamespace(baseName + "." + ePGroup.Key);
                ePGroupCodeNamespace.Imports.AddRange(groupsNamespaceImports);

                ePCompileUnit.Namespaces.Add(ePGroupCodeNamespace);
            }

        }

        //public static CodeNamespaceCollection GenerateCodeNamespacesFromEPGroup(IGrouping<string,KeyValuePair<string,EPJsonSchemaProperty>> ePGroup)
        //{
           

        //}

    }

}
