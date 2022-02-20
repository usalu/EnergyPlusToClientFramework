using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    public enum GroundHeatTransfer_Basement_Interior_CondFlagIsTheBasementConditioned
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FALSE")]
        FALSE = 1,
        
        [JsonProperty("TRUE")]
        TRUE = 2,
    }
}