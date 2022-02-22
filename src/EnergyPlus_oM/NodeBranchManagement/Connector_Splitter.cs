using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("Split one air/water stream into N outlet streams. Branch names cannot be duplicat" +
                 "ed within a single Splitter list.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Connector_Splitter : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("inlet_branch_name")]
        public string InletBranchName { get; set; } = "";
        

        [JsonProperty("branches")]
        public string Branches { get; set; } = "";
    }
}