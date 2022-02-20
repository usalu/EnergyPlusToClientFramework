using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    public enum PythonPlugin_OutputVariable_TypeOfDataInVariable
    {
        
        [JsonProperty("Averaged")]
        Averaged = 0,
        
        [JsonProperty("Metered")]
        Metered = 1,
        
        [JsonProperty("Summed")]
        Summed = 2,
    }
}