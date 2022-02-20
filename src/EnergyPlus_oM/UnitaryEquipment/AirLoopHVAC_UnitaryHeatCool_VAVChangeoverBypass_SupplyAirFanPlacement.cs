using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanPlacement
    {
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 0,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 1,
    }
}