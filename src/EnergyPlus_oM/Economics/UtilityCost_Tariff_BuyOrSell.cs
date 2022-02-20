using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Tariff_BuyOrSell
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BuyFromUtility")]
        BuyFromUtility = 1,
        
        [JsonProperty("NetMetering")]
        NetMetering = 2,
        
        [JsonProperty("SellToUtility")]
        SellToUtility = 3,
    }
}