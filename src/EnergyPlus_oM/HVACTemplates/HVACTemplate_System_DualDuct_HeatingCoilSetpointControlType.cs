namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DualDuct_HeatingCoilSetpointControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coldest")]
        Coldest = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedSetpoint")]
        FixedSetpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 4,
    }
}