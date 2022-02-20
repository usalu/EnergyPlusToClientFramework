using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used for a heating and cooling thermostat with dual setpoints. The setpoints can " +
                 "be scheduled and varied throughout the simulation for both heating and cooling.")]
    [JsonObject("ThermostatSetpoint:DualSetpoint")]
    public class ThermostatSetpoint_DualSetpoint : BHoMObject
    {
        

        [JsonProperty("heating_setpoint_temperature_schedule_name")]
        public string HeatingSetpointTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("cooling_setpoint_temperature_schedule_name")]
        public string CoolingSetpointTemperatureScheduleName { get; set; } = "";
    }
}