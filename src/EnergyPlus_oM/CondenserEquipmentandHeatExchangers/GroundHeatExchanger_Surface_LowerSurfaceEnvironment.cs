using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum GroundHeatExchanger_Surface_LowerSurfaceEnvironment
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Exposed")]
        Exposed = 1,
        
        [JsonProperty("Ground")]
        Ground = 2,
    }
}