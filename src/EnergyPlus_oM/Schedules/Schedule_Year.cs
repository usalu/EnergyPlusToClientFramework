using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("A Schedule:Year contains from 1 to 52 week schedules")]
    public class Schedule_Year : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("schedule_type_limits_name")]
        public string ScheduleTypeLimitsName { get; set; } = "";
        

        [JsonProperty("schedule_weeks")]
        public string ScheduleWeeks { get; set; } = "";
    }
}