using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("This object sets up a convective water boundary condition for a surface The free " +
                 "stream temperature and velocity are scheduled. If the free stream velocity is ze" +
                 "ro, the surface will naturally convect with the surrounding water.")]
    [JsonObject("SurfaceProperty:Underwater")]
    public class SurfaceProperty_Underwater : BHoMObject
    {
        

        [Description("This is the distance from the leading edge of the boundary layer development to t" +
                     "he centroid of the surface of interest. The value of this field is used as the d" +
                     "istance in the Reynolds number for evaluating the local convection coefficient.")]
        [JsonProperty("distance_from_surface_centroid_to_leading_edge_of_boundary_layer")]
        public System.Nullable<float> DistanceFromSurfaceCentroidToLeadingEdgeOfBoundaryLayer { get; set; } = null;
        

        [JsonProperty("free_stream_water_temperature_schedule")]
        public string FreeStreamWaterTemperatureSchedule { get; set; } = "";
        

        [JsonProperty("free_stream_water_velocity_schedule")]
        public string FreeStreamWaterVelocitySchedule { get; set; } = "";
    }
}