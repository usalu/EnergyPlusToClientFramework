using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum Zone_ZoneInsideConvectionAlgorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASTMC1340")]
        ASTMC1340 = 1,
        
        [JsonProperty("AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 2,
        
        [JsonProperty("CeilingDiffuser")]
        CeilingDiffuser = 3,
        
        [JsonProperty("Simple")]
        Simple = 4,
        
        [JsonProperty("TARP")]
        TARP = 5,
        
        [JsonProperty("TrombeWall")]
        TrombeWall = 6,
    }
}