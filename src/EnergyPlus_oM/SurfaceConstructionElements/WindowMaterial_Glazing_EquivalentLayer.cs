using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Glass material properties for Windows or Glass Doors Transmittance/Reflectance in" +
                 "put method.")]
    public class WindowMaterial_Glazing_EquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Spectral is not currently supported and SpectralAverage is the default.")]
        [JsonProperty("optical_data_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Glazing_EquivalentLayer_OpticalDataType OpticalDataType { get; set; } = (WindowMaterial_Glazing_EquivalentLayer_OpticalDataType)Enum.Parse(typeof(WindowMaterial_Glazing_EquivalentLayer_OpticalDataType), "SpectralAverage");
        

        [Description("Spectral data is not currently supported. Used only when Optical Data Type = Spec" +
                     "tral")]
        [JsonProperty("window_glass_spectral_data_set_name")]
        public string WindowGlassSpectralDataSetName { get; set; } = "";
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("front_side_beam_beam_solar_transmittance")]
        public System.Nullable<float> FrontSideBeamBeamSolarTransmittance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("back_side_beam_beam_solar_transmittance")]
        public System.Nullable<float> BackSideBeamBeamSolarTransmittance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
                     "outdoor air")]
        [JsonProperty("front_side_beam_beam_solar_reflectance")]
        public System.Nullable<float> FrontSideBeamBeamSolarReflectance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
                     "one air")]
        [JsonProperty("back_side_beam_beam_solar_reflectance")]
        public System.Nullable<float> BackSideBeamBeamSolarReflectance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("front_side_beam_beam_visible_solar_transmittance")]
        public System.Nullable<float> FrontSideBeamBeamVisibleSolarTransmittance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("back_side_beam_beam_visible_solar_transmittance")]
        public System.Nullable<float> BackSideBeamBeamVisibleSolarTransmittance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
                     "outdoor air")]
        [JsonProperty("front_side_beam_beam_visible_solar_reflectance")]
        public System.Nullable<float> FrontSideBeamBeamVisibleSolarReflectance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
                     "one air")]
        [JsonProperty("back_side_beam_beam_visible_solar_reflectance")]
        public System.Nullable<float> BackSideBeamBeamVisibleSolarReflectance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("front_side_beam_diffuse_solar_transmittance")]
        public System.Nullable<float> FrontSideBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("back_side_beam_diffuse_solar_transmittance")]
        public System.Nullable<float> BackSideBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
                     "outdoor air")]
        [JsonProperty("front_side_beam_diffuse_solar_reflectance")]
        public System.Nullable<float> FrontSideBeamDiffuseSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
                     "one air")]
        [JsonProperty("back_side_beam_diffuse_solar_reflectance")]
        public System.Nullable<float> BackSideBeamDiffuseSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("front_side_beam_diffuse_visible_solar_transmittance")]
        public System.Nullable<float> FrontSideBeamDiffuseVisibleSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("back_side_beam_diffuse_visible_solar_transmittance")]
        public System.Nullable<float> BackSideBeamDiffuseVisibleSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
                     "outdoor air")]
        [JsonProperty("front_side_beam_diffuse_visible_solar_reflectance")]
        public System.Nullable<float> FrontSideBeamDiffuseVisibleSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
                     "one air")]
        [JsonProperty("back_side_beam_diffuse_visible_solar_reflectance")]
        public System.Nullable<float> BackSideBeamDiffuseVisibleSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the diffuse-diffuse solar transmittance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used.")]
        [JsonProperty("diffuse_diffuse_solar_transmittance")]
        public string DiffuseDiffuseSolarTransmittance { get; set; } = (System.String)"Autocalculate";
        

        [Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the front diffuse-diffuse solar reflectance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used. Front Side is side closest to outdoor air.")]
        [JsonProperty("front_side_diffuse_diffuse_solar_reflectance")]
        public string FrontSideDiffuseDiffuseSolarReflectance { get; set; } = (System.String)"Autocalculate";
        

        [Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the back diffuse-diffuse solar reflectance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used. Back side is side closest to indoor air.")]
        [JsonProperty("back_side_diffuse_diffuse_solar_reflectance")]
        public string BackSideDiffuseDiffuseSolarReflectance { get; set; } = (System.String)"Autocalculate";
        

        [Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
                     "urrently.")]
        [JsonProperty("diffuse_diffuse_visible_solar_transmittance")]
        public string DiffuseDiffuseVisibleSolarTransmittance { get; set; } = (System.String)"Autocalculate";
        

        [Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
                     "urrently.")]
        [JsonProperty("front_side_diffuse_diffuse_visible_solar_reflectance")]
        public string FrontSideDiffuseDiffuseVisibleSolarReflectance { get; set; } = (System.String)"Autocalculate";
        

        [Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
                     "urrently.")]
        [JsonProperty("back_side_diffuse_diffuse_visible_solar_reflectance")]
        public string BackSideDiffuseDiffuseVisibleSolarReflectance { get; set; } = (System.String)"Autocalculate";
        

        [Description("The long-wave hemispherical transmittance of the glazing. Assumed to be the same " +
                     "for both sides of the glazing.")]
        [JsonProperty("infrared_transmittance_applies_to_front_and_back_")]
        public System.Nullable<float> InfraredTransmittanceAppliesToFrontAndBack { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side long-wave hemispherical emissivity of the glazing.")]
        [JsonProperty("front_side_infrared_emissivity")]
        public System.Nullable<float> FrontSideInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

        [Description("The back side long-wave hemispherical emissivity of the glazing.")]
        [JsonProperty("back_side_infrared_emissivity")]
        public System.Nullable<float> BackSideInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

        [Description("This is the R-Value in SI for the glass. The default value is an approximation fo" +
                     "r a single layer of glass at 1/4\" inch thickness. This field is used only for mo" +
                     "vable insulation defined with this material type.")]
        [JsonProperty("thermal_resistance")]
        public System.Nullable<float> ThermalResistance { get; set; } = (System.Nullable<float>)Single.Parse("0.158", CultureInfo.InvariantCulture);
    }
}