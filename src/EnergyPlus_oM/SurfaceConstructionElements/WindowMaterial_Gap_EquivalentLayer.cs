using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Gas material properties that are used in Windows Equivalent Layer References only" +
                 " WindowMaterial:Gas properties")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Gap_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("gas_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Gap_EquivalentLayer_GasType GasType { get; set; } = (WindowMaterial_Gap_EquivalentLayer_GasType)Enum.Parse(typeof(WindowMaterial_Gap_EquivalentLayer_GasType), "AIR");
        

        [JsonProperty("thickness")]
        public System.Nullable<float> Thickness { get; set; } = null;
        

        [Description(@"Sealed means the gap is enclosed and gas tight, i.e., no venting to indoor or outdoor environment. VentedIndoor means the gap is vented to indoor environment, and VentedOutdoor means the gap is vented to the outdoor environment. The gap types VentedIndoor and VentedOutdoor are used with gas type ""Air"" only.")]
        [JsonProperty("gap_vent_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Gap_EquivalentLayer_GapVentType GapVentType { get; set; } = (WindowMaterial_Gap_EquivalentLayer_GapVentType)Enum.Parse(typeof(WindowMaterial_Gap_EquivalentLayer_GapVentType), "Sealed");
        

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