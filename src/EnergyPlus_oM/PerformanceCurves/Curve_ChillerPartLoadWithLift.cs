using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"This chiller part-load performance curve has three independent variables. Input consists of the curve name, the twelve coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x + C3*x**2 + C4*y + C5*y**2 + C6*x*y + C7*x**3 + C8*y**3 + C9*x**2*y + C10*x*y**2 + C11*x**2*y**2 + C12*z*y**3 x = dT* = normalized fractional Lift = dT / dTref y = PLR = part load ratio (cooling load/steady state capacity) z = Tdev* = normalized Tdev = Tdev / dTref Where: dT = Lift = Leaving Condenser Water Temperature - Leaving Chilled Water Temperature dTref = dT at the reference condition Tdev = Leaving Chilled Water Temperature - Reference Chilled Water Temperature")]
    [JsonObject("Curve:ChillerPartLoadWithLift")]
    public class Curve_ChillerPartLoadWithLift : BHoMObject
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
        

        [JsonProperty("coefficient6_c6")]
        public System.Nullable<float> Coefficient6C6 { get; set; } = null;
        

        [JsonProperty("coefficient7_c7")]
        public System.Nullable<float> Coefficient7C7 { get; set; } = null;
        

        [JsonProperty("coefficient8_c8")]
        public System.Nullable<float> Coefficient8C8 { get; set; } = null;
        

        [JsonProperty("coefficient9_c9")]
        public System.Nullable<float> Coefficient9C9 { get; set; } = null;
        

        [JsonProperty("coefficient10_c10")]
        public System.Nullable<float> Coefficient10C10 { get; set; } = null;
        

        [JsonProperty("coefficient11_c11")]
        public System.Nullable<float> Coefficient11C11 { get; set; } = null;
        

        [JsonProperty("coefficient12_c12")]
        public System.Nullable<float> Coefficient12C12 { get; set; } = null;
        

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
        public EmptyNoYes InputUnitTypeForX { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_y")]
        public EmptyNoYes InputUnitTypeForY { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
        

        [JsonProperty("input_unit_type_for_z")]
        public EmptyNoYes InputUnitTypeForZ { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
        

        [JsonProperty("output_unit_type")]
        public EmptyNoYes OutputUnitType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Dimensionless");
    }
}