using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Cubic curve with one independent variable. Input for a cubic curve consists of the curve name, the 4 coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x + C3*x**2 + C4*x**3")]
    [JsonObject("Curve:Cubic")]
    public class Curve_Cubic : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("coefficient1_constant")]
        public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

        [JsonProperty("coefficient2_x")]
        public System.Nullable<float> Coefficient2X { get; set; } = null;
        

        [JsonProperty("coefficient3_x_2")]
        public System.Nullable<float> Coefficient3X2 { get; set; } = null;
        

        [JsonProperty("coefficient4_x_3")]
        public System.Nullable<float> Coefficient4X3 { get; set; } = null;
        

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
        public Curve_Cubic_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Cubic_InputUnitTypeForX)Enum.Parse(typeof(Curve_Cubic_InputUnitTypeForX), "Dimensionless");
        

        [JsonProperty("output_unit_type")]
        public Curve_Cubic_OutputUnitType OutputUnitType { get; set; } = (Curve_Cubic_OutputUnitType)Enum.Parse(typeof(Curve_Cubic_OutputUnitType), "Dimensionless");
    }
}