using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum Generator_MicroTurbine_HeatRecoveryWaterFlowOperatingMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("InternalControl")]
        InternalControl = 1,
        
        [JsonProperty("PlantControl")]
        PlantControl = 2,
    }
}