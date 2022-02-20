using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceConvectionAlgorithm_Outside_UserCurve_WindSpeedTypeForCurve
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("HeightAdjust")]
        HeightAdjust = 1,
        
        [JsonProperty("ParallelComponent")]
        ParallelComponent = 2,
        
        [JsonProperty("ParallelComponentHeightAdjust")]
        ParallelComponentHeightAdjust = 3,
        
        [JsonProperty("WeatherFile")]
        WeatherFile = 4,
    }
}