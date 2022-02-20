using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum LifeCycleCost_RecurringCosts_Category
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Maintenance")]
        Maintenance = 1,
        
        [JsonProperty("MajorOverhaul")]
        MajorOverhaul = 2,
        
        [JsonProperty("MinorOverhaul")]
        MinorOverhaul = 3,
        
        [JsonProperty("Operation")]
        Operation = 4,
        
        [JsonProperty("OtherOperational")]
        OtherOperational = 5,
        
        [JsonProperty("Repair")]
        Repair = 6,
        
        [JsonProperty("Replacement")]
        Replacement = 7,
    }
}