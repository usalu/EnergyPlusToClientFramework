using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("This object is used in places where lists of nodes may be needed, e.g. ZoneHVAC:E" +
                 "quipmentConnections field Zone Air Inlet Node or NodeList Name")]
    [JsonObject("NodeList")]
    public class NodeList : BHoMObject
    {
        

        [JsonProperty("nodes")]
        public string Nodes { get; set; } = "";
    }
}