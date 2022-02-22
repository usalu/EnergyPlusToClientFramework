using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Cubic-linear curve with two independent variables. Input consists of the curve name, the six coefficients, and min and max values for each of the independent variables. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = (C1 + C2*x + C3*x**2 + C4*x**3) + (C5 + C6*x)*y")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_CubicLinear : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("coefficient1_constant")]
        public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

        [JsonProperty("coefficient2_x")]
        public System.Nullable<float> Coefficient2X { get; set; } = null;
        

        [JsonProperty("coefficient3_x_2")]
        public System.Nullable<float> Coefficient3X2 { get; set; } = null;
        

        [JsonProperty("coefficient4_x_3")]
        public System.Nullable<float> Coefficient4X3 { get; set; } = null;
        

        [JsonProperty("coefficient5_y")]
        public System.Nullable<float> Coefficient5Y { get; set; } = null;
        

        [JsonProperty("coefficient6_x_y")]
        public System.Nullable<float> Coefficient6XY { get; set; } = null;
        

        [JsonProperty("minimum_value_of_x")]
        public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

        [JsonProperty("maximum_value_of_x")]
        public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

        [JsonProperty("minimum_value_of_y")]
        public System.Nullable<float> MinimumValueOfY { get; set; } = null;
        

        [JsonProperty("maximum_value_of_y")]
        public System.Nullable<float> MaximumValueOfY { get; set; } = null;
        

        [Description("Specify the minimum value calculated by this curve object")]
        [JsonProperty("minimum_curve_output")]
        public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

        [Description("Specify the maximum value calculated by this curve object")]
        [JsonProperty("maximum_curve_output")]
        public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

        [JsonProperty("input_unit_type_for_x")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_CubicLinear_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_CubicLinear_InputUnitTypeForX)Enum.Parse(typeof(Curve_CubicLinear_InputUnitTypeForX), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_y")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_CubicLinear_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_CubicLinear_InputUnitTypeForY)Enum.Parse(typeof(Curve_CubicLinear_InputUnitTypeForY), "Dimensionless");
        

        [JsonProperty("output_unit_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_CubicLinear_OutputUnitType OutputUnitType { get; set; } = (Curve_CubicLinear_OutputUnitType)Enum.Parse(typeof(Curve_CubicLinear_OutputUnitType), "Dimensionless");
    }
}