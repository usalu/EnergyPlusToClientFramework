using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("Properties for vertical ground heat exchanger systems")]
    [JsonObject("GroundHeatExchanger:Vertical:Properties")]
    public class GroundHeatExchanger_Vertical_Properties : BHoMObject
    {
        

        [JsonProperty("depth_of_top_of_borehole")]
        public System.Nullable<float> DepthOfTopOfBorehole { get; set; } = null;
        

        [JsonProperty("borehole_length")]
        public System.Nullable<float> BoreholeLength { get; set; } = null;
        

        [JsonProperty("borehole_diameter")]
        public System.Nullable<float> BoreholeDiameter { get; set; } = null;
        

        [JsonProperty("grout_thermal_conductivity")]
        public System.Nullable<float> GroutThermalConductivity { get; set; } = null;
        

        [JsonProperty("grout_thermal_heat_capacity")]
        public System.Nullable<float> GroutThermalHeatCapacity { get; set; } = null;
        

        [JsonProperty("pipe_thermal_conductivity")]
        public System.Nullable<float> PipeThermalConductivity { get; set; } = null;
        

        [JsonProperty("pipe_thermal_heat_capacity")]
        public System.Nullable<float> PipeThermalHeatCapacity { get; set; } = null;
        

        [JsonProperty("pipe_outer_diameter")]
        public System.Nullable<float> PipeOuterDiameter { get; set; } = null;
        

        [JsonProperty("pipe_thickness")]
        public System.Nullable<float> PipeThickness { get; set; } = null;
        

        [JsonProperty("u_tube_distance")]
        public System.Nullable<float> UTubeDistance { get; set; } = null;
    }
}