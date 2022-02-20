using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("Hardware portion of EMS used to set up actuators in the model")]
    [JsonObject("EnergyManagementSystem:Actuator")]
    public class EnergyManagementSystem_Actuator : BHoMObject
    {
        

        [JsonProperty("actuated_component_unique_name")]
        public string ActuatedComponentUniqueName { get; set; } = "";
        

        [JsonProperty("actuated_component_type")]
        public string ActuatedComponentType { get; set; } = "";
        

        [JsonProperty("actuated_component_control_type")]
        public string ActuatedComponentControlType { get; set; } = "";
    }
}