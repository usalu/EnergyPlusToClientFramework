using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description(@"Irregular object. Does not follow the usual definition for fields. Fields A3... are: Through: Date For: Applicable days (ref: Schedule:Week:Compact) Interpolate: Average/Linear/No (ref: Schedule:Day:Interval) -- optional, if not used will be ""No"" Until: <Time> (ref: Schedule:Day:Interval) <numeric value> words ""Through"",""For"",""Interpolate"",""Until"" must be included.")]
    public class Schedule_Compact : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("schedule_type_limits_name")]
        public string ScheduleTypeLimitsName { get; set; } = "";
        

        [JsonProperty("data")]
        public string Data { get; set; } = "";
    }
}