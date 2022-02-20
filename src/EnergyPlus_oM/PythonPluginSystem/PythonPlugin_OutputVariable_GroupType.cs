using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    public enum PythonPlugin_OutputVariable_GroupType
    {
        
        [JsonProperty("Building")]
        Building = 0,
        
        [JsonProperty("HVAC")]
        HVAC = 1,
        
        [JsonProperty("Plant")]
        Plant = 2,
        
        [JsonProperty("System")]
        System = 3,
    }
}