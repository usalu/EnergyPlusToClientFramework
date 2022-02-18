using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyPlusClientCodeGeneration
{
    abstract class EPClientAssemblyBuilder
    {
        public abstract void buildEPNamespaces();
        public abstract void buildEPAttributes();
        public abstract void buildEPClasses();
        public abstract void buildEPProperties();
        public abstract EPClientAssembly GetEPClientAssembly();
    }
}
