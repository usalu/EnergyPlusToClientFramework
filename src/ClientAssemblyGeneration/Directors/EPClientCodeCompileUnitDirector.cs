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
using EnergyPlus_9_5_0_JsonSchema;
using EnergyPlus_9_5_0_JsonSchema.Fields;
using EnergyPlus_9_5_0_JsonSchema.Objects;
using Microsoft.CSharp;

namespace ClientAssemblyGeneration.Directors
{
    public class EPClientCodeCompileUnitDirector : ClientCodeCompileUnitDirector
    {
        private EPJsonSchema _ePJsonSchema;

        public EPClientCodeCompileUnitDirector(EPJsonSchema ePJsonSchema,
            ClientCodeCompileUnitBuilder clientCodeCompileUnitBuilder) : base(clientCodeCompileUnitBuilder)
        {
            _ePJsonSchema = ePJsonSchema;
        }

        public override CodeCompileUnit GetCodeCompileUnit()
        {
            string baseName = "BH.oM.Adapters.EnergyPlus";
            var systemImports = new CodeNamespaceImport[] { new CodeNamespaceImport("System"),new CodeNamespaceImport("System.Globalization"), new CodeNamespaceImport("Newtonsoft.Json"), new CodeNamespaceImport("BH.oM.Base") };
            _clientCodeCompileUnitBuilder.BuildNamespace(baseName, "", systemImports);
            List<string[]> generalEnums = new List<string[]>();

            string[] EmptyNoYesEnum = new String[] { "", "No", "Yes" };
            string EmptyNoYesEnumName = "EmptyNoYes";
            _clientCodeCompileUnitBuilder.BuildEnum(baseName, EmptyNoYesEnumName, EmptyNoYesEnum
                .Select(x => (StripEPFieldNameToCamelCase(x),"", GetJsonPropertyAttributeDeclarations(x))).ToArray());
            generalEnums.Add(EmptyNoYesEnum);

            //string[] HeatTransferAlgorithmEnum = new String[] { "", "CombinedHeatAndMoistureFiniteElement", "ConductionFiniteDifference", "ConductionTransferFunction", "MoisturePenetrationDepthConductionTransferFunction"};
            //string HeatTransferAlgorithmEnumName = "HeatTransferAlgorithm";
            //_clientCodeCompileUnitBuilder.BuildEnum(baseName, HeatTransferAlgorithmEnumName, HeatTransferAlgorithmEnum
            //    .Select(x => (StripEPFieldNameToCamelCase(x), "", GetJsonPropertyAttributeDeclarations(x))).ToArray());
            //generalEnums.Add(HeatTransferAlgorithmEnum);


            //Create groupings of all EPObjects according group tag
            var ePGroups =
                from energySchemaProperty in _ePJsonSchema.Properties
                group energySchemaProperty by energySchemaProperty.Value.EPGroup
                into newGroup
                orderby newGroup.Key
                select newGroup;

            //Striped names for namespaces
            var namespaceNames = ePGroups.Select(x => StripEPGroupNameToCamelCase(x.Key));

            //Create a namespace for each group
            foreach (var ePGroup in ePGroups)
            {

                var namespaceName = StripEPGroupNameToCamelCase(ePGroup.Key);
                var fullNamespaceName = baseName + "." + namespaceName;
                //Import all other groups. Every name is striped to be in camel case.
                //NOTE: Not all other namespaces are needed but in order to decide that before hand seems unnecessarily complicated 
                var ePGroupNamespaceImports = namespaceNames.Where(x => x != namespaceName)
                    .Select(x => new CodeNamespaceImport(baseName + "." + x))
                    .ToArray();
                _clientCodeCompileUnitBuilder.BuildNamespace(fullNamespaceName, "", new CodeNamespaceImport[] { new CodeNamespaceImport(baseName) }.Union(systemImports.Union(ePGroupNamespaceImports)).ToArray());

                //Filling namespaces with ePObjects -> classes and the ePFields -> fields and enumerable type of fields -> enums
                foreach (KeyValuePair<string, EPObjectJsonSchemeProperty> ePObject in ePGroup)
                {
                    EPObjectJsonSchemeProperty ePObjectJsonSchemeProperty = ePObject.Value;

                    string className = StripEPObjectNameToCamelCase(ePObject.Key);

                    _clientCodeCompileUnitBuilder.BuildClass(fullNamespaceName, className, ePObjectJsonSchemeProperty.EPMemo, new CodeTypeReferenceCollection(){ "BHoMObject" } ,GetJsonObjectAttributeDeclarations(ePObject.Key));;

                    //In the current tested schemas only these two pattern properties appear
                    var ePGroupProperties = (ePObjectJsonSchemeProperty.EPPatternProperties.NecessaryField != null) ? 
                        ePObjectJsonSchemeProperty.EPPatternProperties.NecessaryField.Properties
                        : ePObjectJsonSchemeProperty.EPPatternProperties.OptionalField.Properties;

                    foreach (KeyValuePair<string, EPFieldProperty> epPatternProperty in ePGroupProperties)
                    {
                        EPFieldProperty epFieldProperty = epPatternProperty.Value;
                        string epFieldPropertyName = StripEPFieldNameToCamelCase(epPatternProperty.Key);

                        //Type of object. Default: string
                        CodeTypeReference ePPatternPropertyTypeReference = new CodeTypeReference(typeof(string));

                        switch (epFieldProperty.EPType)
                        {
                            case EPFieldType.Number:
                                ePPatternPropertyTypeReference = new CodeTypeReference(typeof(float?));
                                break;
                            case EPFieldType.String:
                                if (epFieldProperty.EPEnum != null)
                                {
                                    if (epFieldProperty.EPEnum.SequenceEqual(EmptyNoYesEnum))
                                    {
                                        ePPatternPropertyTypeReference = new CodeTypeReference(EmptyNoYesEnumName);
                                    }
                                    //else if (epFieldProperty.EPEnum.SequenceEqual(HeatTransferAlgorithmEnum))
                                    //{
                                    //    ePPatternPropertyTypeReference = new CodeTypeReference(HeatTransferAlgorithmEnumName);
                                    //}
                                    else
                                    {
                                        string propertyTypeName = className + "_" + StripEPFieldNameToCamelCase(epPatternProperty.Key);
                                        _clientCodeCompileUnitBuilder.BuildEnum(fullNamespaceName, propertyTypeName, 
                                            epFieldProperty.EPEnum.Select(x => (StripEPFieldNameToCamelCase(x), "",GetJsonPropertyAttributeDeclarations(x))).ToArray(), "");
                                        ePPatternPropertyTypeReference = new CodeTypeReference(EmptyNoYesEnumName);
                                    }
                                }

                                break;
                            case EPFieldType.Array:
                                break;
                        }
                        
                        string defaultValue = (epFieldProperty.Default!=null) ?
                            ((epFieldProperty.Default.Value.Double == null) ?
                            epFieldProperty.Default.Value.String
                            : epFieldProperty.Default.Value.Double.ToString())
                            : "";

                        _clientCodeCompileUnitBuilder.BuildProperty(fullNamespaceName, className, epFieldPropertyName, ePPatternPropertyTypeReference, defaultValue, epFieldProperty.EPNote ?? "",
                            GetJsonPropertyAttributeDeclarations(epPatternProperty.Key));
                    }
                }

            }

            return _clientCodeCompileUnitBuilder.GetClientCodeCompileUnit();
        }

