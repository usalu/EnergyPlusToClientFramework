using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("A Schedule:Year contains from 1 to 52 week schedules")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Year : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("schedule_type_limits_name")]
        public string ScheduleTypeLimitsName { get; set; } = "";
        

        [JsonProperty("schedule_weeks")]
        public string ScheduleWeeks { get; set; } = "";
    }
}