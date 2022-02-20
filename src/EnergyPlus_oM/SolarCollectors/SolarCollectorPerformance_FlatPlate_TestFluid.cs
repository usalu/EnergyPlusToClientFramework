using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    public enum SolarCollectorPerformance_FlatPlate_TestFluid
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Water")]
        Water = 1,
    }
}