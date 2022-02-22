namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DualDuct_CoolingCoilSetpointControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedSetpoint")]
        FixedSetpoint = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Warmest")]
        Warmest = 4,
    }
}