using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DefaultMultipliers")]
        DefaultMultipliers = 1,
        
        [JsonProperty("DifferenceSchedule")]
        DifferenceSchedule = 2,
        
        [JsonProperty("MultiplierSchedule")]
        MultiplierSchedule = 3,
        
        [JsonProperty("TemperatureProfileSchedule")]
        TemperatureProfileSchedule = 4,
    }
}