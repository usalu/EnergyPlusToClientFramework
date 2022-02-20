using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum People_MeanRadiantTemperatureCalculationType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AngleFactor")]
        AngleFactor = 1,
        
        [JsonProperty("SurfaceWeighted")]
        SurfaceWeighted = 2,
        
        [JsonProperty("ZoneAveraged")]
        ZoneAveraged = 3,
    }
}