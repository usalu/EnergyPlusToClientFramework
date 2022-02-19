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
    class BHoMClientAssemblyBuilder : ClientAssemblyBuilder
    {
        private CodeCompileUnit clientAssemblyCodeCompileUnit;
        public BHoMClientAssemblyBuilder()
        {
            clientAssemblyCodeCompileUnit = new CodeCompileUnit();
        }
        public override void buildNamespaces()
        {
            throw new NotImplementedException();
        }

        public override void buildAttributes()
        {
            throw new NotImplementedException();
        }

        public override void buildEnums()
        {
            throw new NotImplementedException();
        }

        public override void buildClasses()
        {
            throw new NotImplementedException();
        }

        public override void buildProperties()
        {
            throw new NotImplementedException();
        }

        public override void buildMethods()
        {
            throw new NotImplementedException();
        }

        public override void buildEvents()
        {
            throw new NotImplementedException();
        }

        public override ClientCodeCompileUnit GetClientAssembly()
        {
            throw new NotImplementedException();
        }
    }
}
