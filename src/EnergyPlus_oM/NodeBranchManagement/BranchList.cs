using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("Branches MUST be listed in Flow order: Inlet branch, then parallel branches, then" +
                 " Outlet branch. Branches are simulated in the order listed. Branch names cannot " +
                 "be duplicated within a single branch list.")]
    [JsonObject("BranchList")]
    public class BranchList : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("branches")]
        public string Branches { get; set; } = "";
    }
}