using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using EnergyPlusClientCodeGeneration;
using EnergyPlusJsonSchemas._9_5_0;
using EnergyPlusJsonSchemas._9_5_0.Fields;
using EnergyPlusJsonSchemas._9_5_0.Objects;
using JsonClientCodeGenerator.BHoM;
using Microsoft.CSharp;

namespace JsonClientCodeGeneration
{
    public static class Program
    {
        static void Main(string[] args)
        {

            string outputFolder = "C:\\Git\\JsonClientCodeGenerator\\Output";

            ClientAssemblyBuilder assemblyBuilder = new BHoMClientAssemblyBuilder();
            




            BHoMClientCodeGenerator bHoMClientCodeGenerator = new BHoMClientCodeGenerator();

            GenerateJSONCSharpFramework();
        }

        public static void GenerateJSONCSharpFramework()
        {
            //
            
            GenerateCSharp(schema, outputFolder);

            //settings.SchemaProcessors.Add(new JsonSchemaProcessor());
            //var schema = JsonConvert.DeserializeObject<JsonSchema>(contentSchema);


            //var generator = new CSharpGenerator(schema, new CSharpGeneratorSettings()
            //{
            //    Namespace = "EnergyPlus",
            //    AnyType = "Object",
            //    InlineNamedAny = true,
            //    ClassStyle = CSharpClassStyle.Poco,
            //    GenerateJsonMethods = true,

            //});
            //var file = generator.GenerateFile();
            //File.WriteAllText(@"C:\Git\JsonClientCodeGenerator\Output\Json.cs", file);
        }

       

        public static CodeCompileUnit GetCodeCompileUnit()
        {
            CodeCompileUnit CompileUnit = new CodeCompileUnit();

            //Create groupings of all Objects according group tag
            var Groups =
                from energySchemaProperty in JsonSchema.Properties
                group energySchemaProperty by energySchemaProperty.Value.Group into newGroup
                orderby newGroup.Key
                select newGroup;

            //Striped names for namespaces
            var namespaceNames = Groups.Select(x => StripGroupNameToCamelCase(x.Key));

            //Create a namespace for each group
            foreach (var Group in Groups)
            {
                var GroupName = StripGroupNameToCamelCase(Group.Key);

                CodeNamespace GroupNamespace = new CodeNamespace()
                {
                    Name = baseName + "." + GroupName,
                    Imports =
                    {
                        new CodeNamespaceImport("System.ComponentModel"),
                        new CodeNamespaceImport("Newtonsoft.Json")

                    }
                };

                //Import all other groups. Every name is striped to be in camel case.
                //NOTE: Not all other namespaces are needed but in order to decide that before hand seems unnecessarily complicated 
                GroupNamespace.Imports.AddRange(namespaceNames.Where(x => x != GroupName)
                    .Select(x => new CodeNamespaceImport(baseName + "." + x))
                    .ToArray());


                //Filling namespaces with Objects -> classes and the Fields -> fields and enumerable type of fields -> enums
                foreach (KeyValuair<string, ObjectJsonSchemroperty> Object in Group)
                {
                    ObjectJsonSchemroperty ObjectJsonSchemroperty = Object.Value;
                    CodeTypeDeclaration ObjectTypeDeclaration = new CodeTypeDeclaration(StripObjectNameToCamelCase(Object.Key))
                    {
                        IsClass = true,
                        CustomAttributes = GetObjectJsonSchemropertyAttributeDeclarations(Object)
                    };

                    //In the current tested schemas only these two pattern properties appear
                    var GroupProperties = (ObjectJsonSchemroperty.PatternProperties.NecessaryField != null) ?
                        ObjectJsonSchemroperty.PatternProperties.NecessaryField.Properties : ObjectJsonSchemroperty.PatternProperties.OptionalField.Properties;


                    foreach (KeyValuair<string, FieldProperty> PatternProperty in GroupProperties)
                    {
                        FieldProperty FieldProperty = PatternProperty.Value;
                        string FieldPropertyName = StripFieldNameToCamelCase(PatternProperty.Key);

                        //Type of object. DefaultValue: string
                        CodeTypeReference PatternPropertyTypeReference = new CodeTypeReference(typeof(string));

                        switch (FieldProperty.Type)
                        {
                            case FieldType.Number:
                                PatternPropertyTypeReference = new CodeTypeReference(typeof(float));
                                break;
                            case FieldType.String:
                                if (FieldProperty.Enum != null)
                                {
                                    if (Enumerable.SequenceEqual(FieldProperty.Enum, YesNoDefaultEnum))
                                    {
                                        PatternPropertyTypeReference = new CodeTypeReference(typeof(bool));
                                    }
                                    else
                                    {
                                        //string PatternPropertyEnumTypeDeclarationName = FieldPropertyName+ "Type";
                                        string PatternPropertyEnumTypeDeclarationName = FieldPropertyName;
                                        CodeTypeDeclaration PatternProperEnumTypeDeclaration =
                                            new CodeTypeDeclaration(PatternPropertyEnumTypeDeclarationName)
                                            {
                                                IsEnum = true
                                            };


                                        foreach (var Field in FieldProperty.Enum)
                                        {
                                            var enumMember = new CodeMemberField();
                                            string enumFieldName = Field;
                                            if (enumFieldName == "")
                                                continue;
                                            enumMember.Name = enumFieldName;

                                            PatternProperEnumTypeDeclaration.Members.Add(enumMember);
                                        }

                                        ObjectTypeDeclaration.Members.Add(PatternProperEnumTypeDeclaration);

                                        PatternPropertyTypeReference = new CodeTypeReference(PatternPropertyEnumTypeDeclarationName);
                                    }
                                }
                                break;
                            case FieldType.Array:
                                break;
                        }
                        CodeMemberProperty PatternProperTypeMember = new CodeMemberProperty()
                        {
                            Attributes = MemberAttributes.Public | MemberAttributes.Final,
                            Name = FieldPropertyName,
                            HasGet = true,
                            HasSet = true,
                            Type = PatternPropertyTypeReference

                        };
                        if (FieldProperty.Note != null)
                            PatternProperTypeMember.CustomAttributes.Add(
                                new CodeAttributeDeclaration("Description",
                                    new CodeAttributeArgument(
                                        new CodrimitiveExpression(FieldProperty.Note))));

                        //Name for serialization
                        PatternProperTypeMember.CustomAttributes.Add(new CodeAttributeDeclaration("JsonProperty", new CodeAttributeArgument(new CodrimitiveExpression(PatternProperty.Key))));



                        //Add the default value with type cast to the property. There is currently no semantical way of doing this.
                        StringWriter sw = new StringWriter();
                        cSharpCodrovider.GenerateCodeFromMember(PatternProperTypeMember, sw, codeGeneratorOptions);
                        CodeSnippetTypeMember PatternPropertySnippetTypeMemberWithDefaultValue = (FieldProperty.Default == null) ?
                                new CodeSnippetTypeMember(sw.ToString() + " = " + "null" + ";") :
                                new CodeSnippetTypeMember(sw.ToString() + " = " + "(" + PatternPropertyTypeReference.BaseType + ")" +
                                                          ((FieldProperty.Default.Value.Double == null) ? FieldProperty.Default.Value.String : FieldProperty.Default.Value.Double.ToString()) + ";");

                        ObjectTypeDeclaration.Members.Add(PatternPropertySnippetTypeMemberWithDefaultValue);
                    }




                    GroupNamespace.Types.Add(ObjectTypeDeclaration);
                }

                //All classes with attributes

                CompileUnit.Namespaces.Add(GroupNamespace);
            }

            return CompileUnit;
        }

