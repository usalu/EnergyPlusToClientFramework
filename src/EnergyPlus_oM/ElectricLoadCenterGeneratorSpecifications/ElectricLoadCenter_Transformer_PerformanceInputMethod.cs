using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Transformer_PerformanceInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NominalEfficiency")]
        NominalEfficiency = 1,
        
        [JsonProperty("RatedLosses")]
        RatedLosses = 2,
    }
}