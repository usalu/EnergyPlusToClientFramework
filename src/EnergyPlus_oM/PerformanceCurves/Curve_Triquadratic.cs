using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Quadratic curve with three independent variables. Input consists of the curve name, the twenty seven coefficients, and min and max values for each of the independent variables. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = a0 + a1*x**2 + a2*x + a3*y**2 + a4*y + a5*z**2 + a6*z + a7*x**2*y**2 + a8*x*y + a9*x*y**2 + a10*x**2*y + a11*x**2*z**2 + a12*x*z + a13*x*z**2 + a14*x**2*z + a15*y**2*z**2 + a16*y*z + a17*y*z**2 + a18*y**2*z + a19*x**2*y**2*z**2 + a20*x**2*y**2*z + a21*x**2*y*z**2 + a22*x*y**2*z**2 + a23*x**2*y*z + a24*x*y**2*z + a25*x*y*z**2 +a26*x*y*z")]
    public class Curve_Triquadratic : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("coefficient1_constant")]
        public System.Nullable<float> Coefficient1Constant { get; set; } = null;
        

        [JsonProperty("coefficient2_x_2")]
        public System.Nullable<float> Coefficient2X2 { get; set; } = null;
        

        [JsonProperty("coefficient3_x")]
        public System.Nullable<float> Coefficient3X { get; set; } = null;
        

        [JsonProperty("coefficient4_y_2")]
        public System.Nullable<float> Coefficient4Y2 { get; set; } = null;
        

        [JsonProperty("coefficient5_y")]
        public System.Nullable<float> Coefficient5Y { get; set; } = null;
        

        [JsonProperty("coefficient6_z_2")]
        public System.Nullable<float> Coefficient6Z2 { get; set; } = null;
        

        [JsonProperty("coefficient7_z")]
        public System.Nullable<float> Coefficient7Z { get; set; } = null;
        

        [JsonProperty("coefficient8_x_2_y_2")]
        public System.Nullable<float> Coefficient8X2Y2 { get; set; } = null;
        

        [JsonProperty("coefficient9_x_y")]
        public System.Nullable<float> Coefficient9XY { get; set; } = null;
        

        [JsonProperty("coefficient10_x_y_2")]
        public System.Nullable<float> Coefficient10XY2 { get; set; } = null;
        

        [JsonProperty("coefficient11_x_2_y")]
        public System.Nullable<float> Coefficient11X2Y { get; set; } = null;
        

        [JsonProperty("coefficient12_x_2_z_2")]
        public System.Nullable<float> Coefficient12X2Z2 { get; set; } = null;
        

        [JsonProperty("coefficient13_x_z")]
        public System.Nullable<float> Coefficient13XZ { get; set; } = null;
        

        [JsonProperty("coefficient14_x_z_2")]
        public System.Nullable<float> Coefficient14XZ2 { get; set; } = null;
        

        [JsonProperty("coefficient15_x_2_z")]
        public System.Nullable<float> Coefficient15X2Z { get; set; } = null;
        

        [JsonProperty("coefficient16_y_2_z_2")]
        public System.Nullable<float> Coefficient16Y2Z2 { get; set; } = null;
        

        [JsonProperty("coefficient17_y_z")]
        public System.Nullable<float> Coefficient17YZ { get; set; } = null;
        

        [JsonProperty("coefficient18_y_z_2")]
        public System.Nullable<float> Coefficient18YZ2 { get; set; } = null;
        

        [JsonProperty("coefficient19_y_2_z")]
        public System.Nullable<float> Coefficient19Y2Z { get; set; } = null;
        

        [JsonProperty("coefficient20_x_2_y_2_z_2")]
        public System.Nullable<float> Coefficient20X2Y2Z2 { get; set; } = null;
        

        [JsonProperty("coefficient21_x_2_y_2_z")]
        public System.Nullable<float> Coefficient21X2Y2Z { get; set; } = null;
        

        [JsonProperty("coefficient22_x_2_y_z_2")]
        public System.Nullable<float> Coefficient22X2YZ2 { get; set; } = null;
        

        [JsonProperty("coefficient23_x_y_2_z_2")]
        public System.Nullable<float> Coefficient23XY2Z2 { get; set; } = null;
        

        [JsonProperty("coefficient24_x_2_y_z")]
        public System.Nullable<float> Coefficient24X2YZ { get; set; } = null;
        

        [JsonProperty("coefficient25_x_y_2_z")]
        public System.Nullable<float> Coefficient25XY2Z { get; set; } = null;
        

        [JsonProperty("coefficient26_x_y_z_2")]
        public System.Nullable<float> Coefficient26XYZ2 { get; set; } = null;
        

        [JsonProperty("coefficient27_x_y_z")]
        public System.Nullable<float> Coefficient27XYZ { get; set; } = null;
        

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
        

        [JsonProperty("input_unit_type_for_x")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_Triquadratic_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Triquadratic_InputUnitTypeForX)Enum.Parse(typeof(Curve_Triquadratic_InputUnitTypeForX), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_y")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_Triquadratic_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_Triquadratic_InputUnitTypeForY)Enum.Parse(typeof(Curve_Triquadratic_InputUnitTypeForY), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_z")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_Triquadratic_InputUnitTypeForZ InputUnitTypeForZ { get; set; } = (Curve_Triquadratic_InputUnitTypeForZ)Enum.Parse(typeof(Curve_Triquadratic_InputUnitTypeForZ), "Dimensionless");
        

        [JsonProperty("output_unit_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_Triquadratic_OutputUnitType OutputUnitType { get; set; } = (Curve_Triquadratic_OutputUnitType)Enum.Parse(typeof(Curve_Triquadratic_OutputUnitType), "Dimensionless");
    }
}