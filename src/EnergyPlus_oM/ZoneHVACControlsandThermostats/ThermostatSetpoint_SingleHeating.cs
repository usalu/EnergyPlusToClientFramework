using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used for a heating only thermostat. The setpoint can be scheduled and varied thro" +
                 "ughout the simulation but only heating is allowed with this control type.")]
    public class ThermostatSetpoint_SingleHeating : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("setpoint_temperature_schedule_name")]
        public string SetpointTemperatureScheduleName { get; set; } = "";
    }
}