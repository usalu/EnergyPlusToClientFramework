using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("AutoGrid only necessary when EquivSizing is false If the modeled building is not " +
                 "a rectangle or square, Equivalent sizing MUST be used to get accurate results")]
    [JsonObject("GroundHeatTransfer:Basement:AutoGrid")]
    public class GroundHeatTransfer_Basement_AutoGrid : BHoMObject
    {
        

        [JsonProperty("clearance_distance_from_outside_of_wall_to_edge_")]
        public System.Nullable<float> ClearanceDistanceFromOutsideOfWallToEdge { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty("slabx_x_dimension_of_the_building_slab")]
        public System.Nullable<float> SlabxXDimensionOfTheBuildingSlab { get; set; } = null;
        

        [JsonProperty("slaby_y_dimension_of_the_building_slab")]
        public System.Nullable<float> SlabyYDimensionOfTheBuildingSlab { get; set; } = null;
        

        [JsonProperty("concagheight_height_of_the_foundation_wall_above_grade")]
        public System.Nullable<float> ConcagheightHeightOfTheFoundationWallAboveGrade { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("slabdepth_thickness_of_the_floor_slab")]
        public System.Nullable<float> SlabdepthThicknessOfTheFloorSlab { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("basedepth_depth_of_the_basement_wall_below_grade")]
        public System.Nullable<float> BasedepthDepthOfTheBasementWallBelowGrade { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
}