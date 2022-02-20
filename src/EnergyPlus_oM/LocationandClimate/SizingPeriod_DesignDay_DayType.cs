using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum SizingPeriod_DesignDay_DayType
    {
        
        [JsonProperty("CustomDay1")]
        CustomDay1 = 0,
        
        [JsonProperty("CustomDay2")]
        CustomDay2 = 1,
        
        [JsonProperty("Friday")]
        Friday = 2,
        
        [JsonProperty("Holiday")]
        Holiday = 3,
        
        [JsonProperty("Monday")]
        Monday = 4,
        
        [JsonProperty("Saturday")]
        Saturday = 5,
        
        [JsonProperty("SummerDesignDay")]
        SummerDesignDay = 6,
        
        [JsonProperty("Sunday")]
        Sunday = 7,
        
        [JsonProperty("Thursday")]
        Thursday = 8,
        
        [JsonProperty("Tuesday")]
        Tuesday = 9,
        
        [JsonProperty("Wednesday")]
        Wednesday = 10,
        
        [JsonProperty("WinterDesignDay")]
        WinterDesignDay = 11,
    }
}