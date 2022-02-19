using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyPlusClientCodeGeneration
{
    class ClientAssemblyDirector
    {
        private ClientAssemblyBuilder ClientAssemblyBuilder;

        public ClientAssemblyDirector(ClientAssemblyBuilder ClientAssemblyBuilder)
        {
            this.ClientAssemblyBuilder = ClientAssemblyBuilder;
        }

        public void ConstructClientAssembly()
        {
            ClientAssemblyBuilder.buildNamespaces();
            ClientAssemblyBuilder.buildAttributes();
            ClientAssemblyBuilder.buildClasses();
            ClientAssemblyBuilder.buildProperties();
            ClientAssemblyBuilder.buildMethods();
            ClientAssemblyBuilder.buildEvents();
        }

        public ClientAssembly GetClientAssembly;
    }
}
