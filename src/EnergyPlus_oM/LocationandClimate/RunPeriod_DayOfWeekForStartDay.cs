using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum RunPeriod_DayOfWeekForStartDay
    {
        
        [JsonProperty("Friday")]
        Friday = 0,
        
        [JsonProperty("Monday")]
        Monday = 1,
        
        [JsonProperty("Saturday")]
        Saturday = 2,
        
        [JsonProperty("Sunday")]
        Sunday = 3,
        
        [JsonProperty("Thursday")]
        Thursday = 4,
        
        [JsonProperty("Tuesday")]
        Tuesday = 5,
        
        [JsonProperty("Wednesday")]
        Wednesday = 6,
    }
}