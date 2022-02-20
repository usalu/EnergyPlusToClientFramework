using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    public enum GroundHeatTransfer_Slab_BoundConds_UsrhflagIsTheGroundSurfaceHSpecifiedByTheUser
    {
        
        [JsonProperty("FALSE")]
        FALSE = 0,
        
        [JsonProperty("TRUE")]
        TRUE = 1,
    }
}