using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterLoadDistributionScheme
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