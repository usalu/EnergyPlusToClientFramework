namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_OutdoorAirReset_ControlVariable
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MaximumTemperature")]
        MaximumTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MinimumTemperature")]
        MinimumTemperature = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Temperature")]
        Temperature = 3,
    }
}