using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    public enum Daylighting_Controls_DaylightingMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DElight")]
        DElight = 1,
        
        [JsonProperty("SplitFlux")]
        SplitFlux = 2,
    }
}