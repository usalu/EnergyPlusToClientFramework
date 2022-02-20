using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_FollowSystemNodeTemperature_ReferenceTemperatureType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NodeDryBulb")]
        NodeDryBulb = 1,
        
        [JsonProperty("NodeWetBulb")]
        NodeWetBulb = 2,
    }
}