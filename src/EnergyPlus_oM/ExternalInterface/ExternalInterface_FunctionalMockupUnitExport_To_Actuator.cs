using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("Hardware portion of EMS used to set up actuators in the model that are dynamicall" +
                 "y updated from the FMU.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ExternalInterface_FunctionalMockupUnitExport_To_Actuator : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("actuated_component_unique_name")]
        public string ActuatedComponentUniqueName { get; set; } = "";
        

        [JsonProperty("actuated_component_type")]
        public string ActuatedComponentType { get; set; } = "";
        

        [JsonProperty("actuated_component_control_type")]
        public string ActuatedComponentControlType { get; set; } = "";
        

        [JsonProperty("fmu_variable_name")]
        public string FmuVariableName { get; set; } = "";
        

        [Description("Used during the first call of EnergyPlus.")]
        [JsonProperty("initial_value")]
        public System.Nullable<float> InitialValue { get; set; } = null;
    }
}