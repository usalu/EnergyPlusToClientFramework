using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_ReturnTemperature_HotWater_ReturnTemperatureSetpointInputType
    {
        
        [JsonProperty("Constant")]
        Constant = 0,
        
        [JsonProperty("ReturnTemperatureSetpoint")]
        ReturnTemperatureSetpoint = 1,
        
        [JsonProperty("Scheduled")]
        Scheduled = 2,
    }
}