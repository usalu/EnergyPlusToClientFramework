using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum Zone_ZoneOutsideConvectionAlgorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 1,
        
        [JsonProperty("DOE-2")]
        DOE2 = 2,
        
        [JsonProperty("MoWiTT")]
        MoWiTT = 3,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 4,
        
        [JsonProperty("TARP")]
        TARP = 5,
    }
}