using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Produces a condensed reporting that illustrates the full range of schedule values" +
                 " in the eio output file. In the style of input: DaySchedule,  WeekSchedule, and " +
                 "Annual Schedule.")]
    [JsonObject("Output:Schedules")]
    public class Output_Schedules : BHoMObject
    {
        

        [JsonProperty("key_field")]
        public EmptyNoYes KeyField { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
    }
}