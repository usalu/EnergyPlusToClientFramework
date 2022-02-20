using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_EnergyManagementSystem_InternalVariableAvailabilityDictionaryReporting
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("NotByUniqueKeyNames")]
        NotByUniqueKeyNames = 2,
        
        [JsonProperty("Verbose")]
        Verbose = 3,
    }
}