        public static CodeAttributeDeclarationCollection GetJsonPropertyAttributeDeclarations(string eObjectName)
        {
            CodeAttributeDeclarationCollection codeAttributeDeclarations = new CodeAttributeDeclarationCollection();
            codeAttributeDeclarations.Add(new CodeAttributeDeclaration("JsonProperty", new CodeAttributeArgument(new CodePrimitiveExpression(eObjectName))));
            return codeAttributeDeclarations;
        }

        public static CodeAttributeDeclarationCollection GetJsonObjectAttributeDeclarations(string eObjectName)
        {
            CodeAttributeDeclarationCollection codeAttributeDeclarations = new CodeAttributeDeclarationCollection();
            codeAttributeDeclarations.Add(new CodeAttributeDeclaration("JsonObject", new CodeAttributeArgument(new CodePrimitiveExpression(eObjectName))));
            return codeAttributeDeclarations;
        }

        public static string StripEPFieldNameToCamelCase(string str)
        {
            string upperCase = String.Join("", str
                .Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => char.ToUpper(word[0]) + word.Substring(1)));
            string fieldName =
                String.Concat(new Regex("[^a-zA-Z0-9]").Replace(upperCase, "").Where(c => !Char.IsWhiteSpace(c)));
            
            return Regex.IsMatch(fieldName, @"^\d")? "_"+fieldName: fieldName;
        }


        public static string StripEPGroupNameToCamelCase(string str)
        {
            return String.Concat(
                String.Join("",
                new Regex("[^a-zA-Z0-9]")
                    .Replace(str, "")
                    .Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(word => char.ToUpper(word[0]) + word.Substring(1)))
                .Where(c => !Char.IsWhiteSpace(c)));
        }

        public static string StripEPObjectNameToCamelCase(string str)
        {
            string objectName = String.Concat(
                    String.Join("",
                            new Regex("[^a-zA-Z:0-9]")
                                .Replace(str, "")
                                .Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(word => char.ToUpper(word[0]) + word.Substring(1)))
                        .Where(c => !Char.IsWhiteSpace(c)))
                .Replace(':', '_');
            return Regex.IsMatch(objectName, @"^\d") ? "_" + objectName : objectName;
        }


        }

}
