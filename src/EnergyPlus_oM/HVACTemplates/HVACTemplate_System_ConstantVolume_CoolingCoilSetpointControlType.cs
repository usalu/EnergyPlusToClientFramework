namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_ConstantVolume_CoolingCoilSetpointControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ControlZone")]
        ControlZone = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedSetpoint")]
        FixedSetpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Warmest")]
        Warmest = 5,
    }
}