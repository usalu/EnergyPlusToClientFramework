using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_OutdoorAirPretreat_ControlVariable
    {
        
        [JsonProperty("HumidityRatio")]
        HumidityRatio = 0,
        
        [JsonProperty("MaximumHumidityRatio")]
        MaximumHumidityRatio = 1,
        
        [JsonProperty("MinimumHumidityRatio")]
        MinimumHumidityRatio = 2,
        
        [JsonProperty("Temperature")]
        Temperature = 3,
    }
}