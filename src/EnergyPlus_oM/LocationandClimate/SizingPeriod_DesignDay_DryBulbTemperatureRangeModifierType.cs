namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DefaultMultipliers")]
        DefaultMultipliers = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferenceSchedule")]
        DifferenceSchedule = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MultiplierSchedule")]
        MultiplierSchedule = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureProfileSchedule")]
        TemperatureProfileSchedule = 4,
    }
}