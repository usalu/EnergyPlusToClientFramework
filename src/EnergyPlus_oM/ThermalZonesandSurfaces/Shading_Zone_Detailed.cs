using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("used For fins, overhangs, elements that shade the building, are attached to the b" +
                 "uilding but are not part of the heat transfer calculations")]
    [JsonObject("Shading:Zone:Detailed")]
    public class Shading_Zone_Detailed : BHoMObject
    {
        

        [JsonProperty("base_surface_name")]
        public string BaseSurfaceName { get; set; } = "";
        

        [Description("Transmittance schedule for the shading device, defaults to zero (always opaque)")]
        [JsonProperty("transmittance_schedule_name")]
        public string TransmittanceScheduleName { get; set; } = "";
        

        [Description(@"shown with 6 vertex coordinates -- extensible object vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates are ""relative"" to the Zone Origin. if world, then building and zone origins are used for some internal calculations, but all coordinates are given in an ""absolute"" system.")]
        [JsonProperty("number_of_vertices")]
        public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("vertices")]
        public string Vertices { get; set; } = "";
    }
}