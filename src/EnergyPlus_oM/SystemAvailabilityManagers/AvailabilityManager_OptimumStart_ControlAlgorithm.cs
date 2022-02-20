using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    public enum AvailabilityManager_OptimumStart_ControlAlgorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AdaptiveASHRAE")]
        AdaptiveASHRAE = 1,
        
        [JsonProperty("AdaptiveTemperatureGradient")]
        AdaptiveTemperatureGradient = 2,
        
        [JsonProperty("ConstantStartTime")]
        ConstantStartTime = 3,
        
        [JsonProperty("ConstantTemperatureGradient")]
        ConstantTemperatureGradient = 4,
    }
}