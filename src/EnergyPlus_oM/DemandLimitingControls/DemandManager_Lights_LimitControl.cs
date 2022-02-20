using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    public enum DemandManager_Lights_LimitControl
    {
        
        [JsonProperty("Fixed")]
        Fixed = 0,
        
        [JsonProperty("Off")]
        Off = 1,
    }
}