using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Ratchet_SeasonFrom
    {
        
        [JsonProperty("Annual")]
        Annual = 0,
        
        [JsonProperty("Fall")]
        Fall = 1,
        
        [JsonProperty("Monthly")]
        Monthly = 2,
        
        [JsonProperty("Spring")]
        Spring = 3,
        
        [JsonProperty("Summer")]
        Summer = 4,
        
        [JsonProperty("Winter")]
        Winter = 5,
    }
}