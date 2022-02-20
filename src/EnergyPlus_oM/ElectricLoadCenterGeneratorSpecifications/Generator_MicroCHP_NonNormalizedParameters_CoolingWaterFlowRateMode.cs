using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_MicroCHP_NonNormalizedParameters_CoolingWaterFlowRateMode
    {
        
        [JsonProperty("InternalControl")]
        InternalControl = 0,
        
        [JsonProperty("PlantControl")]
        PlantControl = 1,
    }
}