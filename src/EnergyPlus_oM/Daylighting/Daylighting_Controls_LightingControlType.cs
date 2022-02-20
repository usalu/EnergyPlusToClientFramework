using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    public enum Daylighting_Controls_LightingControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Continuous")]
        Continuous = 1,
        
        [JsonProperty("ContinuousOff")]
        ContinuousOff = 2,
        
        [JsonProperty("Stepped")]
        Stepped = 3,
    }
}