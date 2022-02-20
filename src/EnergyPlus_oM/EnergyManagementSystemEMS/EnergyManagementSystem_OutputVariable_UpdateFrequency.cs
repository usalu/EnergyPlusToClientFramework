using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    public enum EnergyManagementSystem_OutputVariable_UpdateFrequency
    {
        
        [JsonProperty("SystemTimestep")]
        SystemTimestep = 0,
        
        [JsonProperty("ZoneTimestep")]
        ZoneTimestep = 1,
    }
}