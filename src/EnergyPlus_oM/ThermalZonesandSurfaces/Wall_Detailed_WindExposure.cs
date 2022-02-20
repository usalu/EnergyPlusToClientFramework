using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum Wall_Detailed_WindExposure
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NoWind")]
        NoWind = 1,
        
        [JsonProperty("WindExposed")]
        WindExposed = 2,
    }
}