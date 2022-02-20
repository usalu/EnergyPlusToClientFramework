using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    public enum WaterUse_Connections_DrainWaterHeatExchangerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CounterFlow")]
        CounterFlow = 1,
        
        [JsonProperty("CrossFlow")]
        CrossFlow = 2,
        
        [JsonProperty("Ideal")]
        Ideal = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
}