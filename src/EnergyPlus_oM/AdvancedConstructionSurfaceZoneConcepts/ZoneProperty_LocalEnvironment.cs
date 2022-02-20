using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("This object defines the local environment properties of a zone object. A correspo" +
                 "nding outdoor air node should be defined and linked to the zone object.")]
    [JsonObject("ZoneProperty:LocalEnvironment")]
    public class ZoneProperty_LocalEnvironment : BHoMObject
    {
        

        [Description("Enter the name of a zone object")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Enter the name of an OutdoorAir:Node object")]
        [JsonProperty("outdoor_air_node_name")]
        public string OutdoorAirNodeName { get; set; } = "";
    }
}