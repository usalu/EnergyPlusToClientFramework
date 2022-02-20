using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("EquivAutoGrid necessary when EquivSizing=TRUE, TRUE is is the normal case.")]
    [JsonObject("GroundHeatTransfer:Basement:EquivAutoGrid")]
    public class GroundHeatTransfer_Basement_EquivAutoGrid : BHoMObject
    {
        

        [JsonProperty("clearance_distance_from_outside_of_wall_to_edge_of_3_d_ground_domain")]
        public System.Nullable<float> ClearanceDistanceFromOutsideOfWallToEdgeOf3DGroundDomain { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty("slabdepth_thickness_of_the_floor_slab")]
        public System.Nullable<float> SlabdepthThicknessOfTheFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("basedepth_depth_of_the_basement_wall_below_grade")]
        public System.Nullable<float> BasedepthDepthOfTheBasementWallBelowGrade { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
}