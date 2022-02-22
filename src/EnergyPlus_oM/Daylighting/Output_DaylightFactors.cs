using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Reports hourly daylight factors for each exterior window for four sky types (clea" +
                 "r, turbid clear, intermediate, and overcast).")]
    [JsonObject("Output:DaylightFactors")]
    public class Output_DaylightFactors : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("reporting_days")]
        public Output_DaylightFactors_ReportingDays ReportingDays { get; set; } = (Output_DaylightFactors_ReportingDays)Enum.Parse(typeof(Output_DaylightFactors_ReportingDays), "AllShadowCalculationDays");
    }
}