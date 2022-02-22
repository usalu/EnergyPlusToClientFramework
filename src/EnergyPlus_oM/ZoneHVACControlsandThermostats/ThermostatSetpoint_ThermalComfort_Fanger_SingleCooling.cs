using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used for cooling only thermal comfort control. The PMV setpoint can be scheduled " +
                 "and varied throughout the simulation but only cooling is allowed with this contr" +
                 "ol type.")]
    [JsonObject("ThermostatSetpoint:ThermalComfort:Fanger:SingleCooling")]
    public class ThermostatSetpoint_ThermalComfort_Fanger_SingleCooling : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Schedule values should be Predicted Mean Vote (PMV)")]
        [JsonProperty("fanger_thermal_comfort_schedule_name")]
        public string FangerThermalComfortScheduleName { get; set; } = "";
    }
}