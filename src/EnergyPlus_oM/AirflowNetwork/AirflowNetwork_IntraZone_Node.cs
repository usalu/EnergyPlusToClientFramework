using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object represents a node in a zone in the combination of RoomAir and Airflow" +
                 "Network model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_IntraZone_Node : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of a RoomAir:Node object defined in a RoomAirSettings:AirflowNetwo" +
                     "rk object.")]
        [JsonProperty("roomair_node_airflownetwork_name")]
        public string RoomairNodeAirflownetworkName { get; set; } = "";
        

        [Description("Enter the name of a zone object defined in a AirflowNetwork:MultiZone:Zone object" +
                     ".")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Enter the reference height used to calculate the relative pressure")]
        [JsonProperty("node_height")]
        public System.Nullable<float> NodeHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}