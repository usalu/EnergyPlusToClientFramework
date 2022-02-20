using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_Stratified_SourceSideFlowControlMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("IndirectHeatAlternateSetpoint")]
        IndirectHeatAlternateSetpoint = 1,
        
        [JsonProperty("IndirectHeatPrimarySetpoint")]
        IndirectHeatPrimarySetpoint = 2,
        
        [JsonProperty("StorageTank")]
        StorageTank = 3,
    }
}