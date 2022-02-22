using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("Declares Erl variable as having global scope No spaces allowed in names used for " +
                 "Erl variables")]
    public class EnergyManagementSystem_GlobalVariable : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("variables")]
        public string Variables { get; set; } = "";
    }
}