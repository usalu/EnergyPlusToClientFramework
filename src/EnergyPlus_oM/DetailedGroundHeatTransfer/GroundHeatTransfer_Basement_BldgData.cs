using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Specifies the surface and gravel thicknesses used for the Basement preprocessor g" +
                 "round heat transfer simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_BldgData : BHoMObject
    {
        

        [JsonProperty("dwall_wall_thickness")]
        public System.Nullable<float> DwallWallThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("dslab_floor_slab_thickness")]
        public System.Nullable<float> DslabFloorSlabThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("dgravxy_width_of_gravel_pit_beside_basement_wall")]
        public System.Nullable<float> DgravxyWidthOfGravelPitBesideBasementWall { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

        [JsonProperty("dgravzn_gravel_depth_extending_above_the_floor_slab")]
        public System.Nullable<float> DgravznGravelDepthExtendingAboveTheFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("dgravzp_gravel_depth_below_the_floor_slab")]
        public System.Nullable<float> DgravzpGravelDepthBelowTheFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
    }
}