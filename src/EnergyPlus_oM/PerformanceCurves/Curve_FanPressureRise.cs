using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Special curve type with two independent variables. Input for the fan total pressure rise curve consists of the curve name, the four coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = C1*Qfan**2+C2*Qfan+C3*Qfan*(Psm-Po)**0.5+C4*(Psm-Po) Po assumed to be zero See InputOut Reference for curve details")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_FanPressureRise : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("coefficient1_c1")]
        public System.Nullable<float> Coefficient1C1 { get; set; } = null;
        

        [JsonProperty("coefficient2_c2")]
        public System.Nullable<float> Coefficient2C2 { get; set; } = null;
        

        [JsonProperty("coefficient3_c3")]
        public System.Nullable<float> Coefficient3C3 { get; set; } = null;
        

        [JsonProperty("coefficient4_c4")]
        public System.Nullable<float> Coefficient4C4 { get; set; } = null;
        

        [JsonProperty("minimum_value_of_qfan")]
        public System.Nullable<float> MinimumValueOfQfan { get; set; } = null;
        

        [JsonProperty("maximum_value_of_qfan")]
        public System.Nullable<float> MaximumValueOfQfan { get; set; } = null;
        

        [JsonProperty("minimum_value_of_psm")]
        public System.Nullable<float> MinimumValueOfPsm { get; set; } = null;
        

        [JsonProperty("maximum_value_of_psm")]
        public System.Nullable<float> MaximumValueOfPsm { get; set; } = null;
        

        [Description("Specify the minimum value calculated by this curve object")]
        [JsonProperty("minimum_curve_output")]
        public System.Nullable<float> MinimumCurveOutput { get; set; } = null;
        

        [Description("Specify the maximum value calculated by this curve object")]
        [JsonProperty("maximum_curve_output")]
        public System.Nullable<float> MaximumCurveOutput { get; set; } = null;
    }
}