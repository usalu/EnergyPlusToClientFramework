using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("This object is used to control the output produced by the Energy Management Syste" +
                 "m")]
    [JsonObject("Output:EnergyManagementSystem")]
    public class Output_EnergyManagementSystem : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("actuator_availability_dictionary_reporting")]
        public Output_EnergyManagementSystem_ActuatorAvailabilityDictionaryReporting ActuatorAvailabilityDictionaryReporting { get; set; } = (Output_EnergyManagementSystem_ActuatorAvailabilityDictionaryReporting)Enum.Parse(typeof(Output_EnergyManagementSystem_ActuatorAvailabilityDictionaryReporting), "None");
        

        [JsonProperty("internal_variable_availability_dictionary_reporting")]
        public Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting InternalVariableAvailabilityDictionaryReporting { get; set; } = (Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting)Enum.Parse(typeof(Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting), "None");
        

        [JsonProperty("ems_runtime_language_debug_output_level")]
        public Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel EmsRuntimeLanguageDebugOutputLevel { get; set; } = (Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel)Enum.Parse(typeof(Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel), "None");
    }
}