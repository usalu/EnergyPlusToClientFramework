using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
            string outputFolder = "C:\\Git\\EPJsonClientCodeGenerator\\Output";

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

            //Striped names for namespaces
            var namespaceNames = ePGroups.Select(x => StripEPGroupNameToCamelCase(x.Key));

            //Create a namespace for each group
            foreach (var ePGroup in ePGroups)
            {
                var ePGroupName = StripEPGroupNameToCamelCase(ePGroup.Key);

                CodeNamespace ePGroupNamespace = new CodeNamespace()
                {
                    Name = baseName + "." + ePGroupName,
                    Imports =
                    {
                        new CodeNamespaceImport("System.ComponentModel"),
                        new CodeNamespaceImport("Newtonsoft.Json")

                    }
                };

                //Import all other groups. Every name is striped to be in camel case.
                //NOTE: Not all other namespaces are needed but in order to decide that before hand seems unnecessarily complicated 
                ePGroupNamespace.Imports.AddRange(namespaceNames.Where(x => x != ePGroupName)
                    .Select(x=>    new CodeNamespaceImport(baseName + "." + x))
                    .ToArray());


                //Filling namespaces with ePObjects -> classes and the ePFields -> fields and enumerable type of fields -> enums
                foreach (KeyValuePair<string,EPObjectJsonSchemeProperty> ePObject in ePGroup)
                {
                    CodeTypeDeclaration abstractionLevelTypeDeclaration = new CodeTypeDeclaration(StripEPObjectNameToCamelCase(ePObject.Key))
                    {
                        IsClass = true,
                        CustomAttributes = GetEPObjectJsonSchemePropertyAttributeDeclarations(ePObject)
                    };

                    //In the current tested schemas only these two pattern properties appear
                    var ePGroupProperties = (ePObject.Value.EPPatternProperties.NecessaryField!=null) ? ePObject.Value.EPPatternProperties.NecessaryField.Properties : ePObject
                        .Value.EPPatternProperties.OptionalField.Properties;
                  
                    foreach (KeyValuePair<string, EPFieldProperty> epPatternProperty in ePGroupProperties)
                    {
                       
                        CodeTypeMember ePPatternProperTypeMember = new CodeMemberProperty()
                        {
                            Attributes = MemberAttributes.Public | MemberAttributes.Final,
                            Name = epPatternProperty.Key,
                            HasGet = true,
                            HasSet = true
                        };
                        //switch (epPatternProperty.Value.Type)
                        //{
                        //    case EPFieldType.Array:
                        //        var listType = new CodeTypeReference(typeof(List<>));
                        //        listType.TypeArguments.Add(epPatternProperty.Value.Items.);
                        //}

                        //Name for serialization
                        ePPatternProperTypeMember.CustomAttributes.Add(new CodeAttributeDeclaration("JsonProperty", new CodeAttributeArgument(new CodePrimitiveExpression(epPatternProperty.Key))));

                        abstractionLevelTypeDeclaration.Members.Add(ePPatternProperTypeMember);
                    }




                    ePGroupNamespace.Types.Add(abstractionLevelTypeDeclaration);
                }

                //All classes with attributes

                ePCompileUnit.Namespaces.Add(ePGroupNamespace);
            }


            //options for the layout of the generated C# and VB code
            var codeGeneratorOptions = new CodeGeneratorOptions()
            {
                BracingStyle = "C",
                BlankLinesBetweenMembers = true,
                IndentString = "    ",
                ElseOnClosing = false,
                VerbatimOrder = true
            };

            StringWriter stringWriterCSharp = new StringWriter();
            cSharpCodeProvider.GenerateCodeFromCompileUnit(ePCompileUnit, stringWriterCSharp, codeGeneratorOptions);
            File.WriteAllText($@"{folder}\{baseName}.cs", stringWriterCSharp.ToString());

        }

        public static CodeAttributeDeclarationCollection GetEPObjectJsonSchemePropertyAttributeDeclarations(KeyValuePair<string, EPObjectJsonSchemeProperty> ePObject)
        {
            CodeAttributeDeclarationCollection codeAttributeDeclarations = new CodeAttributeDeclarationCollection();

            //Name for serialization
            codeAttributeDeclarations.Add(new CodeAttributeDeclaration("JsonProperty", new CodeAttributeArgument(new CodePrimitiveExpression(ePObject.Key))));

            //Further attributes
            var ePObjectJsonSchemeProperty = ePObject.Value;

            if (ePObjectJsonSchemeProperty.EPMemo != null)
                codeAttributeDeclarations.Add(new CodeAttributeDeclaration("Description",
                    new CodeAttributeArgument(new CodePrimitiveExpression(ePObjectJsonSchemeProperty.EPMemo))));

            return codeAttributeDeclarations;
        }



        public static string StripEPGroupNameToCamelCase( string str)
        {
            return String.Concat(
                String.Join("",
                new Regex("[^a-zA-Z]")
                    .Replace(str, "")
                    .Split(new[] {"_", " "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(word => char.ToUpper(word[0]) + word.Substring(1)))
                .Where(c => !Char.IsWhiteSpace(c)));
        }

        public static string StripEPObjectNameToCamelCase(string str)
        {
            return String.Concat(
                String.Join("",
                        new Regex("[^a-zA-Z:]")
                            .Replace(str, "")
                            .Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(word => char.ToUpper(word[0]) + word.Substring(1)))
                    .Where(c => !Char.IsWhiteSpace(c)))
                .Replace(':', '_');
        }

        //public static CodeNamespaceCollection GenerateCodeNamespacesFromEPGroup(IGrouping<string,KeyValuePair<string,EPJsonSchemaProperty>> ePGroup)
        //{


        //}

    }

}
