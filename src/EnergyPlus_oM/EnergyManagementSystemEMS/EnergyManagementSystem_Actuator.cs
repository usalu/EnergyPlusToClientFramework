using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("Hardware portion of EMS used to set up actuators in the model")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_Actuator : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("actuated_component_unique_name")]
        public string ActuatedComponentUniqueName { get; set; } = "";
        

        [JsonProperty("actuated_component_type")]
        public string ActuatedComponentType { get; set; } = "";
        

        [JsonProperty("actuated_component_control_type")]
        public string ActuatedComponentControlType { get; set; } = "";
    }
}