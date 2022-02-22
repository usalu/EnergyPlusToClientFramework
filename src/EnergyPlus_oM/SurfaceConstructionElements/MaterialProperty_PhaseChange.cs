using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Additional properties for temperature dependent thermal conductivity and enthalpy for Phase Change Materials (PCM) HeatBalanceAlgorithm = CondFD(ConductionFiniteDifference) solution algorithm only. Constructions with this should use the detailed CondFD process. Has no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:PhaseChange")]
    public class MaterialProperty_PhaseChange : BHoMObject, IEnergyPlusClass
    {
        

        [Description("The base temperature is 20C. This is the thermal conductivity change per degree e" +
                     "xcursion from 20C. This variable conductivity function is overridden by the Vari" +
                     "ableThermalConductivity object, if present.")]
        [JsonProperty("temperature_coefficient_for_thermal_conductivity")]
        public System.Nullable<float> TemperatureCoefficientForThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_1")]
        public System.Nullable<float> Temperature1 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 1")]
        [JsonProperty("enthalpy_1")]
        public System.Nullable<float> Enthalpy1 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_2")]
        public System.Nullable<float> Temperature2 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 2")]
        [JsonProperty("enthalpy_2")]
        public System.Nullable<float> Enthalpy2 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_3")]
        public System.Nullable<float> Temperature3 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 3")]
        [JsonProperty("enthalpy_3")]
        public System.Nullable<float> Enthalpy3 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_4")]
        public System.Nullable<float> Temperature4 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 4")]
        [JsonProperty("enthalpy_4")]
        public System.Nullable<float> Enthalpy4 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_5")]
        public System.Nullable<float> Temperature5 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 5")]
        [JsonProperty("enthalpy_5")]
        public System.Nullable<float> Enthalpy5 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_6")]
        public System.Nullable<float> Temperature6 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 6")]
        [JsonProperty("enthalpy_6")]
        public System.Nullable<float> Enthalpy6 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_7")]
        public System.Nullable<float> Temperature7 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 7")]
        [JsonProperty("enthalpy_7")]
        public System.Nullable<float> Enthalpy7 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_8")]
        public System.Nullable<float> Temperature8 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 8")]
        [JsonProperty("enthalpy_8")]
        public System.Nullable<float> Enthalpy8 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_9")]
        public System.Nullable<float> Temperature9 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 1")]
        [JsonProperty("enthalpy_9")]
        public System.Nullable<float> Enthalpy9 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_10")]
        public System.Nullable<float> Temperature10 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 2")]
        [JsonProperty("enthalpy_10")]
        public System.Nullable<float> Enthalpy10 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_11")]
        public System.Nullable<float> Temperature11 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 3")]
        [JsonProperty("enthalpy_11")]
        public System.Nullable<float> Enthalpy11 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_12")]
        public System.Nullable<float> Temperature12 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 14")]
        [JsonProperty("enthalpy_12")]
        public System.Nullable<float> Enthalpy12 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_13")]
        public System.Nullable<float> Temperature13 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 15")]
        [JsonProperty("enthalpy_13")]
        public System.Nullable<float> Enthalpy13 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_14")]
        public System.Nullable<float> Temperature14 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 16")]
        [JsonProperty("enthalpy_14")]
        public System.Nullable<float> Enthalpy14 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_15")]
        public System.Nullable<float> Temperature15 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 17")]
        [JsonProperty("enthalpy_15")]
        public System.Nullable<float> Enthalpy15 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty("temperature_16")]
        public System.Nullable<float> Temperature16 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 16")]
        [JsonProperty("enthalpy_16")]
        public System.Nullable<float> Enthalpy16 { get; set; } = null;
    }
}