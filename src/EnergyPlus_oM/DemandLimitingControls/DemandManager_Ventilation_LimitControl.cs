using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    public enum DemandManager_Ventilation_LimitControl
    {
        
        [JsonProperty("FixedRate")]
        FixedRate = 0,
        
        [JsonProperty("Off")]
        Off = 1,
        
        [JsonProperty("ReductionRatio")]
        ReductionRatio = 2,
    }
}