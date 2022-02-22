using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Specifies the properties of equivalent layer drape fabric materials. Shades are considered to be perfect diffusers (all transmitted and reflected radiation is hemispherically-diffuse) independent of angle of incidence. unpleated drape fabric is treated as thin and flat layer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Drape_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("The beam-beam solar transmittance at normal incidence. This value is the same as " +
                     "the openness area fraction of the drape fabric. Assumed to be same for front and" +
                     " back sides.")]
        [JsonProperty("drape_beam_beam_solar_transmittance_at_normal_incidence")]
        public System.Nullable<float> DrapeBeamBeamSolarTransmittanceAtNormalIncidence { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse solar transmittance at normal incidence averaged over" +
                     " the entire spectrum of solar radiation. Assumed to be the same for front and ba" +
                     "ck sides.")]
        [JsonProperty("front_side_drape_beam_diffuse_solar_transmittance")]
        public System.Nullable<float> FrontSideDrapeBeamDiffuseSolarTransmittance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar transmittance at normal incidence averaged over " +
                     "the entire spectrum of solar radiation. Assumed to be the same for front and bac" +
                     "k sides.")]
        [JsonProperty("back_side_drape_beam_diffuse_solar_transmittance")]
        public System.Nullable<float> BackSideDrapeBeamDiffuseSolarTransmittance { get; set; } = null;
        

        [Description("The front side beam-diffuse solar reflectance at normal incidence averaged over t" +
                     "he entire spectrum of solar radiation.")]
        [JsonProperty("front_side_drape_beam_diffuse_solar_reflectance")]
        public System.Nullable<float> FrontSideDrapeBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar reflectance at normal incidence averaged over th" +
                     "e entire spectrum of solar radiation.")]
        [JsonProperty("back_side_drape_beam_diffuse_solar_reflectance")]
        public System.Nullable<float> BackSideDrapeBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The beam-beam visible transmittance at normal incidence averaged over the visible" +
                     " spectrum of solar radiation. Assumed same for front and back sides.")]
        [JsonProperty("drape_beam_beam_visible_transmittance")]
        public System.Nullable<float> DrapeBeamBeamVisibleTransmittance { get; set; } = null;
        

        [Description("The beam-diffuse visible transmittance at normal incidence averaged over the visi" +
                     "ble spectrum range of solar radiation. Assumed to be the same for front and back" +
                     " sides.")]
        [JsonProperty("drape_beam_diffuse_visible_transmittance")]
        public System.Nullable<float> DrapeBeamDiffuseVisibleTransmittance { get; set; } = null;
        

        [Description("The beam-diffuse visible reflectance at normal incidence average over the visible" +
                     " spectrum range of solar radiation. Assumed to be the same for front and back si" +
                     "des.")]
        [JsonProperty("drape_beam_diffuse_visible_reflectance")]
        public System.Nullable<float> DrapeBeamDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("Long-wave transmittance of the drape fabric at zero openness fraction. Assumed sa" +
                     "me for front and back sides.")]
        [JsonProperty("drape_material_infrared_transmittance")]
        public System.Nullable<float> DrapeMaterialInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

        [Description("Front side long-wave emissivity of the drape fabric at zero shade openness. Openn" +
                     "ess fraction specified above is used to calculate the effective emissivity value" +
                     ".")]
        [JsonProperty("front_side_drape_material_infrared_emissivity")]
        public System.Nullable<float> FrontSideDrapeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.87", CultureInfo.InvariantCulture);
        

        [Description("Back side long-wave emissivity of the drape fabric at zero shade openness. Openne" +
                     "ss fraction specified above is used to calculate the effective emissivity value." +
                     "")]
        [JsonProperty("back_side_drape_material_infrared_emissivity")]
        public System.Nullable<float> BackSideDrapeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.87", CultureInfo.InvariantCulture);
        

        [Description("Width of the pleated section of the draped fabric. If the drape fabric is unpleat" +
                     "ed or is flat, then the pleated section width is set to zero.")]
        [JsonProperty("width_of_pleated_fabric")]
        public System.Nullable<float> WidthOfPleatedFabric { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Length of the pleated section of the draped fabric. If the drape fabric is unplea" +
                     "ted or is flat, then the pleated section length is set to zero.")]
        [JsonProperty("length_of_pleated_fabric")]
        public System.Nullable<float> LengthOfPleatedFabric { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}