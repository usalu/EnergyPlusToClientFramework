namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    public enum RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorDryBulbTemperature")]
        OutdoorDryBulbTemperature = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SensibleCoolingLoad")]
        SensibleCoolingLoad = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SensibleHeatingLoad")]
        SensibleHeatingLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAndOutdoorTemperatureDifference")]
        ZoneAndOutdoorTemperatureDifference = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneDryBulbTemperature")]
        ZoneDryBulbTemperature = 4,
    }
}