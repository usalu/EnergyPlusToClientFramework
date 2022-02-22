using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
                 "ly. Relationship between thermal conductivity and moisture content Has no effect" +
                 " with other HeatBalanceAlgorithm solution algorithms")]
    public class MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Moisture Material Name that the Thermal Conductivity will be added to.")]
        [JsonProperty("material_name")]
        public string MaterialName { get; set; } = "";
        

        [Description("number of data coordinates")]
        [JsonProperty("number_of_thermal_coordinates")]
        public System.Nullable<float> NumberOfThermalCoordinates { get; set; } = null;
        

        [JsonProperty("moisture_content_1")]
        public System.Nullable<float> MoistureContent1 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_1")]
        public System.Nullable<float> ThermalConductivity1 { get; set; } = null;
        

        [JsonProperty("moisture_content_2")]
        public System.Nullable<float> MoistureContent2 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_2")]
        public System.Nullable<float> ThermalConductivity2 { get; set; } = null;
        

        [JsonProperty("moisture_content_3")]
        public System.Nullable<float> MoistureContent3 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_3")]
        public System.Nullable<float> ThermalConductivity3 { get; set; } = null;
        

        [JsonProperty("moisture_content_4")]
        public System.Nullable<float> MoistureContent4 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_4")]
        public System.Nullable<float> ThermalConductivity4 { get; set; } = null;
        

        [JsonProperty("moisture_content_5")]
        public System.Nullable<float> MoistureContent5 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_5")]
        public System.Nullable<float> ThermalConductivity5 { get; set; } = null;
        

        [JsonProperty("moisture_content_6")]
        public System.Nullable<float> MoistureContent6 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_6")]
        public System.Nullable<float> ThermalConductivity6 { get; set; } = null;
        

        [JsonProperty("moisture_content_7")]
        public System.Nullable<float> MoistureContent7 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_7")]
        public System.Nullable<float> ThermalConductivity7 { get; set; } = null;
        

        [JsonProperty("moisture_content_8")]
        public System.Nullable<float> MoistureContent8 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_8")]
        public System.Nullable<float> ThermalConductivity8 { get; set; } = null;
        

        [JsonProperty("moisture_content_9")]
        public System.Nullable<float> MoistureContent9 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_9")]
        public System.Nullable<float> ThermalConductivity9 { get; set; } = null;
        

        [JsonProperty("moisture_content_10")]
        public System.Nullable<float> MoistureContent10 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_10")]
        public System.Nullable<float> ThermalConductivity10 { get; set; } = null;
        

        [JsonProperty("moisture_content_11")]
        public System.Nullable<float> MoistureContent11 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_11")]
        public System.Nullable<float> ThermalConductivity11 { get; set; } = null;
        

        [JsonProperty("moisture_content_12")]
        public System.Nullable<float> MoistureContent12 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_12")]
        public System.Nullable<float> ThermalConductivity12 { get; set; } = null;
        

        [JsonProperty("moisture_content_13")]
        public System.Nullable<float> MoistureContent13 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_13")]
        public System.Nullable<float> ThermalConductivity13 { get; set; } = null;
        

        [JsonProperty("moisture_content_14")]
        public System.Nullable<float> MoistureContent14 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_14")]
        public System.Nullable<float> ThermalConductivity14 { get; set; } = null;
        

        [JsonProperty("moisture_content_15")]
        public System.Nullable<float> MoistureContent15 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_15")]
        public System.Nullable<float> ThermalConductivity15 { get; set; } = null;
        

        [JsonProperty("moisture_content_16")]
        public System.Nullable<float> MoistureContent16 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_16")]
        public System.Nullable<float> ThermalConductivity16 { get; set; } = null;
        

        [JsonProperty("moisture_content_17")]
        public System.Nullable<float> MoistureContent17 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_17")]
        public System.Nullable<float> ThermalConductivity17 { get; set; } = null;
        

        [JsonProperty("moisture_content_18")]
        public System.Nullable<float> MoistureContent18 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_18")]
        public System.Nullable<float> ThermalConductivity18 { get; set; } = null;
        

        [JsonProperty("moisture_content_19")]
        public System.Nullable<float> MoistureContent19 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_19")]
        public System.Nullable<float> ThermalConductivity19 { get; set; } = null;
        

        [JsonProperty("moisture_content_20")]
        public System.Nullable<float> MoistureContent20 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_20")]
        public System.Nullable<float> ThermalConductivity20 { get; set; } = null;
        

        [JsonProperty("moisture_content_21")]
        public System.Nullable<float> MoistureContent21 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_21")]
        public System.Nullable<float> ThermalConductivity21 { get; set; } = null;
        

        [JsonProperty("moisture_content_22")]
        public System.Nullable<float> MoistureContent22 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_22")]
        public System.Nullable<float> ThermalConductivity22 { get; set; } = null;
        

        [JsonProperty("moisture_content_23")]
        public System.Nullable<float> MoistureContent23 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_23")]
        public System.Nullable<float> ThermalConductivity23 { get; set; } = null;
        

        [JsonProperty("moisture_content_24")]
        public System.Nullable<float> MoistureContent24 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_24")]
        public System.Nullable<float> ThermalConductivity24 { get; set; } = null;
        

        [JsonProperty("moisture_content_25")]
        public System.Nullable<float> MoistureContent25 { get; set; } = null;
        

        [JsonProperty("thermal_conductivity_25")]
        public System.Nullable<float> ThermalConductivity25 { get; set; } = null;
    }
}