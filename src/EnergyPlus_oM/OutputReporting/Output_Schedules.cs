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
    public class Output_Schedules : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("key_field")]
        public Output_Schedules_KeyField KeyField { get; set; } = (Output_Schedules_KeyField)Enum.Parse(typeof(Output_Schedules_KeyField), "Hourly");
    }
}