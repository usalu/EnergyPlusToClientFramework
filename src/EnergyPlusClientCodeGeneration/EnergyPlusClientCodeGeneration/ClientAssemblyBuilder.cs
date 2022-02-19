using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyPlusClientCodeGeneration
{
    abstract class ClientAssemblyBuilder
    {
        public abstract void buildNamespaces();
        public abstract void buildAttributes();
        public abstract void buildClasses();
        public abstract void buildMethods();
        public abstract void buildEvents();
        public abstract void buildProperties();
        public abstract ClientAssembly GetClientAssembly();
    }
}
