using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClientAssemblyGeneration.Builders;
using EnergyPlus_9_5_0_JsonSchema;
using EnergyPlus_9_5_0_JsonSchema.Fields;
using EnergyPlus_9_5_0_JsonSchema.Objects;
using EnergyPlus_oM;
using Microsoft.CSharp;
using NJsonSchema;

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

        public override CodeCompileUnit GetCodeCompileUnit(string baseNamespaceName, CodeNamespaceImport[] additionalImports)
        {
            var systemImports = new CodeNamespaceImport[] { new CodeNamespaceImport("System"),new CodeNamespaceImport("System.Globalization"), new CodeNamespaceImport("Newtonsoft.Json") };
            systemImports = systemImports.Union(additionalImports).ToArray();

            //Create groupings of all EPObjects according group tag
            var ePGroups =
                from energySchemaProperty in _ePJsonSchema.Properties
                group energySchemaProperty by energySchemaProperty.Value.EPGroup
                into newGroup
                orderby newGroup.Key
                select newGroup;

            //Striped names for namespaces
            var namespaceNames = ePGroups.Select(x => StripEPGroupNameToCamelCase(x.Key));


            //Build base namespace
            _clientCodeCompileUnitBuilder.BuildNamespace(baseNamespaceName, systemImports.Union(namespaceNames.Select(x=>new CodeNamespaceImport(x))).ToArray());
            string ePJsonClassName = "EPJson";

            //Build main class
            _clientCodeCompileUnitBuilder.BuildClass(baseNamespaceName, ePJsonClassName, "Ultimate class that can be automatically (de)serialized and simulated.",
                new CodeTypeReferenceCollection() { "BHoMObject" }); ;

            //All enums that appear often inside EnergyPlus
            List<string[]> generalEnums = new List<string[]>();

            string[] EmptyNoYesEnum = new String[] { "", "No", "Yes" };
            string EmptyNoYesEnumName = "EmptyNoYes";
            _clientCodeCompileUnitBuilder.BuildEnum(baseNamespaceName, EmptyNoYesEnumName, EmptyNoYesEnum
                .Select(x => (StripEPFieldNameToCamelCase(x), "", new CodeAttributeDeclarationCollection() { GetEnumMemberAttributeDeclarationDeclarations(x) })).ToArray());

            generalEnums.Add(EmptyNoYesEnum);

            //string[] HeatTransferAlgorithmEnum = new string[] { "", "CombinedHeatAndMoistureFiniteElement", "ConductionFiniteDifference", "ConductionTransferFunction", "MoisturePenetrationDepthConductionTransferFunction"};
            //string HeatTransferAlgorithmEnumName = "HeatTransferAlgorithm";
            //_clientCodeCompileUnitBuilder.BuildEnum(baseNamespaceName, HeatTransferAlgorithmEnumName, HeatTransferAlgorithmEnum
            //    .Select(x => (StripEPFieldNameToCamelCase(x), "", GetJsonPropertyAttributeDeclarations(x))).ToArray());
            //generalEnums.Add(HeatTransferAlgorithmEnum);

            //Create a namespace for each group
            foreach (var ePGroup in ePGroups)
            {

                var namespaceName = StripEPGroupNameToCamelCase(ePGroup.Key);
                var fullNamespaceName = baseNamespaceName + "." + namespaceName;
                //Import all other groups. Every name is striped to be in camel case.
                //NOTE: Not all other namespaces are needed but in order to decide that before hand seems unnecessarily complicated 
                var ePGroupNamespaceImports = namespaceNames.Where(x => x != namespaceName)
                    .Select(x => new CodeNamespaceImport(baseNamespaceName + "." + x))
                    .ToArray();
                _clientCodeCompileUnitBuilder.BuildNamespace(fullNamespaceName, new CodeNamespaceImport[] { new CodeNamespaceImport(baseNamespaceName) }.Union(systemImports.Union(ePGroupNamespaceImports)).ToArray());

                //Filling namespaces with ePObjects -> classes and the ePFields -> fields and enumerable type of fields -> enums
                foreach (KeyValuePair<string, EPObjectJsonSchemeProperty> ePObject in ePGroup)
                {
                    EPObjectJsonSchemeProperty ePObjectJsonSchemeProperty = ePObject.Value;

                    string className = StripEPObjectNameToCamelCase(ePObject.Key);

                    var typeReferences = new CodeTypeReferenceCollection() {"BHoMObject"};
                    //In the IDD this is does mean the object does not have the tag: \unique-object
                    if (ePObjectJsonSchemeProperty.EPName != null)
                    {
                        typeReferences.Add("IEnergyPlusNode");
                    }

                    //_clientCodeCompileUnitBuilder.BuildClass(fullNamespaceName, className, ePObjectJsonSchemeProperty.EPMemo,new CodeTypeReferenceCollection() { "BHoMObject", "IEnergyPlusClass" }, new CodeAttributeDeclarationCollection() { GetJsonObjectAttributeDeclarations(ePObject.Key) }); ;
                    _clientCodeCompileUnitBuilder.BuildClass(fullNamespaceName, className, ePObjectJsonSchemeProperty.EPMemo,
                        typeReferences, new CodeAttributeDeclarationCollection(){ GetOnlyDeclaredPropertiesAttributeDeclarations()}); ;

                    //In the IDD this is does mean the object does not have the tag: \unique-object
                    if (ePObjectJsonSchemeProperty.EPName!=null)
                    {
                        _clientCodeCompileUnitBuilder.BuildProperty(fullNamespaceName, className, "NodeName",
                            new CodeTypeReference(typeof(string)), "", "This will be the main key of this instance. " +
                                                                       "It will be the main key of the serialization and all other properties will be sub properties of this key.", 
                            new CodeAttributeDeclarationCollection(){GetJsonPropertyAttributeDeclarations("name")});
                    }

                    //In the current tested schemas only these two pattern properties appear
                    var ePGroupProperties = (ePObjectJsonSchemeProperty.PatternProperties.NecessaryField != null) ? 
                        ePObjectJsonSchemeProperty.PatternProperties.NecessaryField.Properties
                        : ePObjectJsonSchemeProperty.PatternProperties.OptionalField.Properties;

                    foreach (KeyValuePair<string, EPFieldProperty> epPatternProperty in ePGroupProperties)
                    {
                        EPFieldProperty epFieldProperty = epPatternProperty.Value;
                        string epFieldPropertyName = StripEPFieldNameToCamelCase(epPatternProperty.Key);
                        string fieldDescription = epFieldProperty.EPNote ?? "";

                        //Type of object. Default: string
                        CodeTypeReference ePPatternPropertyTypeReference = new CodeTypeReference(typeof(string));
                        string converter = "";
                        string defaultValue = (epFieldProperty.Default != null)
                            ? ((epFieldProperty.Default.Value.Double == null)
                                ? epFieldProperty.Default.Value.String
                                : epFieldProperty.Default.Value.Double.ToString())
                            : "";

                        bool isEnum = false;

                        if (epFieldProperty.EPType != null)
                        {
                            switch (epFieldProperty.EPType)
                            {
                                case EPFieldType.number:
                                    ePPatternPropertyTypeReference = new CodeTypeReference(typeof(double?));
                                    break;
                                case EPFieldType.@string:
                                    if (epFieldProperty.Enum != null)
                                    {
                                        if (epFieldProperty.Enum.SequenceEqual(EmptyNoYesEnum))
                                        {
                                            ePPatternPropertyTypeReference = new CodeTypeReference(EmptyNoYesEnumName);
                                        }
                                        else
                                        {
                                            string propertyTypeName =
                                                className + "_" + StripEPFieldNameToCamelCase(epPatternProperty.Key);
                                            _clientCodeCompileUnitBuilder.BuildEnum(fullNamespaceName, propertyTypeName,
                                                epFieldProperty.Enum.Select(x => (StripEPFieldNameToCamelCase(x), "",
                                                    new CodeAttributeDeclarationCollection()
                                                        {GetEnumMemberAttributeDeclarationDeclarations(x)})).ToArray(),
                                                "");
                                            ePPatternPropertyTypeReference = new CodeTypeReference(propertyTypeName);
                                        }

                                        //Makes sure the values are converted not to int but the specified values
                                        converter = "Newtonsoft.Json.Converters.StringEnumConverter";
                                    }

                                    break;
                                case EPFieldType.@object:
                                case EPFieldType.array:
                                    if (epFieldProperty.Items.Properties.Count==1)
                                    {
                                        var epCollectionProperty = epFieldProperty.Items.Properties.First();
                                        var epCollectionPropertyValue = epCollectionProperty.Value;
                                        if (epCollectionPropertyValue.EPType == EPFieldType.@string)
                                        {
                                            var arrayTypeReference = new CodeTypeReference(typeof(List<string>));
                                            ePPatternPropertyTypeReference = arrayTypeReference;
                                            if (fieldDescription == "")
                                            {
                                                if (epCollectionPropertyValue.ObjectList != null)
                                                    fieldDescription = "This list is the " + epCollectionPropertyValue.ObjectList[0] + " object-list";
                                            }
                                        }
                                      
                                    }
                                    else
                                    {
                                        string arrayItemClassName =
                                            className + "_" + StripEPFieldNameToCamelCase(epPatternProperty.Key) + "_" + "Item";
                                        _clientCodeCompileUnitBuilder.BuildClass(fullNamespaceName, arrayItemClassName, "",
                                            null,
                                            new CodeAttributeDeclarationCollection()
                                                {GetOnlyDeclaredPropertiesAttributeDeclarations()});

                                        foreach (var arrayItemProperty in epFieldProperty.Items.Properties)
                                        {
                                            EPFieldProperty arrayField = arrayItemProperty.Value;
                                            CodeTypeReference arrayItemPropertyType;


                                            switch (arrayField.EPType)
                                            {
                                                case EPFieldType.number:
                                                    arrayItemPropertyType = new CodeTypeReference(typeof(double?));
                                                    break;
                                                case EPFieldType.@string:
                                                default:
                                                    arrayItemPropertyType = new CodeTypeReference(typeof(string));
                                                    break;
                                            }

                                            string arrayItemPropertyName =
                                                StripEPFieldNameToCamelCase(arrayItemProperty.Key);
                                            _clientCodeCompileUnitBuilder.BuildProperty(fullNamespaceName,
                                                arrayItemClassName, arrayItemPropertyName,
                                                arrayItemPropertyType, "", "", new CodeAttributeDeclarationCollection(){ GetJsonPropertyAttributeDeclarations(arrayItemProperty.Key) });
                                        }


                                        var arrayTypeReference = new CodeTypeReference(typeof(List<>))
                                        {
                                            TypeArguments = { fullNamespaceName + "." + arrayItemClassName }
                                        };
                                        ePPatternPropertyTypeReference = arrayTypeReference;
                                    }
                                    break;
                            }
                        }
                        // Set values for hybrid system.
                        else if (epFieldProperty.AnyOf != null)
                        {
                            foreach (var fieldTypes in epFieldProperty.AnyOf)
                            {
                                if (fieldTypes.EPType == EPFieldType.@string)
                                {
                                    if (fieldTypes.Enum != null)
                                    {
                                        if (fieldTypes.Enum.Contains("Autosize"))
                                        {
                                            converter = "EnergyPlus_oM.EPNullToAutosizeJsonConverter";
                                            //defaultValue = null;
                                            defaultValue = Properties.Resources.autosizableValue;
                                        }
                                        else if (fieldTypes.Enum.Contains("Autocalculate"))
                                        {
                                            converter = "EnergyPlus_oM.EPNullToAutocalculateJsonConverter";
                                            //defaultValue = null;
                                            defaultValue = Properties.Resources.autosizableValue;
                                        }

                                        ePPatternPropertyTypeReference = new CodeTypeReference(typeof(double?));
                                    }
                                }
                            }
                        }
                        
                        _clientCodeCompileUnitBuilder.BuildProperty(fullNamespaceName, className, epFieldPropertyName, ePPatternPropertyTypeReference, defaultValue, fieldDescription,
                            (converter=="")?
                                new CodeAttributeDeclarationCollection(){GetJsonPropertyAttributeDeclarations(epPatternProperty.Key,true) }
                                : new CodeAttributeDeclarationCollection(){ GetJsonPropertyAttributeDeclarations(epPatternProperty.Key, true), GetJsonConverterAttributeDeclarations(converter) });
                       
                    }

                    //Building Property in EPJson class
                    CodeTypeReference propertyType;
                    string propertyName;
                    string defaultPropertyValue = "";

                    if (ePObjectJsonSchemeProperty.MaxProperties == 1)
                    {
                        propertyType = new CodeTypeReference(fullNamespaceName + "." + className);
                        propertyName = className;

                        //defaultPropertyValue = "new " + fullNamespaceName + "." + className + " ()";
                    }
                    else
                    {

                        propertyType = new CodeTypeReference(typeof(List<>))
                        {
                            TypeArguments = { fullNamespaceName + "." + className }
                        };

                        propertyName = className + "_List";

                        //Type: Dict<CLASSNAME>

                        //CodeTypeReference myClass = new CodeTypeReference(
                        //    "System.Collections.Generic.Dictionary",
                        //    new CodeTypeReference[]
                        //    {
                        //        new CodeTypeReference(typeof(string)),
                        //        new CodeTypeReference(fullNamespaceName + "." + className)
                        //    });

                        //propertyType = new CodeTypeReference(typeof(Dictionary<,>))
                        //{
                        //    TypeArguments = { typeof(string), fullNamespaceName + "." + className }
                        //};
                        //propertyName = className + "_Dictionary";

                        defaultPropertyValue = "new System.Collections.Generic.List<" + fullNamespaceName + "." + className + "> ()";

                        //For comfort, not performance empty list will be automatically instantiated so the values can just be added.
                        //In order for them to only serialize when there are items an additional method needs be created
                        //See: https://www.newtonsoft.com/json/help/html/ConditionalProperties.htm
                        CodeBinaryOperatorExpression countGreaterZero = new CodeBinaryOperatorExpression(
                            new CodePropertyReferenceExpression(new CodeTypeReferenceExpression(propertyName), "Count"), CodeBinaryOperatorType.GreaterThan, new CodePrimitiveExpression(0));
                        _clientCodeCompileUnitBuilder.BuildMethod(baseNamespaceName, ePJsonClassName, "ShouldSerialize" + propertyName,
                            new CodeStatementCollection() { new CodeMethodReturnStatement(countGreaterZero) },
                            new CodeTypeReference(typeof(bool)), null, "", null);

                    }

                    _clientCodeCompileUnitBuilder.BuildProperty(baseNamespaceName, ePJsonClassName, propertyName, propertyType, defaultPropertyValue, "",
                        new CodeAttributeDeclarationCollection(){ GetJsonPropertyAttributeDeclarations(ePObject.Key)});

                }

            }

            return _clientCodeCompileUnitBuilder.GetClientCodeCompileUnit();
        }


        public static CodeAttributeDeclaration GetEnumMemberAttributeDeclarationDeclarations(string enumValueToSerialize)
        {
            return new CodeAttributeDeclaration("System.Runtime.Serialization.EnumMember", 
                new CodeAttributeArgument("Value",new CodePrimitiveExpression(enumValueToSerialize!=""? enumValueToSerialize: "")));

        }

        public static CodeAttributeDeclaration GetJsonConverterAttributeDeclarations(string converterName)
        {
            List<CodeAttributeArgument> arguments = new List<CodeAttributeArgument>() { };
            arguments.Add(new CodeAttributeArgument(new CodeTypeOfExpression(converterName)));
            return new CodeAttributeDeclaration("Newtonsoft.Json.JsonConverter", arguments.ToArray());

        }

        public static CodeAttributeDeclaration GetJsonPropertyAttributeDeclarations(string eObjectName, bool ignoreIfNull = true, string converterName = "")
        {
            List<CodeAttributeArgument> arguments = new List<CodeAttributeArgument>(){};

            arguments.Add(new CodeAttributeArgument("PropertyName", new CodePrimitiveExpression(eObjectName)));

            if (ignoreIfNull)
            {
                arguments.Add(new CodeAttributeArgument("NullValueHandling",
                    new CodePropertyReferenceExpression(
                        new CodeTypeReferenceExpression("Newtonsoft.Json.NullValueHandling"), "Ignore")));
            }

            if (converterName != "")
            {
                arguments.Add(new CodeAttributeArgument("ItemConverterType", new CodeTypeOfExpression(converterName)));
            }
                
            return new CodeAttributeDeclaration("JsonProperty", arguments.ToArray());

        }
        public static CodeAttributeDeclaration GetOnlyDeclaredPropertiesAttributeDeclarations()
        {
            return new CodeAttributeDeclaration("JsonObject", new CodeAttributeArgument[] { new CodeAttributeArgument(
                new CodePropertyReferenceExpression(new CodeTypeReferenceExpression("Newtonsoft.Json.MemberSerialization"), "OptIn"))});
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
