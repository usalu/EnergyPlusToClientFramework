using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Equivalent layer window screen physical properties. Can only be located on the ex" +
                 "terior side of a window construction.")]
    [JsonObject("WindowMaterial:Screen:EquivalentLayer")]
    public class WindowMaterial_Screen_EquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"The beam-beam transmittance of the screen material at normal incidence. This input field is the same as the material openness area fraction and can be autocalculated from the wire spacing and wire and diameter. Assumed to be the same for both sides of the screen.")]
        [JsonProperty("screen_beam_beam_solar_transmittance")]
        public string ScreenBeamBeamSolarTransmittance { get; set; } = (System.String)"Autocalculate";
        

        [Description("The beam-diffuse solar transmittance of the screen material at normal incidence a" +
                     "veraged over the entire spectrum of solar radiation. Assumed to be the same for " +
                     "both sides of the screen.")]
        [JsonProperty("screen_beam_diffuse_solar_transmittance")]
        public System.Nullable<float> ScreenBeamDiffuseSolarTransmittance { get; set; } = null;
        

        [Description("The beam-diffuse solar reflectance of the screen material at normal incidence ave" +
                     "raged over the entire spectrum of solar radiation. Assumed to be the same for bo" +
                     "th sides of the screen.")]
        [JsonProperty("screen_beam_diffuse_solar_reflectance")]
        public System.Nullable<float> ScreenBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The beam-beam visible transmittance of the screen material at normal incidence av" +
                     "eraged over the visible spectrum range of solar radiation. Assumed to be the sam" +
                     "e for both sides of the screen.")]
        [JsonProperty("screen_beam_beam_visible_transmittance")]
        public System.Nullable<float> ScreenBeamBeamVisibleTransmittance { get; set; } = null;
        

        [Description("The beam-diffuse visible transmittance of the screen material at normal incidence" +
                     " averaged over the visible spectrum range of solar radiation. Assumed to be the " +
                     "same for both sides of the screen.")]
        [JsonProperty("screen_beam_diffuse_visible_transmittance")]
        public System.Nullable<float> ScreenBeamDiffuseVisibleTransmittance { get; set; } = null;
        

        [Description("Beam-diffuse visible reflectance of the screen material at normal incidence avera" +
                     "ged over the visible spectrum range of solar radiation. Assumed to be the same f" +
                     "or both sides of the screen.")]
        [JsonProperty("screen_beam_diffuse_visible_reflectance")]
        public System.Nullable<float> ScreenBeamDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("The long-wave hemispherical transmittance of the screen material. Assumed to be t" +
                     "he same for both sides of the screen.")]
        [JsonProperty("screen_infrared_transmittance")]
        public System.Nullable<float> ScreenInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.02", CultureInfo.InvariantCulture);
        

        [Description("The long-wave hemispherical emissivity of the screen material. Assumed to be the " +
                     "same for both sides of the screen.")]
        [JsonProperty("screen_infrared_emissivity")]
        public System.Nullable<float> ScreenInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.93", CultureInfo.InvariantCulture);
        

        [Description("Spacing assumed to be the same in both directions.")]
        [JsonProperty("screen_wire_spacing")]
        public System.Nullable<float> ScreenWireSpacing { get; set; } = (System.Nullable<float>)Single.Parse("0.025", CultureInfo.InvariantCulture);
        

        [Description("Diameter assumed to be the same in both directions.")]
        [JsonProperty("screen_wire_diameter")]
        public System.Nullable<float> ScreenWireDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.005", CultureInfo.InvariantCulture);
    }
}