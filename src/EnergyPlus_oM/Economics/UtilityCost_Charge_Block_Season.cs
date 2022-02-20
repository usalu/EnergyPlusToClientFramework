using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Charge_Block_Season
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Annual")]
        Annual = 1,
        
        [JsonProperty("Fall")]
        Fall = 2,
        
        [JsonProperty("Spring")]
        Spring = 3,
        
        [JsonProperty("Summer")]
        Summer = 4,
        
        [JsonProperty("Winter")]
        Winter = 5,
    }
}