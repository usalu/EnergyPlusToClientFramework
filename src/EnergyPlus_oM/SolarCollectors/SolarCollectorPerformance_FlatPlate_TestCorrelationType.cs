using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    public enum SolarCollectorPerformance_FlatPlate_TestCorrelationType
    {
        
        [JsonProperty("Average")]
        Average = 0,
        
        [JsonProperty("Inlet")]
        Inlet = 1,
        
        [JsonProperty("Outlet")]
        Outlet = 2,
    }
}