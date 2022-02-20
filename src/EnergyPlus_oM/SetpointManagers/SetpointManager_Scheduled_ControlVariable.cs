using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_Scheduled_ControlVariable
    {
        
        [JsonProperty("HumidityRatio")]
        HumidityRatio = 0,
        
        [JsonProperty("MassFlowRate")]
        MassFlowRate = 1,
        
        [JsonProperty("MaximumHumidityRatio")]
        MaximumHumidityRatio = 2,
        
        [JsonProperty("MaximumMassFlowRate")]
        MaximumMassFlowRate = 3,
        
        [JsonProperty("MaximumTemperature")]
        MaximumTemperature = 4,
        
        [JsonProperty("MinimumHumidityRatio")]
        MinimumHumidityRatio = 5,
        
        [JsonProperty("MinimumMassFlowRate")]
        MinimumMassFlowRate = 6,
        
        [JsonProperty("MinimumTemperature")]
        MinimumTemperature = 7,
        
        [JsonProperty("Temperature")]
        Temperature = 8,
    }
}