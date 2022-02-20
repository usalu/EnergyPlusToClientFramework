using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    public enum ScheduleTypeLimits_UnitType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ActivityLevel")]
        ActivityLevel = 1,
        
        [JsonProperty("Angle")]
        Angle = 2,
        
        [JsonProperty("Availability")]
        Availability = 3,
        
        [JsonProperty("Capacity")]
        Capacity = 4,
        
        [JsonProperty("Control")]
        Control = 5,
        
        [JsonProperty("ConvectionCoefficient")]
        ConvectionCoefficient = 6,
        
        [JsonProperty("DeltaTemperature")]
        DeltaTemperature = 7,
        
        [JsonProperty("Dimensionless")]
        Dimensionless = 8,
        
        [JsonProperty("Mode")]
        Mode = 9,
        
        [JsonProperty("Percent")]
        Percent = 10,
        
        [JsonProperty("Power")]
        Power = 11,
        
        [JsonProperty("PrecipitationRate")]
        PrecipitationRate = 12,
        
        [JsonProperty("Temperature")]
        Temperature = 13,
        
        [JsonProperty("Velocity")]
        Velocity = 14,
    }
}