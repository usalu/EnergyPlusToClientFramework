using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Cubic curve with two independent variables. Input consists of the curve name, the ten coefficients, and the minimum and maximum values for each of the independent variables. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x + C3*x**2 + C4*y + C5*y**2 + C6*x*y + C7*x**3 + C8*y**3 + C9*x**2*y + C10*x*y**2")]
    [JsonObject("Curve:Bicubic")]
    public class Curve_Bicubic : BHoMObject
    {
        

        [JsonProperty("coefficient1_constant")]
        public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

        [JsonProperty("coefficient2_x")]
        public System.Nullable<float> Coefficient2X { get; set; } = null;
        

        [JsonProperty("coefficient3_x_2")]
        public System.Nullable<float> Coefficient3X2 { get; set; } = null;
        

        [JsonProperty("coefficient4_y")]
        public System.Nullable<float> Coefficient4Y { get; set; } = null;
        

        [JsonProperty("coefficient5_y_2")]
        public System.Nullable<float> Coefficient5Y2 { get; set; } = null;
        

        [JsonProperty("coefficient6_x_y")]
        public System.Nullable<float> Coefficient6XY { get; set; } = null;
        

        [JsonProperty("coefficient7_x_3")]
        public System.Nullable<float> Coefficient7X3 { get; set; } = null;
        

        [JsonProperty("coefficient8_y_3")]
        public System.Nullable<float> Coefficient8Y3 { get; set; } = null;
        

        [JsonProperty("coefficient9_x_2_y")]
        public System.Nullable<float> Coefficient9X2Y { get; set; } = null;
        

        [JsonProperty("coefficient10_x_y_2")]
        public System.Nullable<float> Coefficient10XY2 { get; set; } = null;
        

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
        public EmptyNoYes InputUnitTypeForX { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_y")]
        public EmptyNoYes InputUnitTypeForY { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
        

        [JsonProperty("output_unit_type")]
        public EmptyNoYes OutputUnitType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
    }
}