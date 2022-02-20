using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_MicroCHP_NonNormalizedParameters_WarmUpMode
    {
        
        [JsonProperty("NominalEngineTemperature")]
        NominalEngineTemperature = 0,
        
        [JsonProperty("TimeDelay")]
        TimeDelay = 1,
    }
}