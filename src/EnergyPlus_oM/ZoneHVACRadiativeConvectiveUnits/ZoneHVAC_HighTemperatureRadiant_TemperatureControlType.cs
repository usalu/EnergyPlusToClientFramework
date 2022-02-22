namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_HighTemperatureRadiant_TemperatureControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperatureSetpoint")]
        MeanAirTemperatureSetpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanRadiantTemperature")]
        MeanRadiantTemperature = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanRadiantTemperatureSetpoint")]
        MeanRadiantTemperatureSetpoint = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OperativeTemperature")]
        OperativeTemperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="OperativeTemperatureSetpoint")]
        OperativeTemperatureSetpoint = 6,
    }
}