using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Cooling_Water_HeatExchangerConfiguration
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CounterFlow")]
        CounterFlow = 1,
        
        [JsonProperty("CrossFlow")]
        CrossFlow = 2,
    }
}