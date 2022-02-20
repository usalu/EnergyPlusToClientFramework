using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Simulate generic contaminant source driven by the boundary layer diffusion contro" +
                 "lled model.")]
    [JsonObject("ZoneContaminantSourceAndSink:Generic:DepositionRateSink")]
    public class ZoneContaminantSourceAndSink_Generic_DepositionRateSink : BHoMObject
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("deposition_rate")]
        public System.Nullable<float> DepositionRate { get; set; } = null;
        

        [Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
                     "Initial Emission Rate. When the value is equal to 1.0, the time will be reset to" +
                     " zero.")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
    }
}