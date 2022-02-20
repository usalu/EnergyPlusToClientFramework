using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_Warmest_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
    }
}