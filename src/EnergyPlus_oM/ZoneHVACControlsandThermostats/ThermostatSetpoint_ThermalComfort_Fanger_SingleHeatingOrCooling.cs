using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used for heating and cooling thermal comfort control with a single setpoint. The " +
                 "PMV setpoint can be scheduled and varied throughout the simulation for both heat" +
                 "ing and cooling.")]
    [JsonObject("ThermostatSetpoint:ThermalComfort:Fanger:SingleHeatingOrCooling")]
    public class ThermostatSetpoint_ThermalComfort_Fanger_SingleHeatingOrCooling : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Schedule values should be Predicted Mean Vote (PMV)")]
        [JsonProperty("fanger_thermal_comfort_schedule_name")]
        public string FangerThermalComfortScheduleName { get; set; } = "";
    }
}