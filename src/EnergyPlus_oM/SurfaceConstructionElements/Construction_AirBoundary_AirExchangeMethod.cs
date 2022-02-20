using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum Construction_AirBoundary_AirExchangeMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("SimpleMixing")]
        SimpleMixing = 2,
    }
}