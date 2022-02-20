using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum GlobalGeometryRules_StartingVertexPosition
    {
        
        [JsonProperty("LowerLeftCorner")]
        LowerLeftCorner = 0,
        
        [JsonProperty("LowerRightCorner")]
        LowerRightCorner = 1,
        
        [JsonProperty("UpperLeftCorner")]
        UpperLeftCorner = 2,
        
        [JsonProperty("UpperRightCorner")]
        UpperRightCorner = 3,
    }
}