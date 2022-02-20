using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    public enum SolarCollector_UnglazedTranspired_HoleLayoutPatternForPitch
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Square")]
        Square = 1,
        
        [JsonProperty("Triangle")]
        Triangle = 2,
    }
}