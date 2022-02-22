using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("AutoGrid only necessary when EquivalentSlab option not chosen. Not normally neede" +
                 "d by EnergyPlus users. This object permits user selection of rectangular slab di" +
                 "mensions. NO SLAB DIMENSIONS LESS THAN 6 m.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Slab_AutoGrid : BHoMObject
    {
        

        [Description("typical values= 6 to 60.0")]
        [JsonProperty("slabx_x_dimension_of_the_building_slab")]
        public System.Nullable<float> SlabxXDimensionOfTheBuildingSlab { get; set; } = null;
        

        [Description("typical values= 6 to 60.0")]
        [JsonProperty("slaby_y_dimension_of_the_building_slab")]
        public System.Nullable<float> SlabyYDimensionOfTheBuildingSlab { get; set; } = null;
        

        [JsonProperty("slabdepth_thickness_of_slab_on_grade")]
        public System.Nullable<float> SlabdepthThicknessOfSlabOnGrade { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty("clearance_distance_from_edge_of_slab_to_domain_edge")]
        public System.Nullable<float> ClearanceDistanceFromEdgeOfSlabToDomainEdge { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty("zclearance_distance_from_bottom_of_slab_to_domain_bottom")]
        public System.Nullable<float> ZclearanceDistanceFromBottomOfSlabToDomainBottom { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
    }
}