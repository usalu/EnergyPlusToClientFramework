using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Reports hourly daylight factors for each exterior window for four sky types (clea" +
                 "r, turbid clear, intermediate, and overcast).")]
    [JsonObject("Output:DaylightFactors")]
    public class Output_DaylightFactors : BHoMObject
    {
        

        [JsonProperty("reporting_days")]
        public EmptyNoYes ReportingDays { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
    }
}