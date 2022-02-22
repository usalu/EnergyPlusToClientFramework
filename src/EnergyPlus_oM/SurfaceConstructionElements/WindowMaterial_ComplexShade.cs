using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Complex window shading layer thermal properties")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_ComplexShade : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("layer_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_ComplexShade_LayerType LayerType { get; set; } = (WindowMaterial_ComplexShade_LayerType)Enum.Parse(typeof(WindowMaterial_ComplexShade_LayerType), "OtherShadingType");
        

        [JsonProperty("thickness")]
        public System.Nullable<float> Thickness { get; set; } = (System.Nullable<float>)Single.Parse("0.002", CultureInfo.InvariantCulture);
        

        [JsonProperty("conductivity")]
        public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("ir_transmittance")]
        public System.Nullable<float> IrTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("front_emissivity")]
        public System.Nullable<float> FrontEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty("back_emissivity")]
        public System.Nullable<float> BackEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty("top_opening_multiplier")]
        public System.Nullable<float> TopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("bottom_opening_multiplier")]
        public System.Nullable<float> BottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("left_side_opening_multiplier")]
        public System.Nullable<float> LeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("right_side_opening_multiplier")]
        public System.Nullable<float> RightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("front_opening_multiplier")]
        public System.Nullable<float> FrontOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

        [JsonProperty("slat_width")]
        public System.Nullable<float> SlatWidth { get; set; } = (System.Nullable<float>)Single.Parse("0.016", CultureInfo.InvariantCulture);
        

        [Description("Distance between adjacent slat faces")]
        [JsonProperty("slat_spacing")]
        public System.Nullable<float> SlatSpacing { get; set; } = (System.Nullable<float>)Single.Parse("0.012", CultureInfo.InvariantCulture);
        

        [Description("Distance between top and bottom surfaces of slat Slat is assumed to be rectangula" +
                     "r in cross section and flat")]
        [JsonProperty("slat_thickness")]
        public System.Nullable<float> SlatThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.0006", CultureInfo.InvariantCulture);
        

        [JsonProperty("slat_angle")]
        public System.Nullable<float> SlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

        [JsonProperty("slat_conductivity")]
        public System.Nullable<float> SlatConductivity { get; set; } = (System.Nullable<float>)Single.Parse("160", CultureInfo.InvariantCulture);
        

        [Description("this value represents curvature radius of the slat. if the slat is flat use zero." +
                     " if this value is not zero, then it must be > SlatWidth/2.")]
        [JsonProperty("slat_curve")]
        public System.Nullable<float> SlatCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}