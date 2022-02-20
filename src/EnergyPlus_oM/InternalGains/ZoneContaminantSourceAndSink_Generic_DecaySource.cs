using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Simulate generic contaminant source driven by the cutoff concentration model.")]
    [JsonObject("ZoneContaminantSourceAndSink:Generic:DecaySource")]
    public class ZoneContaminantSourceAndSink_Generic_DecaySource : BHoMObject
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("initial_emission_rate")]
        public System.Nullable<float> InitialEmissionRate { get; set; } = null;
        

        [Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
                     "Initial Emission Rate. When the value is equal to 1.0, the time will be reset to" +
                     " zero.")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [JsonProperty("delay_time_constant")]
        public System.Nullable<float> DelayTimeConstant { get; set; } = null;
    }
}