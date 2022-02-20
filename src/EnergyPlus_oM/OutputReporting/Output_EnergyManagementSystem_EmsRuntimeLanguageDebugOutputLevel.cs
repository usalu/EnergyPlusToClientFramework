using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_EnergyManagementSystem_EmsRuntimeLanguageDebugOutputLevel
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ErrorsOnly")]
        ErrorsOnly = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Verbose")]
        Verbose = 3,
    }
}