using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for simplified entry of interzone windows (adjacent to other zones).")]
    public class Window_Interzone : BHoMObject, IEnergyPlusClass
    {
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("Name of Surface (Wall, usually) the Window is on (i.e., Base Surface) Window assu" +
                     "mes the azimuth and tilt angles of the surface it is on.")]
        [JsonProperty("building_surface_name")]
        public string BuildingSurfaceName { get; set; } = "";
        

        [Description(@"Specify a surface name in an adjacent zone for known interior windows. Specify a zone name of an adjacent zone to automatically generate the interior window in the adjacent zone. a blank field will set up a Window in an adjacent zone (same zone as adjacent to base surface)")]
        [JsonProperty("outside_boundary_condition_object")]
        public string OutsideBoundaryConditionObject { get; set; } = "";
        

        [Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
                     " truncated to integer")]
        [JsonProperty("multiplier")]
        public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Window starting coordinate is specified relative to the Base Surface origin.")]
        [JsonProperty("starting_x_coordinate")]
        public System.Nullable<float> StartingXCoordinate { get; set; } = null;
        

        [Description("How far up the wall the Window starts. (in 2-d, this would be a Y Coordinate)")]
        [JsonProperty("starting_z_coordinate")]
        public System.Nullable<float> StartingZCoordinate { get; set; } = null;
        

        [JsonProperty("length")]
        public System.Nullable<float> Length { get; set; } = null;
        

        [JsonProperty("height")]
        public System.Nullable<float> Height { get; set; } = null;
    }
}