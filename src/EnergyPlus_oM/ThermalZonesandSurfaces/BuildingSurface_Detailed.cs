using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for detailed entry of building heat transfer surfaces. Does not include su" +
                 "bsurfaces such as windows or doors.")]
    public class BuildingSurface_Detailed : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("surface_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BuildingSurface_Detailed_SurfaceType SurfaceType { get; set; } = (BuildingSurface_Detailed_SurfaceType)Enum.Parse(typeof(BuildingSurface_Detailed_SurfaceType), "Ceiling");
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("Zone the surface is a part of")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("outside_boundary_condition")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BuildingSurface_Detailed_OutsideBoundaryCondition OutsideBoundaryCondition { get; set; } = (BuildingSurface_Detailed_OutsideBoundaryCondition)Enum.Parse(typeof(BuildingSurface_Detailed_OutsideBoundaryCondition), "Adiabatic");
        

        [Description(@"Non-blank only if the field Outside Boundary Condition is Surface, Zone, OtherSideCoefficients or OtherSideConditionsModel If Surface, specify name of corresponding surface in adjacent zone or specify current surface name for internal partition separating like zones If Zone, specify the name of the corresponding zone and the program will generate the corresponding interzone surface If Foundation, specify the name of the corresponding Foundation object and the program will calculate the heat transfer appropriately If OtherSideCoefficients, specify name of SurfaceProperty:OtherSideCoefficients If OtherSideConditionsModel, specify name of SurfaceProperty:OtherSideConditionsModel")]
        [JsonProperty("outside_boundary_condition_object")]
        public string OutsideBoundaryConditionObject { get; set; } = "";
        

        [JsonProperty("sun_exposure")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BuildingSurface_Detailed_SunExposure SunExposure { get; set; } = (BuildingSurface_Detailed_SunExposure)Enum.Parse(typeof(BuildingSurface_Detailed_SunExposure), "SunExposed");
        

        [JsonProperty("wind_exposure")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BuildingSurface_Detailed_WindExposure WindExposure { get; set; } = (BuildingSurface_Detailed_WindExposure)Enum.Parse(typeof(BuildingSurface_Detailed_WindExposure), "WindExposed");
        

        [Description(@"From the exterior of the surface Unused if one uses the ""reflections"" options in Solar Distribution in Building input unless a DaylightingDevice:Shelf or DaylightingDevice:Tubular object has been specified. autocalculate will automatically calculate this value from the tilt of the surface")]
        [JsonProperty("view_factor_to_ground")]
        public string ViewFactorToGround { get; set; } = (System.String)"Autocalculate";
        

        [Description(@"shown with 120 vertex coordinates -- extensible object ""extensible"" -- duplicate last set of x,y,z coordinates (last 3 fields), remembering to remove ; from ""inner"" fields. for clarity in any error messages, renumber the fields as well. (and changing z terminator to a comma "","" for all but last one which needs a semi-colon "";"") vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates are ""relative"" to the Zone Origin. If world, then building and zone origins are used for some internal calculations, but all coordinates are given in an ""absolute"" system.")]
        [JsonProperty("number_of_vertices")]
        public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("vertices")]
        public string Vertices { get; set; } = "";
    }
}