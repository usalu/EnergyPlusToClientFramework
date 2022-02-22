using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Simulate generic contaminant source driven by the pressure difference across a su" +
                 "rface.")]
    public class SurfaceContaminantSourceAndSink_Generic_PressureDriven : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("design_generation_rate_coefficient")]
        public System.Nullable<float> DesignGenerationRateCoefficient { get; set; } = null;
        

        [Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
                     "Design Generation Rate Coefficient")]
        [JsonProperty("generation_schedule_name")]
        public string GenerationScheduleName { get; set; } = "";
        

        [JsonProperty("generation_exponent")]
        public System.Nullable<float> GenerationExponent { get; set; } = null;
    }
}