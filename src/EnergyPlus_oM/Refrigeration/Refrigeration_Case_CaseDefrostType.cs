using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_Case_CaseDefrostType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("ElectricWithTemperatureTermination")]
        ElectricWithTemperatureTermination = 2,
        
        [JsonProperty("HotFluid")]
        HotFluid = 3,
        
        [JsonProperty("HotFluidWithTemperatureTermination")]
        HotFluidWithTemperatureTermination = 4,
        
        [JsonProperty("HotGas")]
        HotGas = 5,
        
        [JsonProperty("HotGasWithTemperatureTermination")]
        HotGasWithTemperatureTermination = 6,
        
        [JsonProperty("None")]
        None = 7,
        
        [JsonProperty("OffCycle")]
        OffCycle = 8,
    }
}