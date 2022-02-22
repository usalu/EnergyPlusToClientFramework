using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("define an air node for some types of nodal air models")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node_AirflowNetwork : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("fraction_of_zone_air_volume")]
        public System.Nullable<float> FractionOfZoneAirVolume { get; set; } = null;
        

        [JsonProperty("roomair_node_airflownetwork_adjacentsurfacelist_name")]
        public string RoomairNodeAirflownetworkAdjacentsurfacelistName { get; set; } = "";
        

        [JsonProperty("roomair_node_airflownetwork_internalgains_name")]
        public string RoomairNodeAirflownetworkInternalgainsName { get; set; } = "";
        

        [JsonProperty("roomair_node_airflownetwork_hvacequipment_name")]
        public string RoomairNodeAirflownetworkHvacequipmentName { get; set; } = "";
    }
}