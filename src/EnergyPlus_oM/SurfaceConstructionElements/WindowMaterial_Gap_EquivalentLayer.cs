using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Gas material properties that are used in Windows Equivalent Layer References only" +
                 " WindowMaterial:Gas properties")]
    [JsonObject("WindowMaterial:Gap:EquivalentLayer")]
    public class WindowMaterial_Gap_EquivalentLayer : BHoMObject
    {
        

        [JsonProperty("gas_type")]
        public EmptyNoYes GasType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("thickness")]
        public System.Nullable<float> Thickness { get; set; } = null;
        

        [Description(@"Sealed means the gap is enclosed and gas tight, i.e., no venting to indoor or outdoor environment. VentedIndoor means the gap is vented to indoor environment, and VentedOutdoor means the gap is vented to the outdoor environment. The gap types VentedIndoor and VentedOutdoor are used with gas type ""Air"" only.")]
        [JsonProperty("gap_vent_type")]
        public EmptyNoYes GapVentType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

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