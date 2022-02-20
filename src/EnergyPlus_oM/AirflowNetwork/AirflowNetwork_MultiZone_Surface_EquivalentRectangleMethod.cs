using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_MultiZone_Surface_EquivalentRectangleMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BaseSurfaceAspectRatio")]
        BaseSurfaceAspectRatio = 1,
        
        [JsonProperty("PolygonHeight")]
        PolygonHeight = 2,
        
        [JsonProperty("UserDefinedAspectRatio")]
        UserDefinedAspectRatio = 3,
    }
}