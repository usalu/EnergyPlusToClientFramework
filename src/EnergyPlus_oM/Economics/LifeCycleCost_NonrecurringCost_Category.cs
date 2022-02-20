using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum LifeCycleCost_NonrecurringCost_Category
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Construction")]
        Construction = 1,
        
        [JsonProperty("OtherCapital")]
        OtherCapital = 2,
        
        [JsonProperty("Salvage")]
        Salvage = 3,
    }
}