namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    public enum AvailabilityManager_NightCycle_CyclingRunTimeControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FixedRunTime")]
        FixedRunTime = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Thermostat")]
        Thermostat = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatWithMinimumRunTime")]
        ThermostatWithMinimumRunTime = 3,
    }
}