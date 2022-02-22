using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("Declares EMS variable that identifies a construction")]
    public class EnergyManagementSystem_ConstructionIndexVariable : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("construction_object_name")]
        public string ConstructionObjectName { get; set; } = "";
    }
}