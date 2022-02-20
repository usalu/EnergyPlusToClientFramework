using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ShadowCalculation_PolygonClippingAlgorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConvexWeilerAtherton")]
        ConvexWeilerAtherton = 1,
        
        [JsonProperty("SlaterBarskyandSutherlandHodgman")]
        SlaterBarskyandSutherlandHodgman = 2,
        
        [JsonProperty("SutherlandHodgman")]
        SutherlandHodgman = 3,
    }
}