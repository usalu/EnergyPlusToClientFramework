using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_Warmest_Strategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximumTemperature")]
        MaximumTemperature = 1,
    }
}