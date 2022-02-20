using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    public enum PlantLoop_LoadDistributionScheme
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Optimal")]
        Optimal = 1,
        
        [JsonProperty("SequentialLoad")]
        SequentialLoad = 2,
        
        [JsonProperty("SequentialUniformPLR")]
        SequentialUniformPLR = 3,
        
        [JsonProperty("UniformLoad")]
        UniformLoad = 4,
        
        [JsonProperty("UniformPLR")]
        UniformPLR = 5,
    }
}