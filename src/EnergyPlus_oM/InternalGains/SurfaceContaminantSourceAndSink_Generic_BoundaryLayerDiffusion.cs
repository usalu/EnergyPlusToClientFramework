using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Simulate generic contaminant source driven by the boundary layer diffusion contro" +
                 "lled model.")]
    [JsonObject("SurfaceContaminantSourceAndSink:Generic:BoundaryLayerDiffusion")]
    public class SurfaceContaminantSourceAndSink_Generic_BoundaryLayerDiffusion : BHoMObject
    {
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("mass_transfer_coefficient")]
        public System.Nullable<float> MassTransferCoefficient { get; set; } = null;
        

        [Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
                     "Initial Emission Rate. When the value is equal to 1.0, the time will be reset to" +
                     " zero.")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [JsonProperty("henry_adsorption_constant_or_partition_coefficient")]
        public System.Nullable<float> HenryAdsorptionConstantOrPartitionCoefficient { get; set; } = null;
    }
}