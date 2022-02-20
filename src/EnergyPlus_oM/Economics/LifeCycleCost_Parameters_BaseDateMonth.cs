using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum LifeCycleCost_Parameters_BaseDateMonth
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("April")]
        April = 1,
        
        [JsonProperty("August")]
        August = 2,
        
        [JsonProperty("December")]
        December = 3,
        
        [JsonProperty("February")]
        February = 4,
        
        [JsonProperty("January")]
        January = 5,
        
        [JsonProperty("July")]
        July = 6,
        
        [JsonProperty("June")]
        June = 7,
        
        [JsonProperty("March")]
        March = 8,
        
        [JsonProperty("May")]
        May = 9,
        
        [JsonProperty("November")]
        November = 10,
        
        [JsonProperty("October")]
        October = 11,
        
        [JsonProperty("September")]
        September = 12,
    }
}