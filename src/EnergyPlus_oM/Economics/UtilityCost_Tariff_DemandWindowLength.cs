using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Tariff_DemandWindowLength
    {
        
        [JsonProperty("Day")]
        Day = 0,
        
        [JsonProperty("FullHour")]
        FullHour = 1,
        
        [JsonProperty("HalfHour")]
        HalfHour = 2,
        
        [JsonProperty("QuarterHour")]
        QuarterHour = 3,
        
        [JsonProperty("Week")]
        Week = 4,
    }
}