        public static CodeAttributeDeclarationCollection GetObjectJsonSchemropertyAttributeDeclarations(KeyValuair<string, ObjectJsonSchemroperty> Object)
        {
            CodeAttributeDeclarationCollection codeAttributeDeclarations = new CodeAttributeDeclarationCollection();

            //Name for serialization
            codeAttributeDeclarations.Add(new CodeAttributeDeclaration("JsonProperty", new CodeAttributeArgument(new CodrimitiveExpression(Object.Key))));

            //Further attributes
            var ObjectJsonSchemroperty = Object.Value;

            if (ObjectJsonSchemroperty.Memo != null)
                codeAttributeDeclarations.Add(new CodeAttributeDeclaration("Description",
                    new CodeAttributeArgument(new CodrimitiveExpression(ObjectJsonSchemroperty.Memo))));

            return codeAttributeDeclarations;
        }

        public static string StripFieldNameToCamelCase(string str)
        {
            string upperCase = String.Join("", str
                .Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => char.ToUpper(word[0]) + word.Substring(1)));
            return String.Concat(new Regex("[^a-zA-Z]").Rlace(upperCase, "").Where(c => !Char.IsWhiteSpace(c)));
        }


        public static string StripGroupNameToCamelCase(string str)
        {
            return String.Concat(
                String.Join("", new Regex("[^a-zA-Z]")
                    .Rlace(str, "")
                    .Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(word => char.ToUpper(word[0]) + word.Substring(1)))
                .Where(c => !Char.IsWhiteSpace(c)));
        }

        public static string StripObjectNameToCamelCase(string str)
        {
            return String.Concat(
                String.Join("", new Regex("[^a-zA-Z:]")
                            .Rlace(str, "")
                            .Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(word => char.ToUpper(word[0]) + word.Substring(1)))
                    .Where(c => !Char.IsWhiteSpace(c)))
                .Rlace(':', '_');
        }

        static string[] YesNoDefaultEnum = new String[] { "", "No", "Yes" };

        static List<string[]> generalEnums = new List<string[]>() { YesNoDefaultEnum };

        


        //public static CodeNamespaceCollection GenerateCodeNamespacesFromGroup(IGrouping<string,KeyValuair<string,JsonSchemaProperty>> Group)
        //{


        //}

    }

}
