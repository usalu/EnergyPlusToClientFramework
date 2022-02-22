using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Linear curve with four independent variables. Input for the linear curve consists of a curve name, the two coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*w + C3*x + C4*y + C5*z")]
    public class Curve_QuadLinear : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("coefficient1_constant")]
        public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

        [JsonProperty("coefficient2_w")]
        public System.Nullable<float> Coefficient2W { get; set; } = null;
        

        [JsonProperty("coefficient3_x")]
        public System.Nullable<float> Coefficient3X { get; set; } = null;
        

        [JsonProperty("coefficient4_y")]
        public System.Nullable<float> Coefficient4Y { get; set; } = null;
        

        [JsonProperty("coefficient5_z")]
        public System.Nullable<float> Coefficient5Z { get; set; } = null;
        

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
        

        [JsonProperty("input_unit_type_for_w")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_QuadLinear_InputUnitTypeForW InputUnitTypeForW { get; set; } = (Curve_QuadLinear_InputUnitTypeForW)Enum.Parse(typeof(Curve_QuadLinear_InputUnitTypeForW), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_x")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_QuadLinear_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_QuadLinear_InputUnitTypeForX)Enum.Parse(typeof(Curve_QuadLinear_InputUnitTypeForX), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_y")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_QuadLinear_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_QuadLinear_InputUnitTypeForY)Enum.Parse(typeof(Curve_QuadLinear_InputUnitTypeForY), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_z")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_QuadLinear_InputUnitTypeForZ InputUnitTypeForZ { get; set; } = (Curve_QuadLinear_InputUnitTypeForZ)Enum.Parse(typeof(Curve_QuadLinear_InputUnitTypeForZ), "Dimensionless");
    }
}