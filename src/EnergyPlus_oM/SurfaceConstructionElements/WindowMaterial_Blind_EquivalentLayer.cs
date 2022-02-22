using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Window equivalent layer blind slat optical and thermal properties. The model assu" +
                 "mes that slats are thin and flat, applies correction empirical correlation to ac" +
                 "count for curvature effect. Slats are assumed to transmit and reflect diffusely." +
                 "")]
    [JsonObject("WindowMaterial:Blind:EquivalentLayer")]
    public class WindowMaterial_Blind_EquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("slat_orientation")]
        public WindowMaterial_Blind_EquivalentLayer_SlatOrientation SlatOrientation { get; set; } = (WindowMaterial_Blind_EquivalentLayer_SlatOrientation)Enum.Parse(typeof(WindowMaterial_Blind_EquivalentLayer_SlatOrientation), "Horizontal");
        

        [JsonProperty("slat_width")]
        public System.Nullable<float> SlatWidth { get; set; } = null;
        

        [Description("Distance between adjacent slat faces")]
        [JsonProperty("slat_separation")]
        public System.Nullable<float> SlatSeparation { get; set; } = null;
        

        [Description("Perpendicular length between the cord and the curve. Slat is assumed to be rectan" +
                     "gular in cross section and flat. Crown=0.0625x\"Slat width\"")]
        [JsonProperty("slat_crown")]
        public System.Nullable<float> SlatCrown { get; set; } = (System.Nullable<float>)Single.Parse("0.0015", CultureInfo.InvariantCulture);
        

        [Description("Slat angle is +ve if the tip of the slat front face is tilted upward, else the sl" +
                     "at angle is -ve if the tip of the slat front face is tilted downward. The slat a" +
                     "ngle varies between -90 to +90. The default value is 45 degrees.")]
        [JsonProperty("slat_angle")]
        public System.Nullable<float> SlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("45", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse solar transmittance of the slat at normal incidence a" +
                     "veraged over the entire spectrum of solar radiation.")]
        [JsonProperty("front_side_slat_beam_diffuse_solar_transmittance")]
        public System.Nullable<float> FrontSideSlatBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The back side beam-diffuse solar transmittance of the slat at normal incidence av" +
                     "eraged over the entire spectrum of solar radiation.")]
        [JsonProperty("back_side_slat_beam_diffuse_solar_transmittance")]
        public System.Nullable<float> BackSideSlatBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse solar reflectance of the slat at normal incidence ave" +
                     "raged over the entire spectrum of solar radiation.")]
        [JsonProperty("front_side_slat_beam_diffuse_solar_reflectance")]
        public System.Nullable<float> FrontSideSlatBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar reflectance of the slat at normal incidence aver" +
                     "aged over the entire spectrum of solar radiation.")]
        [JsonProperty("back_side_slat_beam_diffuse_solar_reflectance")]
        public System.Nullable<float> BackSideSlatBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The front side beam-diffuse visible transmittance of the slat at normal incidence" +
                     " averaged over the visible spectrum range of solar radiation.")]
        [JsonProperty("front_side_slat_beam_diffuse_visible_transmittance")]
        public System.Nullable<float> FrontSideSlatBeamDiffuseVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The back side beam-diffuse visible transmittance of the slat at normal incidence " +
                     "averaged over the visible spectrum range of solar radiation.")]
        [JsonProperty("back_side_slat_beam_diffuse_visible_transmittance")]
        public System.Nullable<float> BackSideSlatBeamDiffuseVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse visible reflectance of the slat at normal incidence a" +
                     "veraged over the visible spectrum range of solar radiation.")]
        [JsonProperty("front_side_slat_beam_diffuse_visible_reflectance")]
        public System.Nullable<float> FrontSideSlatBeamDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse visible reflectance of the slat at normal incidence av" +
                     "eraged over the visible spectrum range of solar radiation.")]
        [JsonProperty("back_side_slat_beam_diffuse_visible_reflectance")]
        public System.Nullable<float> BackSideSlatBeamDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("The beam-diffuse solar transmittance of the slat averaged over the entire solar s" +
                     "pectrum of solar radiation.")]
        [JsonProperty("slat_diffuse_diffuse_solar_transmittance")]
        public System.Nullable<float> SlatDiffuseDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse solar reflectance of the slat averaged over the entir" +
                     "e solar spectrum of solar radiation.")]
        [JsonProperty("front_side_slat_diffuse_diffuse_solar_reflectance")]
        public System.Nullable<float> FrontSideSlatDiffuseDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar reflectance of the slat averaged over the entire" +
                     " solar spectrum of solar radiation.")]
        [JsonProperty("back_side_slat_diffuse_diffuse_solar_reflectance")]
        public System.Nullable<float> BackSideSlatDiffuseDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The beam-diffuse visible transmittance of the slat averaged over the visible spec" +
                     "trum range of solar radiation.")]
        [JsonProperty("slat_diffuse_diffuse_visible_transmittance")]
        public System.Nullable<float> SlatDiffuseDiffuseVisibleTransmittance { get; set; } = null;
        

        [Description("The front side beam-diffuse visible reflectance of the slat averaged over the vis" +
                     "ible spectrum range of solar radiation.")]
        [JsonProperty("front_side_slat_diffuse_diffuse_visible_reflectance")]
        public System.Nullable<float> FrontSideSlatDiffuseDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse visible reflectance of the slat averaged over the visi" +
                     "ble spectrum range of solar radiation.")]
        [JsonProperty("back_side_slat_diffuse_diffuse_visible_reflectance")]
        public System.Nullable<float> BackSideSlatDiffuseDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("Long-wave hemispherical transmittance of the slat material. Assumed to be the sam" +
                     "e for both sides of the slat.")]
        [JsonProperty("slat_infrared_transmittance")]
        public System.Nullable<float> SlatInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Front side long-wave hemispherical emissivity of the slat material.")]
        [JsonProperty("front_side_slat_infrared_emissivity")]
        public System.Nullable<float> FrontSideSlatInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Back side long-wave hemispherical emissivity of the slat material.")]
        [JsonProperty("back_side_slat_infrared_emissivity")]
        public System.Nullable<float> BackSideSlatInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description(@"Used only if slat angle control is desired to either maximize solar gain (MaximizeSolar), maximize visibility while eliminating beam solar radiation (BlockBeamSolar), or fixed slate angle (FixedSlatAngle). If FixedSlatAngle is selected, the slat angle entered above is used.")]
        [JsonProperty("slat_angle_control")]
        public WindowMaterial_Blind_EquivalentLayer_SlatAngleControl SlatAngleControl { get; set; } = (WindowMaterial_Blind_EquivalentLayer_SlatAngleControl)Enum.Parse(typeof(WindowMaterial_Blind_EquivalentLayer_SlatAngleControl), "FixedSlatAngle");
    }
}