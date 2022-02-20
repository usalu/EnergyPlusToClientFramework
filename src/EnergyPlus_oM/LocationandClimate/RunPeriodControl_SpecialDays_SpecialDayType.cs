using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum RunPeriodControl_SpecialDays_SpecialDayType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CustomDay1")]
        CustomDay1 = 1,
        
        [JsonProperty("CustomDay2")]
        CustomDay2 = 2,
        
        [JsonProperty("Holiday")]
        Holiday = 3,
        
        [JsonProperty("SummerDesignDay")]
        SummerDesignDay = 4,
        
        [JsonProperty("WinterDesignDay")]
        WinterDesignDay = 5,
    }
}