using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("define an air node for some types of nodal air models")]
    public class RoomAir_Node_AirflowNetwork : BHoMObject, IEnergyPlusClass
    {
        

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