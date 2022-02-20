using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum SurfaceConvectionAlgorithm_Outside_Algorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 1,
        
        [JsonProperty("DOE-2")]
        DOE2 = 2,
        
        [JsonProperty("MoWiTT")]
        MoWiTT = 3,
        
        [JsonProperty("SimpleCombined")]
        SimpleCombined = 4,
        
        [JsonProperty("TARP")]
        TARP = 5,
    }
}