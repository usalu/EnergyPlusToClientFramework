using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Specifies the dimensions of a window frame, dividers, and inside reveal surfaces." +
                 " Referenced by the surface objects for exterior windows and glass doors (ref: Fe" +
                 "nestrationSurface:Detailed, Window, and GlazedDoor).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowProperty_FrameAndDivider : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Width of frame in plane of window Frame width assumed the same on all sides of wi" +
                     "ndow")]
        [JsonProperty("frame_width")]
        public System.Nullable<float> FrameWidth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Amount that frame projects outward from the outside face of the glazing")]
        [JsonProperty("frame_outside_projection")]
        public System.Nullable<float> FrameOutsideProjection { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Amount that frame projects inward from the inside face of the glazing")]
        [JsonProperty("frame_inside_projection")]
        public System.Nullable<float> FrameInsideProjection { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Effective conductance of frame Excludes air films Obtained from WINDOW 5 or other" +
                     " 2-D calculation")]
        [JsonProperty("frame_conductance")]
        public System.Nullable<float> FrameConductance { get; set; } = null;
        

        [Description("Excludes air films; applies only to multipane windows Obtained from WINDOW 5 or o" +
                     "ther 2-D calculation")]
        [JsonProperty("ratio_of_frame_edge_glass_conductance_to_center_of_glass_conductance")]
        public System.Nullable<float> RatioOfFrameEdgeGlassConductanceToCenterOfGlassConductance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of frame")]
        [JsonProperty("frame_solar_absorptance")]
        public System.Nullable<float> FrameSolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of frame")]
        [JsonProperty("frame_visible_absorptance")]
        public System.Nullable<float> FrameVisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of frame")]
        [JsonProperty("frame_thermal_hemispherical_emissivity")]
        public System.Nullable<float> FrameThermalHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("divider_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowProperty_FrameAndDivider_DividerType DividerType { get; set; } = (WindowProperty_FrameAndDivider_DividerType)Enum.Parse(typeof(WindowProperty_FrameAndDivider_DividerType), "DividedLite");
        

        [Description("Width of dividers in plane of window Width assumed the same for all dividers")]
        [JsonProperty("divider_width")]
        public System.Nullable<float> DividerWidth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"Horizontal\" means parallel to local window X-axis")]
        [JsonProperty("number_of_horizontal_dividers")]
        public System.Nullable<float> NumberOfHorizontalDividers { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"Vertical\" means parallel to local window Y-axis")]
        [JsonProperty("number_of_vertical_dividers")]
        public System.Nullable<float> NumberOfVerticalDividers { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Amount that divider projects outward from the outside face of the glazing Outside" +
                     " projection assumed the same for all divider elements")]
        [JsonProperty("divider_outside_projection")]
        public System.Nullable<float> DividerOutsideProjection { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Amount that divider projects inward from the inside face of the glazing Inside pr" +
                     "ojection assumed the same for all divider elements")]
        [JsonProperty("divider_inside_projection")]
        public System.Nullable<float> DividerInsideProjection { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Effective conductance of divider Excludes air films Obtained from WINDOW 5 or oth" +
                     "er 2-D calculation")]
        [JsonProperty("divider_conductance")]
        public System.Nullable<float> DividerConductance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Excludes air films Obtained from WINDOW 5 or other 2-D calculation")]
        [JsonProperty("ratio_of_divider_edge_glass_conductance_to_center_of_glass_conductance")]
        public System.Nullable<float> RatioOfDividerEdgeGlassConductanceToCenterOfGlassConductance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of divider")]
        [JsonProperty("divider_solar_absorptance")]
        public System.Nullable<float> DividerSolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of divider")]
        [JsonProperty("divider_visible_absorptance")]
        public System.Nullable<float> DividerVisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of divider")]
        [JsonProperty("divider_thermal_hemispherical_emissivity")]
        public System.Nullable<float> DividerThermalHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("outside_reveal_solar_absorptance")]
        public System.Nullable<float> OutsideRevealSolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("inside_sill_depth")]
        public System.Nullable<float> InsideSillDepth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("inside_sill_solar_absorptance")]
        public System.Nullable<float> InsideSillSolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Distance from plane of inside surface of glazing to plane of inside surface of wall. Outside reveal depth is determined from the geometry of the window and the wall it is on; it is non-zero if the plane of the outside surface of the glazing is set back from the plane of the outside surface of the wall.")]
        [JsonProperty("inside_reveal_depth")]
        public System.Nullable<float> InsideRevealDepth { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("inside_reveal_solar_absorptance")]
        public System.Nullable<float> InsideRevealSolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}