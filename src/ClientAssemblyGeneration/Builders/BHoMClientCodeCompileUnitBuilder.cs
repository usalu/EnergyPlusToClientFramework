using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.CSharp;

namespace ClientAssemblyGeneration.Builders
{
    class BHoMClientCodeCompileUnitBuilder : ClientCodeCompileUnitBuilder
    {
        public override void BuildProperty(string clientNamespaceName, string clientClassName, string name, CodeTypeReference propertyType,
            string defaultValue = "", string description = "", CodeAttributeDeclarationCollection attributes = null)
        {
            //base.BuildProperty(clientNamespaceName, clientClassName, name, propertyType, defaultValue, description, attributes);

            CodeMemberProperty property = new CodeMemberProperty()
            {
                Attributes = MemberAttributes.Public | MemberAttributes.Final,
                Name = name,
                Type = propertyType
            };
            if (description != "")
                property.CustomAttributes.Add(new CodeAttributeDeclaration("Description", new CodeAttributeArgument(new CodePrimitiveExpression(description))));

            if (attributes != null)
                property.CustomAttributes.AddRange(attributes);

            CSharpCodeProvider provider = new CSharpCodeProvider();
            StringWriter stringWriterCSharp = new StringWriter();
            provider.GenerateCodeFromMember(property, stringWriterCSharp,new CodeGeneratorOptions()
            {
                BracingStyle = "C"
            });

            string cleanedCode = stringWriterCSharp.ToString();
            cleanedCode = cleanedCode.Substring(0, new Regex(@"\n\s*{").Match(cleanedCode).Index-1);

            string defaultValueCode;
            switch (propertyType.BaseType)
            {
                case "System.string":
                case "System.String":
                    defaultValueCode = "\"" + defaultValue + "\"";
                    break;
                case "System.Nullable`1":

                    var isNumber = float.TryParse(defaultValue, out _);
                    defaultValueCode =
                        (defaultValue != "" && isNumber) ? "Double.Parse("+ "\"" + defaultValue +  "\"" + ", CultureInfo.InvariantCulture)" : "null";
                    //defaultValueCode = defaultValue;
                    break;
                default:
                    //Check if field is enum
                    if (IsEnumAvailable(propertyType.BaseType))
                    {
                        defaultValueCode = (defaultValue == "") ? "Empty" : defaultValue;
                        var enumType = FindEnum(propertyType.BaseType);
                        bool isDefaultValueInside = false;
                        foreach (CodeTypeMember enumValue in enumType.Members)
                        {
                            if (enumValue.Name == defaultValue)
                            {
                                isDefaultValueInside = true;
                                break;
                            }
                        }
                        //If there is no default value and no empty string, the first options will be chosen. Reason: Enums can't be null. It will be up to the user to change it.
                        defaultValueCode = isDefaultValueInside ? defaultValueCode : enumType.Members[0].Name;
                        defaultValueCode = "(" + propertyType.BaseType + ")Enum.Parse(typeof(" + propertyType.BaseType + "), \"" + defaultValueCode + "\")";
                    }
                    //Property is a class
                    else
                    {
                        defaultValueCode = (defaultValue == "") ? "null" : defaultValue;
                    }
                    break;

            }
            FindClass(clientNamespaceName, clientClassName).Members
                .Add(new CodeSnippetTypeMember(cleanedCode  + " " + "{ get; set; }" + " = " + defaultValueCode + ";"));


        }
    }
}
