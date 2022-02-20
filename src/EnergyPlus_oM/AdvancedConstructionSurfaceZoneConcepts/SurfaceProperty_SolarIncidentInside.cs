using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Used to provide incident solar radiation on the inside of the surface. Reference " +
                 "surface-construction pair and if that pair is used in a simulation, then program" +
                 " will use value provided in schedule instead of calculating it.")]
    [JsonObject("SurfaceProperty:SolarIncidentInside")]
    public class SurfaceProperty_SolarIncidentInside : BHoMObject
    {
        

        [JsonProperty("surface_name")]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty("construction_name")]
        public string ConstructionName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty("inside_surface_incident_sun_solar_radiation_schedule_name")]
        public string InsideSurfaceIncidentSunSolarRadiationScheduleName { get; set; } = "";
    }
}