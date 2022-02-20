using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    public enum GroundHeatTransfer_Basement_Insulation_InsfullFlagIsTheWallFullyInsulated
    {
        
        [JsonProperty("FALSE")]
        FALSE = 0,
        
        [JsonProperty("TRUE")]
        TRUE = 1,
    }
}