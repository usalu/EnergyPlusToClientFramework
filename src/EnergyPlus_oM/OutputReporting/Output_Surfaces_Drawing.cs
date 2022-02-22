using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Produces reports/files that are capable of rendering graphically or being importe" +
                 "d into other programs. Rendering does not alter the actual inputs/surfaces.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Surfaces_Drawing : BHoMObject
    {
        

        [JsonProperty("report_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_Surfaces_Drawing_ReportType ReportType { get; set; } = (Output_Surfaces_Drawing_ReportType)Enum.Parse(typeof(Output_Surfaces_Drawing_ReportType), "DXF");
        

        [Description("Triangulate3DFace (default), ThickPolyline, RegularPolyline apply to DXF This fie" +
                     "ld is ignored for DXF:WireFrame and VRML")]
        [JsonProperty("report_specifications_1")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_Surfaces_Drawing_ReportSpecifications1 ReportSpecifications1 { get; set; } = (Output_Surfaces_Drawing_ReportSpecifications1)Enum.Parse(typeof(Output_Surfaces_Drawing_ReportSpecifications1), "Triangulate3DFace");
        

        [Description("Use ColorScheme Name for DXF reports")]
        [JsonProperty("report_specifications_2")]
        public string ReportSpecifications2 { get; set; } = "";
    }
}