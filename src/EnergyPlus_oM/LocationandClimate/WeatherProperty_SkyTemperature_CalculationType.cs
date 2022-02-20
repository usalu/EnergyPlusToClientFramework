using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum WeatherProperty_SkyTemperature_CalculationType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BerdahlMartin")]
        BerdahlMartin = 1,
        
        [JsonProperty("Brunt")]
        Brunt = 2,
        
        [JsonProperty("ClarkAllen")]
        ClarkAllen = 3,
        
        [JsonProperty("DifferenceScheduleDewPointValue")]
        DifferenceScheduleDewPointValue = 4,
        
        [JsonProperty("DifferenceScheduleDryBulbValue")]
        DifferenceScheduleDryBulbValue = 5,
        
        [JsonProperty("Idso")]
        Idso = 6,
        
        [JsonProperty("ScheduleValue")]
        ScheduleValue = 7,
    }
}