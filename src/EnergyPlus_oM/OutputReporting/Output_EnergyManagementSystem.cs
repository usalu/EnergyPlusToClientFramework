using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("This object is used to control the output produced by the Energy Management Syste" +
                 "m")]
    [JsonObject("Output:EnergyManagementSystem")]
    public class Output_EnergyManagementSystem : BHoMObject
    {
        

        [JsonProperty("actuator_availability_dictionary_reporting")]
        public EmptyNoYes ActuatorAvailabilityDictionaryReporting { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

        [JsonProperty("internal_variable_availability_dictionary_reporting")]
        public EmptyNoYes InternalVariableAvailabilityDictionaryReporting { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

        [JsonProperty("ems_runtime_language_debug_output_level")]
        public EmptyNoYes EmsRuntimeLanguageDebugOutputLevel { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
    }
}