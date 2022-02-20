using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnergyPlusClientCodeGeneration
{
    public abstract class ClientCodeCompileUnitBuilder
    {
        CodeCompileUnit clientCodeCompileUnit;

        public ClientCodeCompileUnitBuilder()
        {
            clientCodeCompileUnit = new CodeCompileUnit();
        }
        public virtual void BuildNamespace(string name, string description = "", CodeNamespaceImport[] imports = null)
        {
            var clientNamespace = new CodeNamespace(name)
            {
                Imports = { new CodeNamespaceImport("System.ComponentModel")}
            };
            if (imports != null)
                clientNamespace.Imports.AddRange(imports);
            clientCodeCompileUnit.Namespaces.Add(clientNamespace);
        }

        internal CodeNamespace FindNamespace(string name)
        {
            foreach (CodeNamespace clientNamespace in clientCodeCompileUnit.Namespaces)
                if (clientNamespace.Name == name)
                    return clientNamespace;
            throw new Exception("The namespace doesn't exist (yet). Make sure to build it first.");
        }
        internal CodeTypeDeclaration FindClass(string name, string namespaceName)
        {
            foreach (CodeTypeDeclaration clientClass in FindNamespace(namespaceName).Types)
                if (clientClass.Name == name && clientClass.IsClass==true)
                    return clientClass;
            throw new Exception("The class doesn't exist (yet) in the namespace. Make sure to build it first.");
        }

        public virtual void BuildAttribute() { }

        public virtual void BuildEnum(string clientNamespaceName, string name , (string Value, string Description)[] enumItems, string description = "" , CodeAttributeDeclarationCollection attributes = null, bool isFlagged = false)
        {
            CodeTypeDeclaration clientEnum = new CodeTypeDeclaration(name)
            {
                IsEnum = true,
                CustomAttributes = { new CodeAttributeDeclaration("Description", new CodeAttributeArgument(new CodePrimitiveExpression(description))) }
            };

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
                if (enumItem.Description != "")
                    enumMember.CustomAttributes.Add(new CodeAttributeDeclaration("Description", new CodeAttributeArgument(new CodePrimitiveExpression(enumItem.Description))));
                enumMember.Name = enumItem.Value;
                enumMember.InitExpression = new CodePrimitiveExpression(isFlagged ? (int)Math.Pow(2, i) : i);
                clientEnum.Members.Add(enumMember);
            }

            FindNamespace(clientNamespaceName).Types.Add(clientEnum);
        }

        public virtual void BuildClass(string clientNamespaceName, string name, string description = "", CodeAttributeDeclarationCollection attributes = null)
        {
            var clientClass = new CodeTypeDeclaration(name)
            {
                IsEnum = true,
                CustomAttributes = { new CodeAttributeDeclaration("Description", new CodeAttributeArgument(new CodePrimitiveExpression(description))) }
            };
            if (attributes != null)
                clientClass.CustomAttributes.AddRange(attributes);
            FindNamespace(clientNamespaceName).Types.Add(clientClass);
        }

        public virtual void BuildProperty(string clientNamespaceName, string clientClassName, string name, CodeTypeReference propertyType, string description = "", ,  CodeAttributeDeclarationCollection attributes = null)
        {

        }
        public virtual void BuildMethod() { }
        public virtual void BuildEvent() { }

        public CodeCompileUnit GetClientCodeCompileUnit() => clientCodeCompileUnit;
    }
}
