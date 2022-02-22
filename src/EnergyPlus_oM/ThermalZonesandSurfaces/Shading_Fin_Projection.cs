using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Fins are usually shading surfaces that are perpendicular to a window or door.")]
    [JsonObject("Shading:Fin:Projection")]
    public class Shading_Fin_Projection : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("window_or_door_name")]
        public string WindowOrDoorName { get; set; } = "";
        

        [JsonProperty("left_extension_from_window_door")]
        public System.Nullable<float> LeftExtensionFromWindowDoor { get; set; } = null;
        

        [JsonProperty("left_distance_above_top_of_window")]
        public System.Nullable<float> LeftDistanceAboveTopOfWindow { get; set; } = null;
        

        [Description("N2 + N3 + height of Window/Door is height of Fin")]
        [JsonProperty("left_distance_below_bottom_of_window")]
        public System.Nullable<float> LeftDistanceBelowBottomOfWindow { get; set; } = null;
        

        [JsonProperty("left_tilt_angle_from_window_door")]
        public System.Nullable<float> LeftTiltAngleFromWindowDoor { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

        [JsonProperty("left_depth_as_fraction_of_window_door_width")]
        public System.Nullable<float> LeftDepthAsFractionOfWindowDoorWidth { get; set; } = null;
        

        [JsonProperty("right_extension_from_window_door")]
        public System.Nullable<float> RightExtensionFromWindowDoor { get; set; } = null;
        

        [JsonProperty("right_distance_above_top_of_window")]
        public System.Nullable<float> RightDistanceAboveTopOfWindow { get; set; } = null;
        

        [Description("N7 + N8 + height of Window/Door is height of Fin")]
        [JsonProperty("right_distance_below_bottom_of_window")]
        public System.Nullable<float> RightDistanceBelowBottomOfWindow { get; set; } = null;
        

        [JsonProperty("right_tilt_angle_from_window_door")]
        public System.Nullable<float> RightTiltAngleFromWindowDoor { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

        [JsonProperty("right_depth_as_fraction_of_window_door_width")]
        public System.Nullable<float> RightDepthAsFractionOfWindowDoorWidth { get; set; } = null;
    }
}