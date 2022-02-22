using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("This object defines the local environment properties of an exterior surface. One " +
                 "or more environment properties have to be defined and linked to the exterior sur" +
                 "face.")]
    public class SurfaceProperty_LocalEnvironment : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Enter the name of an exterior surface object")]
        [JsonProperty("exterior_surface_name")]
        public string ExteriorSurfaceName { get; set; } = "";
        

        [Description("Enter the name of a Schedule object")]
        [JsonProperty("external_shading_fraction_schedule_name")]
        public string ExternalShadingFractionScheduleName { get; set; } = "";
        

        [Description("Enter the name of a SurfaceProperty:SurroundingSurfaces object")]
        [JsonProperty("surrounding_surfaces_object_name")]
        public string SurroundingSurfacesObjectName { get; set; } = "";
        

        [Description("Enter the name of an OutdoorAir:Node object")]
        [JsonProperty("outdoor_air_node_name")]
        public string OutdoorAirNodeName { get; set; } = "";
    }
}