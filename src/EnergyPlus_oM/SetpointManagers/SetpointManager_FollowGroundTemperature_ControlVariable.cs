using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_FollowGroundTemperature_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximumTemperature")]
        MaximumTemperature = 1,
        
        [JsonProperty("MinimumTemperature")]
        MinimumTemperature = 2,
        
        [JsonProperty("Temperature")]
        Temperature = 3,
    }
}