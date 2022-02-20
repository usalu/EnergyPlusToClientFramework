using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Applies only to exterior windows in daylighting-controlled zones or in zones that" +
                 " share an interior window with a daylighting-controlled  zone. Generally used wi" +
                 "th skylights.")]
    [JsonObject("DaylightingDevice:LightWell")]
    public class DaylightingDevice_LightWell : BHoMObject
    {
        

        [JsonProperty("exterior_window_name")]
        public string ExteriorWindowName { get; set; } = "";
        

        [Description("Distance from Bottom of Window to Bottom of Well")]
        [JsonProperty("height_of_well")]
        public System.Nullable<float> HeightOfWell { get; set; } = null;
        

        [JsonProperty("perimeter_of_bottom_of_well")]
        public System.Nullable<float> PerimeterOfBottomOfWell { get; set; } = null;
        

        [JsonProperty("area_of_bottom_of_well")]
        public System.Nullable<float> AreaOfBottomOfWell { get; set; } = null;
        

        [JsonProperty("visible_reflectance_of_well_walls")]
        public System.Nullable<float> VisibleReflectanceOfWellWalls { get; set; } = null;
    }
}