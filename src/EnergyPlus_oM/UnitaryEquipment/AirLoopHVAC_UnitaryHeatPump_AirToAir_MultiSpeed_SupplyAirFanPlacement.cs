using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_SupplyAirFanPlacement
    {
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 0,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 1,
    }
}