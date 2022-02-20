using System.CodeDom;
using System.Collections.Generic;

namespace ClientAssemblyGeneration.Builders
{
    class BHoMClientCodeCompileUnitBuilder : ClientCodeCompileUnitBuilder
    {
        public override void BuildProperty(string clientNamespaceName, string clientClassName, string name, CodeTypeReference propertyType,
            string defaultValue = "", string description = "", CodeAttributeDeclarationCollection attributes = null)
        {
            //base.BuildProperty(clientNamespaceName, clientClassName, name, propertyType, defaultValue, description, attributes);

            string descriptionAttribute = description != "" ? "[Description(@\"" + description + "\")]\n" : "";

            string customAttributesCode = "";
            if(attributes.Count!=0)
                foreach (CodeAttributeDeclaration attribute in attributes)
                {
                    customAttributesCode += "[" + attribute.Name + "(@\"" + description + "\")]\n";
                }

            string defaultValueCode;
            switch (propertyType.BaseType)
            {
                case "System.String":
                    defaultValueCode = defaultValue != "" ? "(" + propertyType.BaseType + ")" + defaultValue : "\"\"";
                    break;
                case "System.Single":
                    //defaultValueCode = defaultValue != "" ? "(" + propertyType.BaseType + ")" + defaultValue : "null"; ;
                    defaultValueCode = defaultValue;
                    break;
                default:
                    defaultValueCode = "(" + propertyType.BaseType + ")Enum.Parse(typeof(" + propertyType.BaseType + "), \"" + ((defaultValue=="")? "Default": defaultValue) + "\")";
                    break;

            }

             

            FindClass(clientNamespaceName, clientClassName).Members
                .Add(new CodeSnippetTypeMember(descriptionAttribute + customAttributesCode + "public " + propertyType.BaseType + " " + name +" " + "{ get; set; }" + " = " + defaultValueCode + ";"));
        }
    }
}
