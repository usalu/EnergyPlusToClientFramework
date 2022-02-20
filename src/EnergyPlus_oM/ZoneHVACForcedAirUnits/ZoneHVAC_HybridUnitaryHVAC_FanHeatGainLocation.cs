using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_HybridUnitaryHVAC_FanHeatGainLocation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MixedAirStream")]
        MixedAirStream = 1,
        
        [JsonProperty("SupplyAirStream")]
        SupplyAirStream = 2,
    }
}