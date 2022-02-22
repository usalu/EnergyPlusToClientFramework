using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Manual Grid only necessary when using manual gridding (not recommended) Used only" +
                 " in special cases when previous two objects are not used. User must input comple" +
                 "te gridding information.")]
    public class GroundHeatTransfer_Slab_ManualGrid : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("nx_number_of_cells_in_the_x_direction")]
        public System.Nullable<float> NxNumberOfCellsInTheXDirection { get; set; } = null;
        

        [JsonProperty("ny_number_of_cells_in_the_y_direction")]
        public System.Nullable<float> NyNumberOfCellsInTheYDirection { get; set; } = null;
        

        [JsonProperty("nz_number_of_cells_in_the_z_direction")]
        public System.Nullable<float> NzNumberOfCellsInTheZDirection { get; set; } = null;
        

        [Description("typical values= 1-10")]
        [JsonProperty("ibox_x_direction_cell_indicator_of_slab_edge")]
        public System.Nullable<float> IboxXDirectionCellIndicatorOfSlabEdge { get; set; } = null;
        

        [Description("typical values= 1-10")]
        [JsonProperty("jbox_y_direction_cell_indicator_of_slab_edge")]
        public System.Nullable<float> JboxYDirectionCellIndicatorOfSlabEdge { get; set; } = null;
    }
}