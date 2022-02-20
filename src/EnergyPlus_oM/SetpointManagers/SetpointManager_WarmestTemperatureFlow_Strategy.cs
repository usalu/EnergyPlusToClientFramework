using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_WarmestTemperatureFlow_Strategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FlowFirst")]
        FlowFirst = 1,
        
        [JsonProperty("TemperatureFirst")]
        TemperatureFirst = 2,
    }
}