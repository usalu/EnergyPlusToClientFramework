using System.CodeDom;
using ClientAssemblyGeneration.Builders;

namespace ClientAssemblyGeneration.Directors
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
