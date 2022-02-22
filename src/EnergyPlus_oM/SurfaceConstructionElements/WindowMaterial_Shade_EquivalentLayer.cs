using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Specifies the properties of equivalent layer window shade material Shades are con" +
                 "sidered to be perfect diffusers (all transmitted and reflected radiation is hemi" +
                 "spherically-diffuse) independent of angle of incidence. Shade represents roller " +
                 "blinds.")]
    [JsonObject("WindowMaterial:Shade:EquivalentLayer")]
    public class WindowMaterial_Shade_EquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

        [Description("The beam-beam solar transmittance at normal incidence. This value is the same as " +
                     "the openness area fraction of the shade material. Assumed to be the same for fro" +
                     "nt and back sides.")]
        [JsonProperty("shade_beam_beam_solar_transmittance")]
        public System.Nullable<float> ShadeBeamBeamSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse solar transmittance at normal incidence averaged over" +
                     " the entire spectrum of solar radiation.")]
        [JsonProperty("front_side_shade_beam_diffuse_solar_transmittance")]
        public System.Nullable<float> FrontSideShadeBeamDiffuseSolarTransmittance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar transmittance at normal incidence averaged over " +
                     "the entire spectrum of solar radiation.")]
        [JsonProperty("back_side_shade_beam_diffuse_solar_transmittance")]
        public System.Nullable<float> BackSideShadeBeamDiffuseSolarTransmittance { get; set; } = null;
        

        [Description("The front side beam-diffuse solar reflectance at normal incidence averaged over t" +
                     "he entire spectrum of solar radiation.")]
        [JsonProperty("front_side_shade_beam_diffuse_solar_reflectance")]
        public System.Nullable<float> FrontSideShadeBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar reflectance at normal incidence averaged over th" +
                     "e entire spectrum of solar radiation.")]
        [JsonProperty("back_side_shade_beam_diffuse_solar_reflectance")]
        public System.Nullable<float> BackSideShadeBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The beam-beam visible transmittance at normal incidence averaged over the visible" +
                     " spectrum range of solar radiation. Assumed to be the same for front and back si" +
                     "des of the shade.")]
        [JsonProperty("shade_beam_beam_visible_transmittance_at_normal_incidence")]
        public System.Nullable<float> ShadeBeamBeamVisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

        [Description("The beam-diffuse visible transmittance at normal incidence averaged over the visi" +
                     "ble spectrum range of solar radiation. Assumed to be the same for front and back" +
                     " sides of the shade.")]
        [JsonProperty("shade_beam_diffuse_visible_transmittance_at_normal_incidence")]
        public System.Nullable<float> ShadeBeamDiffuseVisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

        [Description("The beam-diffuse visible reflectance at normal incidence averaged over the visibl" +
                     "e spectrum range of solar radiation. Assumed to be the same for front and back s" +
                     "ides of the shade.")]
        [JsonProperty("shade_beam_diffuse_visible_reflectance_at_normal_incidence")]
        public System.Nullable<float> ShadeBeamDiffuseVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

        [Description("The long-wave transmittance of the shade material at zero shade openness. Assumed" +
                     " to be the same for front and back sides of the shade.")]
        [JsonProperty("shade_material_infrared_transmittance")]
        public System.Nullable<float> ShadeMaterialInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

        [Description("The front side long-wave emissivity of the shade material at zero shade openness." +
                     " Openness fraction is used to calculate the effective emissivity value.")]
        [JsonProperty("front_side_shade_material_infrared_emissivity")]
        public System.Nullable<float> FrontSideShadeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.91", CultureInfo.InvariantCulture);
        

        [Description("The back side long-wave emissivity of the shade material at zero shade openness. " +
                     "Openness fraction is used to calculate the effective emissivity value.")]
        [JsonProperty("back_side_shade_material_infrared_emissivity")]
        public System.Nullable<float> BackSideShadeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.91", CultureInfo.InvariantCulture);
    }
}