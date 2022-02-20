using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_LatentLoadControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LatentOnlyLoadControl")]
        LatentOnlyLoadControl = 1,
        
        [JsonProperty("LatentOrSensibleLoadControl")]
        LatentOrSensibleLoadControl = 2,
        
        [JsonProperty("LatentWithSensibleLoadControl")]
        LatentWithSensibleLoadControl = 3,
        
        [JsonProperty("SensibleOnlyLoadControl")]
        SensibleOnlyLoadControl = 4,
    }
}