using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnergyPlusClientCodeGeneration
{
    public abstract class ClientCodeCompileUnitDirector
    {
        internal ClientCodeCompileUnitBuilder _clientCodeCompileUnitBuilder;

        public ClientCodeCompileUnitDirector(ClientCodeCompileUnitBuilder clientCodeCompileUnitBuilder)
        {
            this._clientCodeCompileUnitBuilder = clientCodeCompileUnitBuilder;
        }
        public abstract CodeCompileUnit GetCodeCompileUnit();
        
    }
}
