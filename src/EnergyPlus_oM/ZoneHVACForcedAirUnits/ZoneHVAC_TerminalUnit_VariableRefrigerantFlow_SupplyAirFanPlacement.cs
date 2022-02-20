using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
}