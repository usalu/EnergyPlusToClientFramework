using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_VRF_SupplyAirFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
}