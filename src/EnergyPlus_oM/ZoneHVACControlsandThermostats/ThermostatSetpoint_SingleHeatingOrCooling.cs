using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used for a heating and cooling thermostat with a single setpoint. The setpoint ca" +
                 "n be scheduled and varied throughout the simulation for both heating and cooling" +
                 ".")]
    [JsonObject("ThermostatSetpoint:SingleHeatingOrCooling")]
    public class ThermostatSetpoint_SingleHeatingOrCooling : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("setpoint_temperature_schedule_name")]
        public string SetpointTemperatureScheduleName { get; set; } = "";
    }
}