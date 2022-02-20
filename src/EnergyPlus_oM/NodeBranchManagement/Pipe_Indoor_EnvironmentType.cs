using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    public enum Pipe_Indoor_EnvironmentType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Schedule")]
        Schedule = 1,
        
        [JsonProperty("Zone")]
        Zone = 2,
    }
}