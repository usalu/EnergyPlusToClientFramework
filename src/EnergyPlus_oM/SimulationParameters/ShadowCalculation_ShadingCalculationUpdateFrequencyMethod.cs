using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ShadowCalculation_ShadingCalculationUpdateFrequencyMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Periodic")]
        Periodic = 1,
        
        [JsonProperty("Timestep")]
        Timestep = 2,
    }
}