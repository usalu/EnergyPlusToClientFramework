using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("Declares EMS variable that identifies a construction")]
    [JsonObject("EnergyManagementSystem:ConstructionIndexVariable")]
    public class EnergyManagementSystem_ConstructionIndexVariable : BHoMObject
    {
        

        [JsonProperty("construction_object_name")]
        public string ConstructionObjectName { get; set; } = "";
    }
}