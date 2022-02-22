using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("RoomAir modeling using Airflow pressure network solver")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_AirflowNetwork : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Name of Zone being described. Any existing zone name")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("control_point_roomairflownetwork_node_name")]
        public string ControlPointRoomairflownetworkNodeName { get; set; } = "";
        

        [JsonProperty("nodes")]
        public string Nodes { get; set; } = "";
    }
}