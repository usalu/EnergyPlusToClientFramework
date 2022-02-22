using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Specifies the type, location, and controls for window shades, window blinds, and " +
                 "switchable glazing. Referencing the surface objects for exterior windows and gla" +
                 "ss doors (ref: FenestrationSurface:Detailed, Window, and GlazedDoor).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowShadingControl : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description(@"If multiple WindowShadingControl objects are used than the order that they deploy the window shades can be set with this field. The first WindowShadingControl should be 1 and subsequent WindowShadingControl should 2 or 3 or higher. This is usually used when the Multiple Surface Control Type field is set to Group and groups of windows are being controlled in a certain order.")]
        [JsonProperty("shading_control_sequence_number")]
        public System.Nullable<float> ShadingControlSequenceNumber { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("shading_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowShadingControl_ShadingType ShadingType { get; set; } = (WindowShadingControl_ShadingType)Enum.Parse(typeof(WindowShadingControl_ShadingType), "BetweenGlassBlind");
        

        [Description(@"Required if Shading Type = SwitchableGlazing Required if Shading Type = interior or exterior shade or blind, or exterior screen, and ""Shading Device Material Name"" is not specified. If both ""Construction with Shading Name"" and ""Shading Device Material Name"" are entered, the former takes precedence.")]
        [JsonProperty("construction_with_shading_name")]
        public string ConstructionWithShadingName { get; set; } = "";
        

        [Description(@"OnIfScheduleAllows requires that Schedule Name be specified and Shading Control Is Scheduled = Yes. AlwaysOn, AlwaysOff and OnIfScheduleAllows are the only valid control types for ExteriorScreen. The following six control types are used primarily to reduce zone cooling load due to window solar gain Following entry should be used only if Shading Type = SwitchableGlazing and window is in a daylit zone The following three control types are used to reduce zone Heating load. They can be used with any Shading Type but are most appropriate for opaque interior or exterior shades with high insulating value (""opaque movable insulation"") The following two control types are used to reduce zone heating and cooling load. They can be used with any Shading Type but are most appropriate for translucent interior or exterior shades with high insulating value (""translucent movable insulation"") The following two control types are used to reduce zone Cooling load. They can be used with any Shading Type but are most appropriate for interior or exterior blinds,interior or exterior shades with low insulating value, or switchable glazing The following four control types require that both Setpoint and Setpoint2 be specified Setpoint will correspond to outdoor air temp or zone air temp (deg C) Setpoint2 will correspond to solar on window or horizontal solar (W/m2)")]
        [JsonProperty("shading_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowShadingControl_ShadingControlType ShadingControlType { get; set; } = (WindowShadingControl_ShadingControlType)Enum.Parse(typeof(WindowShadingControl_ShadingControlType), "AlwaysOff");
        

        [Description(@"Required if Shading Control Is Scheduled = Yes. If schedule value = 1, shading control is active, i.e., shading can take place only if the control test passes. If schedule value = 0, shading is off whether or not the control test passes. Schedule Name is required if Shading Control Is Scheduled = Yes. If Schedule Name is not specified, shading control is assumed to be active at all times.")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description("W/m2 for solar-based controls, W for cooling- or heating-based controls, deg C fo" +
                     "r temperature-based controls. Unused for Shading Control Type = AlwaysOn, Always" +
                     "Off, OnIfScheduleAllows, OnIfHighGlare, Glare, and DaylightIlluminance")]
        [JsonProperty("setpoint")]
        public System.Nullable<float> Setpoint { get; set; } = null;
        

        [Description("If Yes, Schedule Name is required; if No, Schedule Name is not used. Shading Cont" +
                     "rol Is Scheduled = Yes is required if Shading Control Type = OnIfScheduleAllows." +
                     "")]
        [JsonProperty("shading_control_is_scheduled")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ShadingControlIsScheduled { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description(@"If Yes and window is in a daylit zone, shading is on if zone's discomfort glare index exceeds the maximum discomfort glare index specified in the Daylighting object referenced by the zone. The glare test is OR'ed with the test specified by Shading Control Type. Glare Control Is Active = Yes is required if Shading Control Type = OnIfHighGlare.")]
        [JsonProperty("glare_control_is_active")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes GlareControlIsActive { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description(@"Enter the name of a WindowMaterial:Shade, WindowMaterial:Screen or WindowMaterial:Blind object. Required if ""Construction with Shading Name"" is not specified. Not used if Shading Control Type = SwitchableGlazing, BetweenGlassShade, or BetweenGlassBlind. If both ""Construction with Shading Name"" and ""Shading Device Material Name"" are entered, the former takes precedence.")]
        [JsonProperty("shading_device_material_name")]
        public string ShadingDeviceMaterialName { get; set; } = "";
        

        [Description("Used only if Shading Type = InteriorBlind, ExteriorBlind or BetweenGlassBlind. If" +
                     " choice is ScheduledSlatAngle then Slat Angle Schedule Name is required.")]
        [JsonProperty("type_of_slat_angle_control_for_blinds")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowShadingControl_TypeOfSlatAngleControlForBlinds TypeOfSlatAngleControlForBlinds { get; set; } = (WindowShadingControl_TypeOfSlatAngleControlForBlinds)Enum.Parse(typeof(WindowShadingControl_TypeOfSlatAngleControlForBlinds), "FixedSlatAngle");
        

        [Description("Used only if Shading Type = InteriorBlind, ExteriorBlind or BetweenGlassBlind. Re" +
                     "quired if Type of Slat Angle Control for Blinds = ScheduledSlatAngle Schedule va" +
                     "lues should be degrees (0 minimum, 180 maximum)")]
        [JsonProperty("slat_angle_schedule_name")]
        public string SlatAngleScheduleName { get; set; } = "";
        

        [Description(@"W/m2 for solar-based controls, deg C for temperature-based controls. Used only as the second setpoint for the following two-setpoint control types: OnIfHighOutdoorAirTempAndHighSolarOnWindow, OnIfHighOutdoorAirTempAndHighHorizontalSolar, OnIfHighZoneAirTempAndHighSolarOnWindow, and OnIfHighZoneAirTempAndHighHorizontalSolar")]
        [JsonProperty("setpoint_2")]
        public System.Nullable<float> Setpoint2 { get; set; } = null;
        

        [Description("Reference to the Daylighting:Controls object that provides the glare and illumina" +
                     "nce control to the zone.")]
        [JsonProperty("daylighting_control_object_name")]
        public string DaylightingControlObjectName { get; set; } = "";
        

        [Description(@"When Sequential is used the list of fenestration surfaces are controlled individually in the order specified When Group is used the entire list is controlled simultaneously and if glare control is needed the entire group of window shades are deployed together a the same time")]
        [JsonProperty("multiple_surface_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowShadingControl_MultipleSurfaceControlType MultipleSurfaceControlType { get; set; } = (WindowShadingControl_MultipleSurfaceControlType)Enum.Parse(typeof(WindowShadingControl_MultipleSurfaceControlType), "Sequential");
        

        [JsonProperty("fenestration_surfaces")]
        public string FenestrationSurfaces { get; set; } = "";
    }
}