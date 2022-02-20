using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    public enum ZoneEarthtube_SoilCondition
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("HeavyAndDamp")]
        HeavyAndDamp = 1,
        
        [JsonProperty("HeavyAndDry")]
        HeavyAndDry = 2,
        
        [JsonProperty("HeavyAndSaturated")]
        HeavyAndSaturated = 3,
        
        [JsonProperty("LightAndDry")]
        LightAndDry = 4,
    }
}