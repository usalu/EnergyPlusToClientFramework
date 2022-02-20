using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Charge_Simple_Season
    {
        
        [JsonProperty("Annual")]
        Annual = 0,
        
        [JsonProperty("Fall")]
        Fall = 1,
        
        [JsonProperty("Spring")]
        Spring = 2,
        
        [JsonProperty("Summer")]
        Summer = 3,
        
        [JsonProperty("Winter")]
        Winter = 4,
    }
}