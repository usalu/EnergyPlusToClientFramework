using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used for heating and cooling thermal comfort control with dual setpoints. The PMV" +
                 " setpoints can be scheduled and varied throughout the simulation for both heatin" +
                 "g and cooling.")]
    public class ThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Schedule values should be Predicted Mean Vote (PMV)")]
        [JsonProperty("fanger_thermal_comfort_heating_schedule_name")]
        public string FangerThermalComfortHeatingScheduleName { get; set; } = "";
        

        [Description("Schedule values should be Predicted Mean Vote (PMV)")]
        [JsonProperty("fanger_thermal_comfort_cooling_schedule_name")]
        public string FangerThermalComfortCoolingScheduleName { get; set; } = "";
    }
}