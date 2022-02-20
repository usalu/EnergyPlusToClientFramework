using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_Coldest_Strategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MinimumTemperature")]
        MinimumTemperature = 1,
    }
}