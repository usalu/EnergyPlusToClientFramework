using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Qualify_ThresholdTest
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Consecutive")]
        Consecutive = 1,
        
        [JsonProperty("Count")]
        Count = 2,
    }
}