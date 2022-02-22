using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Window blind thermal properties")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Blind : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("slat_orientation")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Blind_SlatOrientation SlatOrientation { get; set; } = (WindowMaterial_Blind_SlatOrientation)Enum.Parse(typeof(WindowMaterial_Blind_SlatOrientation), "Horizontal");
        

        [JsonProperty("slat_width")]
        public System.Nullable<float> SlatWidth { get; set; } = null;
        

        [Description("Distance between adjacent slat faces")]
        [JsonProperty("slat_separation")]
        public System.Nullable<float> SlatSeparation { get; set; } = null;
        

        [Description("Distance between top and bottom surfaces of slat Slat is assumed to be rectangula" +
                     "r in cross section and flat")]
        [JsonProperty("slat_thickness")]
        public System.Nullable<float> SlatThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.00025", CultureInfo.InvariantCulture);
        

        [Description(@"If WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = FixedSlatAngle, then this is the fixed value of the slat angle; If WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = BlockBeamSolar, then this is the slat angle when slat angle control is not in effect (e.g., when there is no beam solar on the blind); Not used if WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = ScheduledSlatAngle.")]
        [JsonProperty("slat_angle")]
        public System.Nullable<float> SlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("45", CultureInfo.InvariantCulture);
        

        [Description("default is for aluminum")]
        [JsonProperty("slat_conductivity")]
        public System.Nullable<float> SlatConductivity { get; set; } = (System.Nullable<float>)Single.Parse("221", CultureInfo.InvariantCulture);
        

        [JsonProperty("slat_beam_solar_transmittance")]
        public System.Nullable<float> SlatBeamSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("front_side_slat_beam_solar_reflectance")]
        public System.Nullable<float> FrontSideSlatBeamSolarReflectance { get; set; } = null;
        

        [JsonProperty("back_side_slat_beam_solar_reflectance")]
        public System.Nullable<float> BackSideSlatBeamSolarReflectance { get; set; } = null;
        

        [Description("Must equal \"Slat beam solar transmittance\"")]
        [JsonProperty("slat_diffuse_solar_transmittance")]
        public System.Nullable<float> SlatDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Must equal \"Front Side Slat Beam Solar Reflectance\"")]
        [JsonProperty("front_side_slat_diffuse_solar_reflectance")]
        public System.Nullable<float> FrontSideSlatDiffuseSolarReflectance { get; set; } = null;
        

        [Description("Must equal \"Back Side Slat Beam Solar Reflectance\"")]
        [JsonProperty("back_side_slat_diffuse_solar_reflectance")]
        public System.Nullable<float> BackSideSlatDiffuseSolarReflectance { get; set; } = null;
        

        [Description("Required for detailed daylighting calculation")]
        [JsonProperty("slat_beam_visible_transmittance")]
        public System.Nullable<float> SlatBeamVisibleTransmittance { get; set; } = null;
        

        [Description("Required for detailed daylighting calculation")]
        [JsonProperty("front_side_slat_beam_visible_reflectance")]
        public System.Nullable<float> FrontSideSlatBeamVisibleReflectance { get; set; } = null;
        

        [Description("Required for detailed daylighting calculation")]
        [JsonProperty("back_side_slat_beam_visible_reflectance")]
        public System.Nullable<float> BackSideSlatBeamVisibleReflectance { get; set; } = null;
        

        [Description("Used only for detailed daylighting calculation Must equal \"Slat Beam Visible Tran" +
                     "smittance\"")]
        [JsonProperty("slat_diffuse_visible_transmittance")]
        public System.Nullable<float> SlatDiffuseVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Required for detailed daylighting calculation Must equal \"Front Side Slat Beam Vi" +
                     "sible Reflectance\"")]
        [JsonProperty("front_side_slat_diffuse_visible_reflectance")]
        public System.Nullable<float> FrontSideSlatDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("Required for detailed daylighting calculation Must equal \"Back Side Slat Beam Vis" +
                     "ible Reflectance\"")]
        [JsonProperty("back_side_slat_diffuse_visible_reflectance")]
        public System.Nullable<float> BackSideSlatDiffuseVisibleReflectance { get; set; } = null;
        

        [JsonProperty("slat_infrared_hemispherical_transmittance")]
        public System.Nullable<float> SlatInfraredHemisphericalTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("front_side_slat_infrared_hemispherical_emissivity")]
        public System.Nullable<float> FrontSideSlatInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("back_side_slat_infrared_hemispherical_emissivity")]
        public System.Nullable<float> BackSideSlatInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("blind_to_glass_distance")]
        public System.Nullable<float> BlindToGlassDistance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

        [JsonProperty("blind_top_opening_multiplier")]
        public System.Nullable<float> BlindTopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("blind_bottom_opening_multiplier")]
        public System.Nullable<float> BlindBottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("blind_left_side_opening_multiplier")]
        public System.Nullable<float> BlindLeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("blind_right_side_opening_multiplier")]
        public System.Nullable<float> BlindRightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Used only if WindowShadingControl referencing the window that incorporates this b" +
                     "lind varies the slat angle (i.e., WindowShadingControl with Type of Slat Angle C" +
                     "ontrol for Blinds = ScheduledSlatAngle or BlockBeamSolar)")]
        [JsonProperty("minimum_slat_angle")]
        public System.Nullable<float> MinimumSlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only if WindowShadingControl referencing the window that incorporates this b" +
                     "lind varies the slat angle (i.e., WindowShadingControl with Type of Slat Angle C" +
                     "ontrol for Blinds = ScheduledSlatAngle or BlockBeamSolar)")]
        [JsonProperty("maximum_slat_angle")]
        public System.Nullable<float> MaximumSlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("180", CultureInfo.InvariantCulture);
    }
}