using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceProperty_ExposedFoundationPerimeter_ExposedPerimeterCalculationMethod
    {
        
        [JsonProperty("BySegment")]
        BySegment = 0,
        
        [JsonProperty("ExposedPerimeterFraction")]
        ExposedPerimeterFraction = 1,
        
        [JsonProperty("TotalExposedPerimeter")]
        TotalExposedPerimeter = 2,
    }
}