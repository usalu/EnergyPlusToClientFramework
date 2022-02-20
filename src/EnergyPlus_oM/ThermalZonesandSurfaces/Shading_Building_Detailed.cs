using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("used for shading elements such as trees, other buildings, parts of this building " +
                 "not being modeled these items are relative to the current building and would mov" +
                 "e with relative geometry")]
    [JsonObject("Shading:Building:Detailed")]
    public class Shading_Building_Detailed : BHoMObject
    {
        

        [Description("Transmittance schedule for the shading device, defaults to zero (always opaque)")]
        [JsonProperty("transmittance_schedule_name")]
        public string TransmittanceScheduleName { get; set; } = "";
        

        [Description("shown with 6 vertex coordinates -- extensible object Rules for vertices are given" +
                     " in GlobalGeometryRules coordinates -- For this object all surface coordinates a" +
                     "re relative to the building origin (0,0,0) and will rotate with the BUILDING nor" +
                     "th axis.")]
        [JsonProperty("number_of_vertices")]
        public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("vertices")]
        public string Vertices { get; set; } = "";
    }
}