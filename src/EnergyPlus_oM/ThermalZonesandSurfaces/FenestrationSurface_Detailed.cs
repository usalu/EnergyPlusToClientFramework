using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for detailed entry of subsurfaces (windows, doors, glass doors, tubular da" +
                 "ylighting devices).")]
    public class FenestrationSurface_Detailed : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("surface_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FenestrationSurface_Detailed_SurfaceType SurfaceType { get; set; } = (FenestrationSurface_Detailed_SurfaceType)Enum.Parse(typeof(FenestrationSurface_Detailed_SurfaceType), "Door");
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [JsonProperty("building_surface_name")]
        public string BuildingSurfaceName { get; set; } = "";
        

        [Description(@"Non-blank only if base surface field Outside Boundary Condition is Surface or OtherSideCoefficients If Base Surface's Surface, specify name of corresponding subsurface in adjacent zone or specify current subsurface name for internal partition separating like zones If OtherSideCoefficients, specify name of SurfaceProperty:OtherSideCoefficients or leave blank to inherit Base Surface's OtherSide Coefficients")]
        [JsonProperty("outside_boundary_condition_object")]
        public string OutsideBoundaryConditionObject { get; set; } = "";
        

        [Description(@"From the exterior of the surface Unused if one uses the ""reflections"" options in Solar Distribution in Building input unless a DaylightingDevice:Shelf or DaylightingDevice:Tubular object has been specified. autocalculate will automatically calculate this value from the tilt of the surface")]
        [JsonProperty("view_factor_to_ground")]
        public string ViewFactorToGround { get; set; } = (System.String)"Autocalculate";
        

        [Description(@"Enter the name of a WindowProperty:FrameAndDivider object Used only for exterior windows (rectangular) and glass doors. Unused for triangular windows. If not specified (blank), window or glass door has no frame or divider and no beam solar reflection from reveal surfaces.")]
        [JsonProperty("frame_and_divider_name")]
        public string FrameAndDividerName { get; set; } = "";
        

        [Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
                     " truncated to integer")]
        [JsonProperty("multiplier")]
        public System.Nullable<float> Multiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates are ""relative"" to the Zone Origin. If world, then building and zone origins are used for some internal calculations, but all coordinates are given in an ""absolute"" system.")]
        [JsonProperty("number_of_vertices")]
        public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("vertex_1_x_coordinate")]
        public System.Nullable<float> Vertex1XCoordinate { get; set; } = null;
        

        [JsonProperty("vertex_1_y_coordinate")]
        public System.Nullable<float> Vertex1YCoordinate { get; set; } = null;
        

        [JsonProperty("vertex_1_z_coordinate")]
        public System.Nullable<float> Vertex1ZCoordinate { get; set; } = null;
        

        [JsonProperty("vertex_2_x_coordinate")]
        public System.Nullable<float> Vertex2XCoordinate { get; set; } = null;
        

        [JsonProperty("vertex_2_y_coordinate")]
        public System.Nullable<float> Vertex2YCoordinate { get; set; } = null;
        

        [JsonProperty("vertex_2_z_coordinate")]
        public System.Nullable<float> Vertex2ZCoordinate { get; set; } = null;
        

        [JsonProperty("vertex_3_x_coordinate")]
        public System.Nullable<float> Vertex3XCoordinate { get; set; } = null;
        

        [JsonProperty("vertex_3_y_coordinate")]
        public System.Nullable<float> Vertex3YCoordinate { get; set; } = null;
        

        [JsonProperty("vertex_3_z_coordinate")]
        public System.Nullable<float> Vertex3ZCoordinate { get; set; } = null;
        

        [Description("Not used for triangles")]
        [JsonProperty("vertex_4_x_coordinate")]
        public System.Nullable<float> Vertex4XCoordinate { get; set; } = null;
        

        [Description("Not used for triangles")]
        [JsonProperty("vertex_4_y_coordinate")]
        public System.Nullable<float> Vertex4YCoordinate { get; set; } = null;
        

        [Description("Not used for triangles")]
        [JsonProperty("vertex_4_z_coordinate")]
        public System.Nullable<float> Vertex4ZCoordinate { get; set; } = null;
    }
}