using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("This object is used in places where lists of nodes may be needed, e.g. ZoneHVAC:E" +
                 "quipmentConnections field Zone Air Inlet Node or NodeList Name")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class NodeList : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("nodes")]
        public string Nodes { get; set; } = "";
    }
}