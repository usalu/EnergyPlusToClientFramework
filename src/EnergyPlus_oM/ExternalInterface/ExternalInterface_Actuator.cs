using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("Hardware portion of EMS used to set up actuators in the model")]
    public class ExternalInterface_Actuator : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("actuated_component_unique_name")]
        public string ActuatedComponentUniqueName { get; set; } = "";
        

        [JsonProperty("actuated_component_type")]
        public string ActuatedComponentType { get; set; } = "";
        

        [JsonProperty("actuated_component_control_type")]
        public string ActuatedComponentControlType { get; set; } = "";
        

        [Description("If specified, it is used during warm-up and system sizing. If not specified, then" +
                     " the actuator only overwrites the actuated component after the warm-up and syste" +
                     "m sizing.")]
        [JsonProperty("optional_initial_value")]
        public System.Nullable<float> OptionalInitialValue { get; set; } = null;
    }
}