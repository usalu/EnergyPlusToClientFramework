using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Simulate generic contaminant source driven by the cutoff concentration model.")]
    [JsonObject("ZoneContaminantSourceAndSink:Generic:CutoffModel")]
    public class ZoneContaminantSourceAndSink_Generic_CutoffModel : BHoMObject
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("design_generation_rate_coefficient")]
        public System.Nullable<float> DesignGenerationRateCoefficient { get; set; } = null;
        

        [Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
                     "Design Generation Rate Coefficient")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description("When the zone concentration level is greater than the cutoff level, emission stop" +
                     "s, and the source level is zero.")]
        [JsonProperty("cutoff_generic_contaminant_at_which_emission_ceases")]
        public System.Nullable<float> CutoffGenericContaminantAtWhichEmissionCeases { get; set; } = null;
    }
}