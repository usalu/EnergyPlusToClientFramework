using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Represents internal CO2 gains and sinks in the zone.")]
    [JsonObject("ZoneContaminantSourceAndSink:CarbonDioxide")]
    public class ZoneContaminantSourceAndSink_CarbonDioxide : BHoMObject
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Positive values represent sources and negative values represent sinks.")]
        [JsonProperty("design_generation_rate")]
        public System.Nullable<float> DesignGenerationRate { get; set; } = null;
        

        [Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
                     "Design Generation Rate")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
    }
}