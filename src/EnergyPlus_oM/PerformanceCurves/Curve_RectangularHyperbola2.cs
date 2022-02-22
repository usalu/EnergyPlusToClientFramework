using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Rectangular hyperbola type 2 curve with one independent variable. Input consists of the curve name, the three coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = ((C1*x)/(C2+x))+(C3*x)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_RectangularHyperbola2 : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("coefficient1_c1")]
        public System.Nullable<float> Coefficient1C1 { get; set; } = null;
        

        [JsonProperty("coefficient2_c2")]
        public System.Nullable<float> Coefficient2C2 { get; set; } = null;
        

        [JsonProperty("coefficient3_c3")]
        public System.Nullable<float> Coefficient3C3 { get; set; } = null;
        

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
        public Curve_RectangularHyperbola2_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_RectangularHyperbola2_InputUnitTypeForX)Enum.Parse(typeof(Curve_RectangularHyperbola2_InputUnitTypeForX), "Dimensionless");
        

        [JsonProperty("output_unit_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_RectangularHyperbola2_OutputUnitType OutputUnitType { get; set; } = (Curve_RectangularHyperbola2_OutputUnitType)Enum.Parse(typeof(Curve_RectangularHyperbola2_OutputUnitType), "Dimensionless");
    }
}