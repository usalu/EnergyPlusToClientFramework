using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_WindowAirConditioner_FanPlacement
    {
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 0,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 1,
    }
}