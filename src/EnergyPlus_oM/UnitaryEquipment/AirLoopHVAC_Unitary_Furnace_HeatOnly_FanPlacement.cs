using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_Unitary_Furnace_HeatOnly_FanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
}