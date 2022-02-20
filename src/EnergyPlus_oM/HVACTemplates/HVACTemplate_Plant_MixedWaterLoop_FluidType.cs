using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_MixedWaterLoop_FluidType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("EthyleneGlycol30")]
        EthyleneGlycol30 = 1,
        
        [JsonProperty("EthyleneGlycol40")]
        EthyleneGlycol40 = 2,
        
        [JsonProperty("EthyleneGlycol50")]
        EthyleneGlycol50 = 3,
        
        [JsonProperty("EthyleneGlycol60")]
        EthyleneGlycol60 = 4,
        
        [JsonProperty("PropyleneGlycol30")]
        PropyleneGlycol30 = 5,
        
        [JsonProperty("PropyleneGlycol40")]
        PropyleneGlycol40 = 6,
        
        [JsonProperty("PropyleneGlycol50")]
        PropyleneGlycol50 = 7,
        
        [JsonProperty("PropyleneGlycol60")]
        PropyleneGlycol60 = 8,
        
        [JsonProperty("Water")]
        Water = 9,
    }
}