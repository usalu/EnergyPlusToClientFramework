using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum SizingPeriod_DesignDay_HumidityConditionType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DewPoint")]
        DewPoint = 1,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 2,
        
        [JsonProperty("HumidityRatio")]
        HumidityRatio = 3,
        
        [JsonProperty("RelativeHumiditySchedule")]
        RelativeHumiditySchedule = 4,
        
        [JsonProperty("WetBulb")]
        WetBulb = 5,
        
        [JsonProperty("WetBulbProfileDefaultMultipliers")]
        WetBulbProfileDefaultMultipliers = 6,
        
        [JsonProperty("WetBulbProfileDifferenceSchedule")]
        WetBulbProfileDifferenceSchedule = 7,
        
        [JsonProperty("WetBulbProfileMultiplierSchedule")]
        WetBulbProfileMultiplierSchedule = 8,
    }
}