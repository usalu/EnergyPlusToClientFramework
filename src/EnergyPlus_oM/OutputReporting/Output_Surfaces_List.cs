using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Produces a report summarizing the details of surfaces in the eio output file.")]
    [JsonObject("Output:Surfaces:List")]
    public class Output_Surfaces_List : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("report_type")]
        public Output_Surfaces_List_ReportType ReportType { get; set; } = (Output_Surfaces_List_ReportType)Enum.Parse(typeof(Output_Surfaces_List_ReportType), "CostInfo");
        

        [Description("(IDF, only for Output:Surfaces:List, Lines report -- will print transformed coord" +
                     "inates in IDF style)")]
        [JsonProperty("report_specifications")]
        public Output_Surfaces_List_ReportSpecifications ReportSpecifications { get; set; } = (Output_Surfaces_List_ReportSpecifications)Enum.Parse(typeof(Output_Surfaces_List_ReportSpecifications), "IDF");
    }
}