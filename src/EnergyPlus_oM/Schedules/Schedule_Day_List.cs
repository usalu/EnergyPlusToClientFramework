using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("Schedule:Day:List will allow the user to list 24 hours worth of values, which can" +
                 " be sub-hourly in nature.")]
    [JsonObject("Schedule:Day:List")]
    public class Schedule_Day_List : BHoMObject
    {
        

        [JsonProperty("schedule_type_limits_name")]
        public string ScheduleTypeLimitsName { get; set; } = "";
        

        [Description(@"when the interval does not match the user specified timestep a ""Average"" choice will average between the intervals request (to timestep resolution. A ""No"" choice will use the interval value at the simulation timestep without regard to if it matches the boundary or not. A ""Linear"" choice will interpolate linearly between successive values.")]
        [JsonProperty("interpolate_to_timestep")]
        public EmptyNoYes InterpolateToTimestep { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Must be evenly divisible into 60")]
        [JsonProperty("minutes_per_item")]
        public System.Nullable<float> MinutesPerItem { get; set; } = null;
        

        [JsonProperty("extensions")]
        public string Extensions { get; set; } = "";
    }
}