using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Linear curve with five independent variables. Input for the linear curve consists of a curve name, the two coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*v + C3*w + C4*x + C5*y + C6*z")]
    [JsonObject("Curve:QuintLinear")]
    public class Curve_QuintLinear : BHoMObject
    {
        

        [JsonProperty("coefficient1_constant")]
        public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

        [JsonProperty("coefficient2_v")]
        public System.Nullable<float> Coefficient2V { get; set; } = null;
        

        [JsonProperty("coefficient3_w")]
        public System.Nullable<float> Coefficient3W { get; set; } = null;
        

        [JsonProperty("coefficient4_x")]
        public System.Nullable<float> Coefficient4X { get; set; } = null;
        

        [JsonProperty("coefficient5_y")]
        public System.Nullable<float> Coefficient5Y { get; set; } = null;
        

        [JsonProperty("coefficient6_z")]
        public System.Nullable<float> Coefficient6Z { get; set; } = null;
        

        [JsonProperty("minimum_value_of_v")]
        public System.Nullable<float> MinimumValueOfV { get; set; } = null;
        

        [JsonProperty("maximum_value_of_v")]
        public System.Nullable<float> MaximumValueOfV { get; set; } = null;
        

        [JsonProperty("minimum_value_of_w")]
        public System.Nullable<float> MinimumValueOfW { get; set; } = null;
        

        [JsonProperty("maximum_value_of_w")]
        public System.Nullable<float> MaximumValueOfW { get; set; } = null;
        

        [JsonProperty("minimum_value_of_x")]
        public System.Nullable<float> MinimumValueOfX { get; set; } = null;
        

        [JsonProperty("maximum_value_of_x")]
        public System.Nullable<float> MaximumValueOfX { get; set; } = null;
        

        [JsonProperty("minimum_value_of_y")]
        public System.Nullable<float> MinimumValueOfY { get; set; } = null;
        

        [JsonProperty("maximum_value_of_y")]
        public System.Nullable<float> MaximumValueOfY { get; set; } = null;
        

        [JsonProperty("minimum_value_of_z")]
        public System.Nullable<float> MinimumValueOfZ { get; set; } = null;
        

        [JsonProperty("maximum_value_of_z")]
        public System.Nullable<float> MaximumValueOfZ { get; set; } = null;
        

        [Description("Specify the minimum value calculated by this curve object")]
        [JsonProperty("minimum_curve_output")]
        public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

        [Description("Specify the maximum value calculated by this curve object")]
        [JsonProperty("maximum_curve_output")]
        public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
        

        [JsonProperty("input_unit_type_for_v")]
        public EmptyNoYes InputUnitTypeForV { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_w")]
        public EmptyNoYes InputUnitTypeForW { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_x")]
        public EmptyNoYes InputUnitTypeForX { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_y")]
        public EmptyNoYes InputUnitTypeForY { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_z")]
        public EmptyNoYes InputUnitTypeForZ { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
    }
}