using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("View factors for Surface to Surface in a zone. (Number of Surfaces)**2 are expect" +
                 "ed. Any omitted surface pairs will be assumed to have a view factor of zero.")]
    [JsonObject("ZoneProperty:UserViewFactors:BySurfaceName")]
    public class ZoneProperty_UserViewFactors_BySurfaceName : BHoMObject
    {
        

        [Description("View factors may be entered for a single zone or for a group of zones connected b" +
                     "y Construction:AirBoundary")]
        [JsonProperty("zone_or_zonelist_name")]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [JsonProperty("view_factors")]
        public string ViewFactors { get; set; } = "";
    }
}