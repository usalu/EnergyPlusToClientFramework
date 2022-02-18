using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using EnergyPlusJsonSchemas._9_5_0;
using EnergyPlusJsonSchemas._9_5_0.Fields;
using EnergyPlusJsonSchemas._9_5_0.Objects;

namespace EPJsonClientCodeGenerator
{
    public static class Program
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
            //options for the layout of the generated C# and VB code
            var codeGeneratorOptions = new CodeGeneratorOptions()
            {
                //BracingStyles: "Block", "C"
                BracingStyle = "C",
                BlankLinesBetweenMembers = true,
                IndentString = "    ",
                ElseOnClosing = false,
                VerbatimOrder = false
            };


           

            StringWriter stringWriterCSharp = new StringWriter();
            cSharpCodeProvider.GenerateCodeFromCompileUnit(ePCompileUnit, stringWriterCSharp, codeGeneratorOptions);
            File.WriteAllText($@"{folder}\{baseName}.cs", stringWriterCSharp.ToString());

        }

        public static CodeCompileUnit GetEPCodeCompileUnit()
        {
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
                    .Select(x => new CodeNamespaceImport(baseName + "." + x))
                    .ToArray());


                //Filling namespaces with ePObjects -> classes and the ePFields -> fields and enumerable type of fields -> enums
                foreach (KeyValuePair<string, EPObjectJsonSchemeProperty> ePObject in ePGroup)
                {
                    EPObjectJsonSchemeProperty ePObjectJsonSchemeProperty = ePObject.Value;
                    CodeTypeDeclaration ePObjectTypeDeclaration = new CodeTypeDeclaration(StripEPObjectNameToCamelCase(ePObject.Key))
                    {
                        IsClass = true,
                        CustomAttributes = GetEPObjectJsonSchemePropertyAttributeDeclarations(ePObject)
                    };

                    //In the current tested schemas only these two pattern properties appear
                    var ePGroupProperties = (ePObjectJsonSchemeProperty.EPPatternProperties.NecessaryField != null) ?
                        ePObjectJsonSchemeProperty.EPPatternProperties.NecessaryField.Properties : ePObjectJsonSchemeProperty.EPPatternProperties.OptionalField.Properties;


                    foreach (KeyValuePair<string, EPFieldProperty> epPatternProperty in ePGroupProperties)
                    {
                        EPFieldProperty epFieldProperty = epPatternProperty.Value;
                        string epFieldPropertyName = StripEPFieldNameToCamelCase(epPatternProperty.Key);

                        //Type of object. EPDefaultValue: string
                        CodeTypeReference ePPatternPropertyTypeReference = new CodeTypeReference(typeof(string));

                        switch (epFieldProperty.EPType)
                        {
                            case EPFieldType.Number:
                                ePPatternPropertyTypeReference = new CodeTypeReference(typeof(float));
                                break;
                            case EPFieldType.String:
                                if (epFieldProperty.EPEnum != null)
                                {
                                    if (Enumerable.SequenceEqual(epFieldProperty.EPEnum, YesNoDefaultEnum))
                                    {
                                        ePPatternPropertyTypeReference = new CodeTypeReference(typeof(bool));
                                    }
                                    else
                                    {
                                        //string ePPatternPropertyEnumTypeDeclarationName = epFieldPropertyName+ "Type";
                                        string ePPatternPropertyEnumTypeDeclarationName = epFieldPropertyName;
                                        CodeTypeDeclaration ePPatternProperEnumTypeDeclaration =
                                            new CodeTypeDeclaration(ePPatternPropertyEnumTypeDeclarationName)
                                            {
                                                IsEnum = true
                                            };


                                        foreach (var epField in epFieldProperty.EPEnum)
                                        {
                                            var enumMember = new CodeMemberField();
                                            string enumFieldName = epField;
                                            if (enumFieldName == "")
                                                continue;
                                            enumMember.Name = enumFieldName;

                                            ePPatternProperEnumTypeDeclaration.Members.Add(enumMember);
                                        }

                                        ePObjectTypeDeclaration.Members.Add(ePPatternProperEnumTypeDeclaration);

                                        ePPatternPropertyTypeReference = new CodeTypeReference(ePPatternPropertyEnumTypeDeclarationName);
                                    }
                                }
                                break;
                            case EPFieldType.Array:
                                break;
                        }
                        CodeMemberProperty ePPatternProperTypeMember = new CodeMemberProperty()
                        {
                            Attributes = MemberAttributes.Public | MemberAttributes.Final,
                            Name = epFieldPropertyName,
                            HasGet = true,
                            HasSet = true,
                            Type = ePPatternPropertyTypeReference

                        };
                        if (epFieldProperty.EPNote != null)
                            ePPatternProperTypeMember.CustomAttributes.Add(
                                new CodeAttributeDeclaration("Description",
                                    new CodeAttributeArgument(
                                        new CodePrimitiveExpression(epFieldProperty.EPNote))));

                        //Name for serialization
                        ePPatternProperTypeMember.CustomAttributes.Add(new CodeAttributeDeclaration("JsonProperty", new CodeAttributeArgument(new CodePrimitiveExpression(epPatternProperty.Key))));



                        //Add the default value with type cast to the property. There is currently no semantical way of doing this.
                        StringWriter sw = new StringWriter();
                        cSharpCodeProvider.GenerateCodeFromMember(ePPatternProperTypeMember, sw, codeGeneratorOptions);
                        CodeSnippetTypeMember epPatternPropertySnippetTypeMemberWithDefaultValue = (epFieldProperty.Default == null) ?
                                new CodeSnippetTypeMember(sw.ToString() + " = " + "null" + ";") :
                                new CodeSnippetTypeMember(sw.ToString() + " = " + "(" + ePPatternPropertyTypeReference.BaseType + ")" +
                                                          ((epFieldProperty.Default.Value.Double == null) ? epFieldProperty.Default.Value.String : epFieldProperty.Default.Value.Double.ToString()) + ";");

                        ePObjectTypeDeclaration.Members.Add(epPatternPropertySnippetTypeMemberWithDefaultValue);
                    }




                    ePGroupNamespace.Types.Add(ePObjectTypeDeclaration);
                }

                //All classes with attributes

                ePCompileUnit.Namespaces.Add(ePGroupNamespace);
            }

            return ePCompileUnit;
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

        public static string StripEPFieldNameToCamelCase(string str)
        {
            string upperCase = String.Join("", str
                .Split(new[] {"_", " "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => char.ToUpper(word[0]) + word.Substring(1)));
            return String.Concat(new Regex("[^a-zA-Z]").Replace(upperCase, "").Where(c => !Char.IsWhiteSpace(c)));
        }


        public static string StripEPGroupNameToCamelCase( string str)
        {
            return String.Concat(
                String.Join("", new Regex("[^a-zA-Z]")
                    .Replace(str, "")
                    .Split(new[] {"_", " "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(word => char.ToUpper(word[0]) + word.Substring(1)))
                .Where(c => !Char.IsWhiteSpace(c)));
        }

        public static string StripEPObjectNameToCamelCase(string str)
        {
            return String.Concat(
                String.Join("", new Regex("[^a-zA-Z:]")
                            .Replace(str, "")
                            .Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(word => char.ToUpper(word[0]) + word.Substring(1)))
                    .Where(c => !Char.IsWhiteSpace(c)))
                .Replace(':', '_');
        }

        public static string TypeConverter()
        {

        }

        static string[] YesNoDefaultEnum = new String[] { "", "No", "Yes" };

        List<string[]> generalEnums = new List<string[]>() { YesNoDefaultEnum };

        public static CodeN


        //public static CodeNamespaceCollection GenerateCodeNamespacesFromEPGroup(IGrouping<string,KeyValuePair<string,EPJsonSchemaProperty>> ePGroup)
        //{


        //}

    }

}
