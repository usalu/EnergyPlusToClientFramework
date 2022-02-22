using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used for a cooling only thermostat. The setpoint can be scheduled and varied thro" +
                 "ughout the simulation but only cooling is allowed.")]
    public class ThermostatSetpoint_SingleCooling : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("setpoint_temperature_schedule_name")]
        public string SetpointTemperatureScheduleName { get; set; } = "";
    }
}