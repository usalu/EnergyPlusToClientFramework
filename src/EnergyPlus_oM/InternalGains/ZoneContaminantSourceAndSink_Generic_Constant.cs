using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Sets internal generic contaminant gains and sinks in a zone with constant values." +
                 "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneContaminantSourceAndSink_Generic_Constant : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("The values represent source.")]
        [JsonProperty("design_generation_rate")]
        public System.Nullable<float> DesignGenerationRate { get; set; } = null;
        

        [Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
                     "Design Generation Rate")]
        [JsonProperty("generation_schedule_name")]
        public string GenerationScheduleName { get; set; } = "";
        

        [Description("The value represent sink.")]
        [JsonProperty("design_removal_coefficient")]
        public System.Nullable<float> DesignRemovalCoefficient { get; set; } = null;
        

        [Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
                     "Design removal Coefficient")]
        [JsonProperty("removal_schedule_name")]
        public string RemovalScheduleName { get; set; } = "";
    }
}