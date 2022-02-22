using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Reports hourly daylight factors for each exterior window for four sky types (clea" +
                 "r, turbid clear, intermediate, and overcast).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_DaylightFactors : BHoMObject
    {
        

        [JsonProperty("reporting_days")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_DaylightFactors_ReportingDays ReportingDays { get; set; } = (Output_DaylightFactors_ReportingDays)Enum.Parse(typeof(Output_DaylightFactors_ReportingDays), "AllShadowCalculationDays");
    }
}