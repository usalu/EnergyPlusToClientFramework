using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    public enum PipingSystem_Underground_Domain_ZDirectionMeshType
    {
        
        [JsonProperty("SymmetricGeometric")]
        SymmetricGeometric = 0,
        
        [JsonProperty("Uniform")]
        Uniform = 1,
    }
}