using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("switch eplusout.dbg file on or off")]
    [JsonObject("Output:DebuggingData")]
    public class Output_DebuggingData : BHoMObject
    {
        

        [JsonProperty("report_debugging_data")]
        public EmptyNoYes ReportDebuggingData { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("report_during_warmup")]
        public EmptyNoYes ReportDuringWarmup { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
}