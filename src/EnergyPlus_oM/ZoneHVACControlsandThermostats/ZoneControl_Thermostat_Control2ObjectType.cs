using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    public enum ZoneControl_Thermostat_Control2ObjectType
    {
        
        [JsonProperty("ThermostatSetpoint:DualSetpoint")]
        ThermostatSetpointDualSetpoint = 0,
        
        [JsonProperty("ThermostatSetpoint:SingleCooling")]
        ThermostatSetpointSingleCooling = 1,
        
        [JsonProperty("ThermostatSetpoint:SingleHeating")]
        ThermostatSetpointSingleHeating = 2,
        
        [JsonProperty("ThermostatSetpoint:SingleHeatingOrCooling")]
        ThermostatSetpointSingleHeatingOrCooling = 3,
    }
}