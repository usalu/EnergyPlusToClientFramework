using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    public enum DemandManager_Lights_SelectionControl
    {
        
        [JsonProperty("All")]
        All = 0,
        
        [JsonProperty("RotateMany")]
        RotateMany = 1,
        
        [JsonProperty("RotateOne")]
        RotateOne = 2,
    }
}