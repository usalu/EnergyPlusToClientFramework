using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("This input defines an Erl program subroutine Each field after the name is a line " +
                 "of EMS Runtime Language")]
    public class EnergyManagementSystem_Subroutine : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("lines")]
        public string Lines { get; set; } = "";
    }
}