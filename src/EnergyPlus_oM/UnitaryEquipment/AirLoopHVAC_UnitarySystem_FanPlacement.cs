using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_FanPlacement
    {
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 0,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 1,
    }
}