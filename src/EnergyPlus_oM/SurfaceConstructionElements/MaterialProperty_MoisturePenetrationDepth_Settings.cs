using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Additional properties for moisture using EMPD procedure HeatBalanceAlgorithm choi" +
                 "ce=MoisturePenetrationDepthConductionTransferFunction only Has no effect with ot" +
                 "her HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:MoisturePenetrationDepth:Settings")]
    public class MaterialProperty_MoisturePenetrationDepth_Settings : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Ratio of water vapor permeability of stagnant air to water vapor permeability of " +
                     "material")]
        [JsonProperty("water_vapor_diffusion_resistance_factor")]
        public System.Nullable<float> WaterVaporDiffusionResistanceFactor { get; set; } = null;
        

        [JsonProperty("moisture_equation_coefficient_a")]
        public System.Nullable<float> MoistureEquationCoefficientA { get; set; } = null;
        

        [JsonProperty("moisture_equation_coefficient_b")]
        public System.Nullable<float> MoistureEquationCoefficientB { get; set; } = null;
        

        [JsonProperty("moisture_equation_coefficient_c")]
        public System.Nullable<float> MoistureEquationCoefficientC { get; set; } = null;
        

        [JsonProperty("moisture_equation_coefficient_d")]
        public System.Nullable<float> MoistureEquationCoefficientD { get; set; } = null;
        

        [JsonProperty("surface_layer_penetration_depth")]
        public string SurfaceLayerPenetrationDepth { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("deep_layer_penetration_depth")]
        public string DeepLayerPenetrationDepth { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("coating_layer_thickness")]
        public System.Nullable<float> CoatingLayerThickness { get; set; } = null;
        

        [Description("The coating\'s resistance to water vapor diffusion relative to the resistance to w" +
                     "ater vapor diffusion in stagnant air (see Water Vapor Diffusion Resistance Facto" +
                     "r above).")]
        [JsonProperty("coating_layer_water_vapor_diffusion_resistance_factor")]
        public System.Nullable<float> CoatingLayerWaterVaporDiffusionResistanceFactor { get; set; } = null;
    }
}