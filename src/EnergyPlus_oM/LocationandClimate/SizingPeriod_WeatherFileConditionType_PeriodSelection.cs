using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum SizingPeriod_WeatherFileConditionType_PeriodSelection
    {
        
        [JsonProperty("AutumnTypical")]
        AutumnTypical = 0,
        
        [JsonProperty("DrySeason")]
        DrySeason = 1,
        
        [JsonProperty("NoDrySeason")]
        NoDrySeason = 2,
        
        [JsonProperty("NoDrySeasonMax")]
        NoDrySeasonMax = 3,
        
        [JsonProperty("NoDrySeasonMin")]
        NoDrySeasonMin = 4,
        
        [JsonProperty("NoWetSeason")]
        NoWetSeason = 5,
        
        [JsonProperty("NoWetSeasonMax")]
        NoWetSeasonMax = 6,
        
        [JsonProperty("NoWetSeasonMin")]
        NoWetSeasonMin = 7,
        
        [JsonProperty("SpringTypical")]
        SpringTypical = 8,
        
        [JsonProperty("SummerExtreme")]
        SummerExtreme = 9,
        
        [JsonProperty("SummerTypical")]
        SummerTypical = 10,
        
        [JsonProperty("TropicalCold")]
        TropicalCold = 11,
        
        [JsonProperty("TropicalHot")]
        TropicalHot = 12,
        
        [JsonProperty("WetSeason")]
        WetSeason = 13,
        
        [JsonProperty("WinterExtreme")]
        WinterExtreme = 14,
        
        [JsonProperty("WinterTypical")]
        WinterTypical = 15,
    }
}