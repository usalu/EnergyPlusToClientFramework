using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    public enum RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode
    {
        
        [JsonProperty("OutdoorDryBulbTemperature")]
        OutdoorDryBulbTemperature = 0,
        
        [JsonProperty("SensibleCoolingLoad")]
        SensibleCoolingLoad = 1,
        
        [JsonProperty("SensibleHeatingLoad")]
        SensibleHeatingLoad = 2,
        
        [JsonProperty("ZoneAndOutdoorTemperatureDifference")]
        ZoneAndOutdoorTemperatureDifference = 3,
        
        [JsonProperty("ZoneDryBulbTemperature")]
        ZoneDryBulbTemperature = 4,
    }
}