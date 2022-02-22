namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    public enum ZoneControl_Thermostat_Control1ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:DualSetpoint")]
        ThermostatSetpointDualSetpoint = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleCooling")]
        ThermostatSetpointSingleCooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleHeating")]
        ThermostatSetpointSingleHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThermostatSetpoint:SingleHeatingOrCooling")]
        ThermostatSetpointSingleHeatingOrCooling = 3,
    }
}