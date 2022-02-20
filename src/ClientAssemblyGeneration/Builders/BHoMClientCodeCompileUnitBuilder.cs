using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EnergyPlusClientCodeGeneration;

namespace JsonClientCodeGenerator.BHoM
{
    class BHoMClientCodeCompileUnitBuilder : ClientCodeCompileUnitBuilder
    {

        public override void BuildAttribute()
        {
            throw new NotImplementedException();
        }

        public override void BuildEnum(string clientNamespaceName, string name, (string Value, string Description)[] enumItems, string description = "", CodeAttributeDeclarationCollection attributes = null, bool isFlagged = false)
        {
            CodeTypeDeclaration clientEnum = new CodeTypeDeclaration(name)
            {
                IsEnum = true,
                CustomAttributes = { new CodeAttributeDeclaration("Description", new CodeAttributeArgument(new CodePrimitiveExpression(description))) }
            };

            if (attributes != null)
                clientEnum.CustomAttributes.AddRange(attributes);

            for (int i = 0; i < enumItems.Length; i++)
            {
                var enumMember = new CodeMemberField();
                var enumItem = enumItems[i];
                string itemName = enumItem.Value;
                if (enumItem.Value == "")
                    itemName = "Default";
                enumMember.Name = itemName;
                enumMember.InitExpression = new CodePrimitiveExpression(i);
                clientEnum.Members.Add(enumMember);
            }
            FindNamespace(clientNamespaceName).Types.Add(clientEnum);
        }

        public override void BuildClass()
        {
            throw new NotImplementedException();
        }

        public override void BuildProperty()
        {
            throw new NotImplementedException();
        }

        public override void BuildMethod()
        {
            throw new NotImplementedException();
        }

        public override void BuildEvent()
        {
            throw new NotImplementedException();
        }

    }
}
