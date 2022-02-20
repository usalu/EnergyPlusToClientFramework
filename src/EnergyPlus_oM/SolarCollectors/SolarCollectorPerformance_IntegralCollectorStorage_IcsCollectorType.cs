using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    public enum SolarCollectorPerformance_IntegralCollectorStorage_IcsCollectorType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("RectangularTank")]
        RectangularTank = 1,
    }
}