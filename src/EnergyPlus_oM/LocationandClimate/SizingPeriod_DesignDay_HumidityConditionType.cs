namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum SizingPeriod_DesignDay_HumidityConditionType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DewPoint")]
        DewPoint = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Enthalpy")]
        Enthalpy = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HumidityRatio")]
        HumidityRatio = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="RelativeHumiditySchedule")]
        RelativeHumiditySchedule = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="WetBulb")]
        WetBulb = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="WetBulbProfileDefaultMultipliers")]
        WetBulbProfileDefaultMultipliers = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="WetBulbProfileDifferenceSchedule")]
        WetBulbProfileDifferenceSchedule = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="WetBulbProfileMultiplierSchedule")]
        WetBulbProfileMultiplierSchedule = 8,
    }
}