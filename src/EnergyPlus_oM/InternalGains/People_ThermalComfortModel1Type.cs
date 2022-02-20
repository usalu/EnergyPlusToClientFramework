using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum People_ThermalComfortModel1Type
    {
        
        [JsonProperty("AdaptiveASH55")]
        AdaptiveASH55 = 0,
        
        [JsonProperty("AdaptiveCEN15251")]
        AdaptiveCEN15251 = 1,
        
        [JsonProperty("AnkleDraftASH55")]
        AnkleDraftASH55 = 2,
        
        [JsonProperty("CoolingEffectASH55")]
        CoolingEffectASH55 = 3,
        
        [JsonProperty("Fanger")]
        Fanger = 4,
        
        [JsonProperty("KSU")]
        KSU = 5,
        
        [JsonProperty("Pierce")]
        Pierce = 6,
    }
}