using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    public enum GroundHeatTransfer_Basement_EquivSlab_EquivsizingFlag
    {
        
        [JsonProperty("FALSE")]
        FALSE = 0,
        
        [JsonProperty("TRUE")]
        TRUE = 1,
    }
}