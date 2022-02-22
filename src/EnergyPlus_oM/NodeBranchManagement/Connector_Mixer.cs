using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("Mix N inlet air/water streams into one. Branch names cannot be duplicated within " +
                 "a single mixer list.")]
    [JsonObject("Connector:Mixer")]
    public class Connector_Mixer : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("outlet_branch_name")]
        public string OutletBranchName { get; set; } = "";
        

        [JsonProperty("branches")]
        public string Branches { get; set; } = "";
    }
}