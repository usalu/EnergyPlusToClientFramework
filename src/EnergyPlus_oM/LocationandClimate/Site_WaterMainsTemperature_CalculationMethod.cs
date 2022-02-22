namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum Site_WaterMainsTemperature_CalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Correlation")]
        Correlation = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CorrelationFromWeatherFile")]
        CorrelationFromWeatherFile = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 3,
    }
}