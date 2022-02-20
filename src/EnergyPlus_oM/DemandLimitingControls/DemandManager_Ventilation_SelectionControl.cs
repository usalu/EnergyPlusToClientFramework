using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    public enum DemandManager_Ventilation_SelectionControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("All")]
        All = 1,
        
        [JsonProperty("RotateMany")]
        RotateMany = 2,
        
        [JsonProperty("RotateOne")]
        RotateOne = 3,
    }
}