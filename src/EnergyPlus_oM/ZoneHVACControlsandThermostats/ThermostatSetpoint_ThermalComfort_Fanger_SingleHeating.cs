using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used for heating only thermal comfort control. The PMV setpoint can be scheduled " +
                 "and varied throughout the simulation but only heating is allowed with this contr" +
                 "ol type.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_ThermalComfort_Fanger_SingleHeating : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Schedule values should be Predicted Mean Vote (PMV)")]
        [JsonProperty("fanger_thermal_comfort_schedule_name")]
        public string FangerThermalComfortScheduleName { get; set; } = "";
    }
}