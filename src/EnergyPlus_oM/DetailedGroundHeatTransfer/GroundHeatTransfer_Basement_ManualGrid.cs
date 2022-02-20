using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Manual Grid only necessary using manual gridding (not recommended)")]
    [JsonObject("GroundHeatTransfer:Basement:ManualGrid")]
    public class GroundHeatTransfer_Basement_ManualGrid : BHoMObject
    {
        

        [JsonProperty("nx_number_of_cells_in_the_x_direction_20_")]
        public System.Nullable<float> NxNumberOfCellsInTheXDirection20 { get; set; } = null;
        

        [JsonProperty("ny_number_of_cells_in_the_y_direction_20_")]
        public System.Nullable<float> NyNumberOfCellsInTheYDirection20 { get; set; } = null;
        

        [JsonProperty("nzag_number_of_cells_in_the_z_direction_above_grade_4_always_")]
        public System.Nullable<float> NzagNumberOfCellsInTheZDirectionAboveGrade4Always { get; set; } = null;
        

        [JsonProperty("nzbg_number_of_cells_in_z_direction_below_grade_10_35_")]
        public System.Nullable<float> NzbgNumberOfCellsInZDirectionBelowGrade1035 { get; set; } = null;
        

        [JsonProperty("ibase_x_direction_cell_indicator_of_slab_edge_5_20_")]
        public System.Nullable<float> IbaseXDirectionCellIndicatorOfSlabEdge520 { get; set; } = null;
        

        [JsonProperty("jbase_y_direction_cell_indicator_of_slab_edge_5_20_")]
        public System.Nullable<float> JbaseYDirectionCellIndicatorOfSlabEdge520 { get; set; } = null;
        

        [JsonProperty("kbase_z_direction_cell_indicator_of_the_top_of_the_floor_slab_5_20_")]
        public System.Nullable<float> KbaseZDirectionCellIndicatorOfTheTopOfTheFloorSlab520 { get; set; } = null;
    }
}