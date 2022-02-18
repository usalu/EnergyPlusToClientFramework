using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyPlusClientCodeGeneration
{
    class EPClientAssemblyDirector
    {
        private EPClientAssemblyBuilder ePClientAssemblyBuilder;

        public EPClientAssemblyDirector(EPClientAssemblyBuilder ePClientAssemblyBuilder)
        {
            this.ePClientAssemblyBuilder = ePClientAssemblyBuilder;
        }

        public void ConstructEPClientAssembly()
        {
            ePClientAssemblyBuilder.buildEPNamespaces();
            ePClientAssemblyBuilder.buildEPAttributes();
            ePClientAssemblyBuilder.buildEPClasses();
            ePClientAssemblyBuilder.buildEPProperties();
            ePClientAssemblyBuilder.buildEPMethods();
            ePClientAssemblyBuilder.buildEPEvents();
        }

        public EPClientAssembly GetEPClientAssembly
    }
}
