using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for simplified entry of glass Doors.")]
    public class GlazedDoor : BHoMObject, IEnergyPlusClass
    {
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("Name of Surface (Wall, usually) the Door is on (i.e., Base Surface) Door assumes " +
                     "the azimuth and tilt angles of the surface it is on.")]
        [JsonProperty("building_surface_name")]
        public string BuildingSurfaceName { get; set; } = "";
        

        [Description(@"Enter the name of a WindowProperty:FrameAndDivider object Used only for exterior windows (rectangular) and glass doors. Unused for triangular windows. If not specified (blank), window or glass door has no frame or divider and no beam solar reflection from reveal surfaces.")]
        [JsonProperty("frame_and_divider_name")]
        public string FrameAndDividerName { get; set; } = "";
        

        [Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
                     " truncated to integer")]
        [JsonProperty("multiplier")]
        public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Door starting coordinate is specified relative to the Base Surface origin.")]
        [JsonProperty("starting_x_coordinate")]
        public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

        [Description("How far up the wall the Door starts. (in 2-d, this would be a Y Coordinate)")]
        [JsonProperty("starting_z_coordinate")]
        public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

        [JsonProperty("length")]
        public System.Nullable<float> Length { get; set; } = null;
        

        [JsonProperty("height")]
        public System.Nullable<float> Height { get; set; } = null;
    }
}