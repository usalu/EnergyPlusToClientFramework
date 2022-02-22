using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("A Schedule:Day:Interval contains a full day of values with specified end times fo" +
                 "r each value Currently, is set up to allow for 10 minute intervals for an entire" +
                 " day.")]
    [JsonObject("Schedule:Day:Interval")]
    public class Schedule_Day_Interval : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("schedule_type_limits_name")]
        public string ScheduleTypeLimitsName { get; set; } = "";
        

        [Description(@"when the interval does not match the user specified timestep a Average choice will average between the intervals request (to timestep resolution. A No choice will use the interval value at the simulation timestep without regard to if it matches the boundary or not. A Linear choice will interpolate linearly between successive values.")]
        [JsonProperty("interpolate_to_timestep")]
        public Schedule_Day_Interval_InterpolateToTimestep InterpolateToTimestep { get; set; } = (Schedule_Day_Interval_InterpolateToTimestep)Enum.Parse(typeof(Schedule_Day_Interval_InterpolateToTimestep), "No");
        

        [JsonProperty("data")]
        public string Data { get; set; } = "";
    }
}