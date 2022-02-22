using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("used for shading elements such as trees these items are fixed in space and would " +
                 "not move with relative geometry")]
    public class Shading_Site_Detailed : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Transmittance schedule for the shading device, defaults to zero (always opaque)")]
        [JsonProperty("transmittance_schedule_name")]
        public string TransmittanceScheduleName { get; set; } = "";
        

        [Description("shown with 6 vertex coordinates -- extensible object Rules for vertices are given" +
                     " in GlobalGeometryRules coordinates -- For this object all surface coordinates a" +
                     "re in world coordinates.")]
        [JsonProperty("number_of_vertices")]
        public string NumberOfVertices { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("vertices")]
        public string Vertices { get; set; } = "";
    }
}