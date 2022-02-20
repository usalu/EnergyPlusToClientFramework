using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.FluidProperties
{
    public enum FluidProperties_GlycolConcentration_GlycolType
    {
        
        [JsonProperty("EthyleneGlycol")]
        EthyleneGlycol = 0,
        
        [JsonProperty("PropyleneGlycol")]
        PropyleneGlycol = 1,
        
        [JsonProperty("UserDefinedGlycolType")]
        UserDefinedGlycolType = 2,
    }
}