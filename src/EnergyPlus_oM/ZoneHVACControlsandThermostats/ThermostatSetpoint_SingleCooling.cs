using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used for a cooling only thermostat. The setpoint can be scheduled and varied thro" +
                 "ughout the simulation but only cooling is allowed.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_SingleCooling : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("setpoint_temperature_schedule_name")]
        public string SetpointTemperatureScheduleName { get; set; } = "";
    }
}