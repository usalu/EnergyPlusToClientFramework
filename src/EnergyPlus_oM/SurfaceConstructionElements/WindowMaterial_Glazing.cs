using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Glass material properties for Windows or Glass Doors Transmittance/Reflectance in" +
                 "put method.")]
    [JsonObject("WindowMaterial:Glazing")]
    public class WindowMaterial_Glazing : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("optical_data_type")]
        public WindowMaterial_Glazing_OpticalDataType OpticalDataType { get; set; } = (WindowMaterial_Glazing_OpticalDataType)Enum.Parse(typeof(WindowMaterial_Glazing_OpticalDataType), "BSDF");
        

        [Description("Used only when Optical Data Type = Spectral")]
        [JsonProperty("window_glass_spectral_data_set_name")]
        public string WindowGlassSpectralDataSetName { get; set; } = "";
        

        [JsonProperty("thickness")]
        public System.Nullable<float> Thickness { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("solar_transmittance_at_normal_incidence")]
        public System.Nullable<float> SolarTransmittanceAtNormalIncidence { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
                     "outdoor air")]
        [JsonProperty("front_side_solar_reflectance_at_normal_incidence")]
        public System.Nullable<float> FrontSideSolarReflectanceAtNormalIncidence { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
                     "one air")]
        [JsonProperty("back_side_solar_reflectance_at_normal_incidence")]
        public System.Nullable<float> BackSideSolarReflectanceAtNormalIncidence { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("visible_transmittance_at_normal_incidence")]
        public System.Nullable<float> VisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("front_side_visible_reflectance_at_normal_incidence")]
        public System.Nullable<float> FrontSideVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty("back_side_visible_reflectance_at_normal_incidence")]
        public System.Nullable<float> BackSideVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

        [JsonProperty("infrared_transmittance_at_normal_incidence")]
        public System.Nullable<float> InfraredTransmittanceAtNormalIncidence { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("front_side_infrared_hemispherical_emissivity")]
        public System.Nullable<float> FrontSideInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty("back_side_infrared_hemispherical_emissivity")]
        public System.Nullable<float> BackSideInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty("conductivity")]
        public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("dirt_correction_factor_for_solar_and_visible_transmittance")]
        public System.Nullable<float> DirtCorrectionFactorForSolarAndVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("solar_diffusing")]
        public EmptyNoYes SolarDiffusing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("coefficient used for deflection calculations. Used only with complex fenestration" +
                     " when deflection model is set to TemperatureAndPressureInput")]
        [JsonProperty("young_s_modulus")]
        public System.Nullable<float> YoungSModulus { get; set; } = (System.Nullable<float>)Single.Parse("72000000000", CultureInfo.InvariantCulture);
        

        [Description("coefficient used for deflection calculations. Used only with complex fenestration" +
                     " when deflection model is set to TemperatureAndPressureInput")]
        [JsonProperty("poisson_s_ratio")]
        public System.Nullable<float> PoissonSRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.22", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAndAngle")]
        [JsonProperty("window_glass_spectral_and_incident_angle_transmittance_data_set_table_name")]
        public string WindowGlassSpectralAndIncidentAngleTransmittanceDataSetTableName { get; set; } = "";
        

        [Description("Used only when Optical Data Type = SpectralAndAngle")]
        [JsonProperty("window_glass_spectral_and_incident_angle_front_reflectance_data_set_table_name")]
        public string WindowGlassSpectralAndIncidentAngleFrontReflectanceDataSetTableName { get; set; } = "";
        

        [Description("Used only when Optical Data Type = SpectralAndAngle")]
        [JsonProperty("window_glass_spectral_and_incident_angle_back_reflectance_data_set_table_name")]
        public string WindowGlassSpectralAndIncidentAngleBackReflectanceDataSetTableName { get; set; } = "";
    }
}