using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Window screen physical properties. Can only be located on the exterior side of a " +
                 "window construction.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Screen : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Select the method used to account for the beam solar reflected off the material s" +
                     "urface.")]
        [JsonProperty("reflected_beam_transmittance_accounting_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod ReflectedBeamTransmittanceAccountingMethod { get; set; } = (WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod)Enum.Parse(typeof(WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod), "ModelAsDiffuse");
        

        [Description("Diffuse reflectance of the screen material over the entire solar radiation spectr" +
                     "um. Assumed to be the same for both sides of the screen.")]
        [JsonProperty("diffuse_solar_reflectance")]
        public System.Nullable<float> DiffuseSolarReflectance { get; set; } = null;
        

        [Description("Diffuse visible reflectance of the screen material averaged over the solar spectr" +
                     "um and weighted by the response of the human eye. Assumed to be the same for bot" +
                     "h sides of the screen.")]
        [JsonProperty("diffuse_visible_reflectance")]
        public System.Nullable<float> DiffuseVisibleReflectance { get; set; } = null;
        

        [Description("Long-wave emissivity of the screen material. Assumed to be the same for both side" +
                     "s of the screen.")]
        [JsonProperty("thermal_hemispherical_emissivity")]
        public System.Nullable<float> ThermalHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Thermal conductivity of the screen material. Default is for aluminum.")]
        [JsonProperty("conductivity")]
        public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("221", CultureInfo.InvariantCulture);
        

        [Description("Spacing assumed to be the same in both directions.")]
        [JsonProperty("screen_material_spacing")]
        public System.Nullable<float> ScreenMaterialSpacing { get; set; } = null;
        

        [Description("Diameter assumed to be the same in both directions.")]
        [JsonProperty("screen_material_diameter")]
        public System.Nullable<float> ScreenMaterialDiameter { get; set; } = null;
        

        [Description("Distance from the window screen to the adjacent glass surface.")]
        [JsonProperty("screen_to_glass_distance")]
        public System.Nullable<float> ScreenToGlassDistance { get; set; } = (System.Nullable<float>)Single.Parse("0.025", CultureInfo.InvariantCulture);
        

        [Description("Effective area for air flow at the top of the screen divided by the perpendicular" +
                     " area between the glass and the top of the screen.")]
        [JsonProperty("top_opening_multiplier")]
        public System.Nullable<float> TopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Effective area for air flow at the bottom of the screen divided by the perpendicu" +
                     "lar area between the glass and the bottom of the screen.")]
        [JsonProperty("bottom_opening_multiplier")]
        public System.Nullable<float> BottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Effective area for air flow at the left side of the screen divided by the perpend" +
                     "icular area between the glass and the left side of the screen.")]
        [JsonProperty("left_side_opening_multiplier")]
        public System.Nullable<float> LeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Effective area for air flow at the right side of the screen divided by the perpen" +
                     "dicular area between the glass and the right side of the screen.")]
        [JsonProperty("right_side_opening_multiplier")]
        public System.Nullable<float> RightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Select the resolution of azimuth and altitude angles for the screen transmittance" +
                     " map. A value of 0 means no transmittance map will be generated. Valid values fo" +
                     "r this field are 0, 1, 2, 3 and 5.")]
        [JsonProperty("angle_of_resolution_for_screen_transmittance_output_map")]
        public string AngleOfResolutionForScreenTransmittanceOutputMap { get; set; } = (System.String)"0";
    }
}