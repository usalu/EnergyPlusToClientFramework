using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_PreprocessorMessage_ErrorSeverity
    {
        
        [JsonProperty("Fatal")]
        Fatal = 0,
        
        [JsonProperty("Information")]
        Information = 1,
        
        [JsonProperty("Severe")]
        Severe = 2,
        
        [JsonProperty("Warning")]
        Warning = 3,
    }
}