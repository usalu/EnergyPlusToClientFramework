using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    public enum DemandManager_Thermostats_ResetControl
    {
        
        [JsonProperty("Fixed")]
        Fixed = 0,
        
        [JsonProperty("Off")]
        Off = 1,
    }
}