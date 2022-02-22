namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    public enum WeatherProperty_SkyTemperature_CalculationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BerdahlMartin")]
        BerdahlMartin = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Brunt")]
        Brunt = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ClarkAllen")]
        ClarkAllen = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferenceScheduleDewPointValue")]
        DifferenceScheduleDewPointValue = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="DifferenceScheduleDryBulbValue")]
        DifferenceScheduleDryBulbValue = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Idso")]
        Idso = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="ScheduleValue")]
        ScheduleValue = 7,
    }
}