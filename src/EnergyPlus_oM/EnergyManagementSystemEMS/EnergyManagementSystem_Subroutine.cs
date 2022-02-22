using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("This input defines an Erl program subroutine Each field after the name is a line " +
                 "of EMS Runtime Language")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_Subroutine : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("lines")]
        public string Lines { get; set; } = "";
    }
}