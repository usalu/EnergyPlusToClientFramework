using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CSharp;

namespace ClientAssemblyGeneration.Builders
{
    public abstract class ClientCodeCompileUnitBuilder
    {
        CodeCompileUnit _clientCodeCompileUnit;

        public ClientCodeCompileUnitBuilder()
        {
            _clientCodeCompileUnit = new CodeCompileUnit();
        }
        public virtual CodeNamespace FindNamespace(string name)
        {
            foreach (CodeNamespace clientNamespace in _clientCodeCompileUnit.Namespaces)
                if (clientNamespace.Name == name)
                    return clientNamespace;
            throw new Exception("The namespace doesn't exist (yet). Make sure to build it first.");
        }
        public virtual CodeTypeDeclaration FindClass(string namespaceName, string name)
        {
            foreach (CodeTypeDeclaration clientClass in FindNamespace(namespaceName).Types)
                if (clientClass.Name == name && clientClass.IsClass==true)
                    return clientClass;
            throw new Exception("The class doesn't exist (yet) in the namespace. Make sure to build it first.");
        }
        internal CodeTypeDeclaration FindEnum(string namespaceName, string name)
        {
            foreach (CodeTypeDeclaration clientClass in FindNamespace(namespaceName).Types)
                if (clientClass.Name == name && clientClass.IsEnum == true)
                    return clientClass;
            throw new Exception("The enum doesn't exist (yet) in the namespace. Make sure to build it first.");
        }

        internal CodeTypeDeclaration FindEnum(string name)
        {
            foreach (CodeNamespace clientNamespace in _clientCodeCompileUnit.Namespaces)
                foreach (CodeTypeDeclaration clientClass in clientNamespace.Types)
                    if (clientClass.Name == name && clientClass.IsEnum == true)
                        return clientClass;
            throw new Exception("The enum doesn't exist (yet). Make sure to build it first.");
        }
        internal bool IsEnumAvailable(string name)
        {
            foreach (CodeNamespace clientNamespace in _clientCodeCompileUnit.Namespaces)
            foreach (CodeTypeDeclaration clientClass in clientNamespace.Types)
                if (clientClass.Name == name && clientClass.IsEnum == true)
                    return true;
            return false;
        }

        public virtual void BuildNamespace(string name, string description = "", CodeNamespaceImport[] imports = null)
        {
            var clientNamespace = new CodeNamespace(name)
            {
                Imports = { new CodeNamespaceImport("System.ComponentModel") }
            };
            if (imports != null)
                clientNamespace.Imports.AddRange(imports);
            _clientCodeCompileUnit.Namespaces.Add(clientNamespace);
        }

        public virtual void BuildAttribute() { }

        public virtual void BuildEnum(string clientNamespaceName, string name , (string Value, string Description, CodeAttributeDeclarationCollection attributes)[] enumItems, string description = "" , CodeAttributeDeclarationCollection attributes = null, bool isFlagged = false)
        {
            CodeTypeDeclaration clientEnum = new CodeTypeDeclaration(name)
            {
                IsEnum = true,
            };

            if (description != "")
                clientEnum.CustomAttributes.Add(new CodeAttributeDeclaration("Description", new CodeAttributeArgument(new CodePrimitiveExpression(description))));

            if (attributes!=null)
                clientEnum.CustomAttributes.AddRange(attributes);

            //add the Flags attribute to ensure a multiset
            if (isFlagged)
                clientEnum.CustomAttributes.Add(new CodeAttributeDeclaration("Flags"));

            //add values with the right value und a description attribute 
            for (int i = 0; i < enumItems.Length; i++)
            {
                var enumMember = new CodeMemberField();
                var enumItem = enumItems[i];
                string itemName = enumItem.Value;
                if (enumItem.Value == "")
                    itemName = "Empty";
                if (enumItem.Description != "")
                    enumMember.CustomAttributes.Add(new CodeAttributeDeclaration("Description", new CodeAttributeArgument(new CodePrimitiveExpression(enumItem.Description))));
                if (enumItem.attributes.Count!=0)
                    enumMember.CustomAttributes.AddRange(enumItem.attributes);
                enumMember.Name = itemName;
                enumMember.InitExpression = new CodePrimitiveExpression(isFlagged ? (int)Math.Pow(2, i) : i);
                clientEnum.Members.Add(enumMember);
            }
            CodeNamespace clientNamespace = FindNamespace(clientNamespaceName);
            foreach (CodeTypeDeclaration type in clientNamespace.Types)
            {
                if (type.Name == name)
                {
                    if (!type.IsEnum)
                        throw new Exception("A type with that name that is not an Enum already exists. Please check your naming.");

                    var names = new List<string>();
                    foreach ( CodeTypeMember member in type.Members)
                    {
                        names.Add(member.Name);
                    }

                    for (int i = 0; i < type.Members.Count; i++)
                    {
                        if(type.Members[i].Name!=enumItems[i].Value)
                            throw new Exception("The members of the enum do not match with the enum that has the identical name. Consider renaming one of them.");
                    }
                    return;
                }
            }
            clientNamespace.Types.Add(clientEnum);
        }

        public virtual void BuildClass(string clientNamespaceName, string name, string description = "", CodeTypeReferenceCollection superClassesAndInterfaces = null , CodeAttributeDeclarationCollection attributes = null)
        {
            var clientClass = new CodeTypeDeclaration(name)
            {
                IsClass = true,
            };
            if (description != "")
                clientClass.CustomAttributes.Add(new CodeAttributeDeclaration("Description", new CodeAttributeArgument(new CodePrimitiveExpression(description))));
            if (attributes != null)
                clientClass.CustomAttributes.AddRange(attributes);
            if(superClassesAndInterfaces!=null)
                clientClass.BaseTypes.AddRange(superClassesAndInterfaces);
            FindNamespace(clientNamespaceName).Types.Add(clientClass);
        }

        public virtual void BuildProperty(string clientNamespaceName, string clientClassName, string name, CodeTypeReference propertyType, string defaultValue = "", string description = "",  CodeAttributeDeclarationCollection attributes = null)
        {
            //CodeMemberProperty property = new CodeMemberProperty()
            //{
            //    Attributes = MemberAttributes.Public | MemberAttributes.Final,
            //    Name = name,
            //    Type = propertyType
            //};
            //if (description != "")
            //    property.CustomAttributes.Add(new CodeAttributeDeclaration("Description", new CodeAttributeArgument(new CodePrimitiveExpression(description))));

        }
        public virtual void BuildMethod() { }
        public virtual void BuildEvent() { }

        public CodeCompileUnit GetClientCodeCompileUnit() => _clientCodeCompileUnit;
    }
}
