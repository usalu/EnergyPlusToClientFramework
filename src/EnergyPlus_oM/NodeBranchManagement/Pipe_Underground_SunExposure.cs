using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    public enum Pipe_Underground_SunExposure
    {
        
        [JsonProperty("NoSun")]
        NoSun = 0,
        
        [JsonProperty("SunExposed")]
        SunExposed = 1,
    }
}