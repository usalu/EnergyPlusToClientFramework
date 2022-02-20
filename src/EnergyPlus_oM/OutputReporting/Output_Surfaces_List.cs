using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Produces a report summarizing the details of surfaces in the eio output file.")]
    [JsonObject("Output:Surfaces:List")]
    public class Output_Surfaces_List : BHoMObject
    {
        

        [JsonProperty("report_type")]
        public EmptyNoYes ReportType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("(IDF, only for Output:Surfaces:List, Lines report -- will print transformed coord" +
                     "inates in IDF style)")]
        [JsonProperty("report_specifications")]
        public EmptyNoYes ReportSpecifications { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
    }
}