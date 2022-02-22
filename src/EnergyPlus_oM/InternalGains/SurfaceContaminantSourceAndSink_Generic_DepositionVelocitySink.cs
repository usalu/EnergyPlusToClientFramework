using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Simulate generic contaminant source driven by the boundary layer diffusion contro" +
                 "lled model.")]
    public class SurfaceContaminantSourceAndSink_Generic_DepositionVelocitySink : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("deposition_velocity")]
        public System.Nullable<float> DepositionVelocity { get; set; } = null;
        

        [Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
                     "Initial Emission Rate. When the value is equal to 1.0, the time will be reset to" +
                     " zero.")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
    }
}