using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Gas material properties that are used in Windows or Glass Doors")]
    public class WindowMaterial_Gas : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("gas_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Gas_GasType GasType { get; set; } = (WindowMaterial_Gas_GasType)Enum.Parse(typeof(WindowMaterial_Gas_GasType), "Air");
        

        [JsonProperty("thickness")]
        public System.Nullable<float> Thickness { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty("conductivity_coefficient_a")]
        public System.Nullable<float> ConductivityCoefficientA { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty("conductivity_coefficient_b")]
        public System.Nullable<float> ConductivityCoefficientB { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty("conductivity_coefficient_c")]
        public System.Nullable<float> ConductivityCoefficientC { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty("viscosity_coefficient_a")]
        public System.Nullable<float> ViscosityCoefficientA { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty("viscosity_coefficient_b")]
        public System.Nullable<float> ViscosityCoefficientB { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty("viscosity_coefficient_c")]
        public System.Nullable<float> ViscosityCoefficientC { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty("specific_heat_coefficient_a")]
        public System.Nullable<float> SpecificHeatCoefficientA { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty("specific_heat_coefficient_b")]
        public System.Nullable<float> SpecificHeatCoefficientB { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty("specific_heat_coefficient_c")]
        public System.Nullable<float> SpecificHeatCoefficientC { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty("molecular_weight")]
        public System.Nullable<float> MolecularWeight { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty("specific_heat_ratio")]
        public System.Nullable<float> SpecificHeatRatio { get; set; } = null;
    }
}