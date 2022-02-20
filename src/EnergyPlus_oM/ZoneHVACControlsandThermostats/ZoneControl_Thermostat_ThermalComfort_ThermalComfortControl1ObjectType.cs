using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    public enum ZoneControl_Thermostat_ThermalComfort_ThermalComfortControl1ObjectType
    {
        
        [JsonProperty("ThermostatSetpoint:ThermalComfort:Fanger:DualSetpoint")]
        ThermostatSetpointThermalComfortFangerDualSetpoint = 0,
        
        [JsonProperty("ThermostatSetpoint:ThermalComfort:Fanger:SingleCooling")]
        ThermostatSetpointThermalComfortFangerSingleCooling = 1,
        
        [JsonProperty("ThermostatSetpoint:ThermalComfort:Fanger:SingleHeating")]
        ThermostatSetpointThermalComfortFangerSingleHeating = 2,
        
        [JsonProperty("ThermostatSetpoint:ThermalComfort:Fanger:SingleHeatingOrCooling")]
        ThermostatSetpointThermalComfortFangerSingleHeatingOrCooling = 3,
    }
}