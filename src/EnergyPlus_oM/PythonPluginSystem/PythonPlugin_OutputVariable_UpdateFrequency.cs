using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    public enum PythonPlugin_OutputVariable_UpdateFrequency
    {
        
        [JsonProperty("SystemTimestep")]
        SystemTimestep = 0,
        
        [JsonProperty("ZoneTimestep")]
        ZoneTimestep = 1,
    }
}