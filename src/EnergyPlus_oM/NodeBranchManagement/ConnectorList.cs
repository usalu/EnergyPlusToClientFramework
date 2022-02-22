using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("only two connectors allowed per loop if two entered, one must be Connector:Splitt" +
                 "er and one must be Connector:Mixer")]
    [JsonObject("ConnectorList")]
    public class ConnectorList : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("connector_1_object_type")]
        public ConnectorList_Connector1ObjectType Connector1ObjectType { get; set; } = (ConnectorList_Connector1ObjectType)Enum.Parse(typeof(ConnectorList_Connector1ObjectType), "ConnectorMixer");
        

        [JsonProperty("connector_1_name")]
        public string Connector1Name { get; set; } = "";
        

        [JsonProperty("connector_2_object_type")]
        public ConnectorList_Connector2ObjectType Connector2ObjectType { get; set; } = (ConnectorList_Connector2ObjectType)Enum.Parse(typeof(ConnectorList_Connector2ObjectType), "ConnectorMixer");
        

        [JsonProperty("connector_2_name")]
        public string Connector2Name { get; set; } = "";
    }
}