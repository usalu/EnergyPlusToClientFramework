namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_PackagedVAV_CoolingCoilSetpointResetType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Warmest")]
        Warmest = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="WarmestTemperatureFirst")]
        WarmestTemperatureFirst = 4,
    }
}