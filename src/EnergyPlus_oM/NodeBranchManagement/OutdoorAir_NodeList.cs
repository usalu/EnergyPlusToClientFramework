using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description(@"This object sets the temperature and humidity conditions for an outdoor air node using the weather data values. to vary outdoor air node conditions with height above ground use OutdoorAir:Node instead of this object. This object may be used more than once. The same node name may not appear in both an OutdoorAir:Node object and an OutdoorAir:NodeList object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutdoorAir_NodeList : BHoMObject
    {
        

        [JsonProperty("nodes")]
        public string Nodes { get; set; } = "";
    }
}