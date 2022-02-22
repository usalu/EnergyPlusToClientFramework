using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Exponent curve with one independent variable. Input for a exponent curve consists of the curve name, the 3 coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x**C3 The independent variable x is raised to the C3 power, multiplied by C2, and C1 is added to the result.")]
    public class Curve_Exponent : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("coefficient1_constant")]
        public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

        [JsonProperty("coefficient2_constant")]
        public System.Nullable<float> Coefficient2Constant { get; set; } = null;
        

        [JsonProperty("coefficient3_constant")]
        public System.Nullable<float> Coefficient3Constant { get; set; } = null;
        

        [Description("Specify the minimum value of the independent variable x allowed")]
        [JsonProperty("minimum_value_of_x")]
        public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

        [Description("Specify the maximum value of the independent variable x allowed")]
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
        public Curve_Exponent_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Exponent_InputUnitTypeForX)Enum.Parse(typeof(Curve_Exponent_InputUnitTypeForX), "Dimensionless");
        

        [JsonProperty("output_unit_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_Exponent_OutputUnitType OutputUnitType { get; set; } = (Curve_Exponent_OutputUnitType)Enum.Parse(typeof(Curve_Exponent_OutputUnitType), "Dimensionless");
    }
}