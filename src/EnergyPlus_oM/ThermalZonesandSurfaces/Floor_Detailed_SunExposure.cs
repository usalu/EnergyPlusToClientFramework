using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum Floor_Detailed_SunExposure
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NoSun")]
        NoSun = 1,
        
        [JsonProperty("SunExposed")]
        SunExposed = 2,
    }
}