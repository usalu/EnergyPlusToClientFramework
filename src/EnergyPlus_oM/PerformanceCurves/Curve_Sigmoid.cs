using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Sigmoid curve with one independent variable. Input consists of the curve name, the five coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = C1+C2/[1+exp((C3-x)/C4)]**C5")]
    public class Curve_Sigmoid : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("coefficient1_c1")]
        public System.Nullable<float> Coefficient1C1 { get; set; } = null;
        

        [JsonProperty("coefficient2_c2")]
        public System.Nullable<float> Coefficient2C2 { get; set; } = null;
        

        [JsonProperty("coefficient3_c3")]
        public System.Nullable<float> Coefficient3C3 { get; set; } = null;
        

        [JsonProperty("coefficient4_c4")]
        public System.Nullable<float> Coefficient4C4 { get; set; } = null;
        

        [JsonProperty("coefficient5_c5")]
        public System.Nullable<float> Coefficient5C5 { get; set; } = null;
        

        [JsonProperty("minimum_value_of_x")]
        public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

        [JsonProperty("maximum_value_of_x")]
        public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

        [Description("Specify the minimum value calculated by this curve object")]
        [JsonProperty("minimum_curve_output")]
        public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

        [Description("Specify the maximum value calculated by this curve object")]
        [JsonProperty("maximum_curve_output")]
        public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

        [JsonProperty("input_unit_type_for_x")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_Sigmoid_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Sigmoid_InputUnitTypeForX)Enum.Parse(typeof(Curve_Sigmoid_InputUnitTypeForX), "Dimensionless");
        

        [JsonProperty("output_unit_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_Sigmoid_OutputUnitType OutputUnitType { get; set; } = (Curve_Sigmoid_OutputUnitType)Enum.Parse(typeof(Curve_Sigmoid_OutputUnitType), "Dimensionless");
    }
}