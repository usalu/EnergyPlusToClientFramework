using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Additional properties for temperature dependent thermal conductivity using piecewise linear temperature-conductivity function. HeatBalanceAlgorithm = CondFD(ConductionFiniteDifference) solution algorithm only. Has no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_VariableThermalConductivity : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty("temperature_1")]
        public System.Nullable<float> Temperature1 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 1")]
        [JsonProperty("thermal_conductivity_1")]
        public System.Nullable<float> ThermalConductivity1 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty("temperature_2")]
        public System.Nullable<float> Temperature2 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 2")]
        [JsonProperty("thermal_conductivity_2")]
        public System.Nullable<float> ThermalConductivity2 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty("temperature_3")]
        public System.Nullable<float> Temperature3 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 3")]
        [JsonProperty("thermal_conductivity_3")]
        public System.Nullable<float> ThermalConductivity3 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty("temperature_4")]
        public System.Nullable<float> Temperature4 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 4")]
        [JsonProperty("thermal_conductivity_4")]
        public System.Nullable<float> ThermalConductivity4 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty("temperature_5")]
        public System.Nullable<float> Temperature5 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 5")]
        [JsonProperty("thermal_conductivity_5")]
        public System.Nullable<float> ThermalConductivity5 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty("temperature_6")]
        public System.Nullable<float> Temperature6 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 6")]
        [JsonProperty("thermal_conductivity_6")]
        public System.Nullable<float> ThermalConductivity6 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty("temperature_7")]
        public System.Nullable<float> Temperature7 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 7")]
        [JsonProperty("thermal_conductivity_7")]
        public System.Nullable<float> ThermalConductivity7 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty("temperature_8")]
        public System.Nullable<float> Temperature8 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 8")]
        [JsonProperty("thermal_conductivity_8")]
        public System.Nullable<float> ThermalConductivity8 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty("temperature_9")]
        public System.Nullable<float> Temperature9 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 9")]
        [JsonProperty("thermal_conductivity_9")]
        public System.Nullable<float> ThermalConductivity9 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty("temperature_10")]
        public System.Nullable<float> Temperature10 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 10")]
        [JsonProperty("thermal_conductivity_10")]
        public System.Nullable<float> ThermalConductivity10 { get; set; } = null;
    }
}