using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_IdealLoadsAirSystem_CoolingLimit
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LimitCapacity")]
        LimitCapacity = 1,
        
        [JsonProperty("LimitFlowRate")]
        LimitFlowRate = 2,
        
        [JsonProperty("LimitFlowRateAndCapacity")]
        LimitFlowRateAndCapacity = 3,
        
        [JsonProperty("NoLimit")]
        NoLimit = 4,
    }
}