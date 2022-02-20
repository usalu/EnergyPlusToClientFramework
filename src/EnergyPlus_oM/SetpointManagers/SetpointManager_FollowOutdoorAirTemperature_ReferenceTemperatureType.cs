using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_FollowOutdoorAirTemperature_ReferenceTemperatureType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OutdoorAirDryBulb")]
        OutdoorAirDryBulb = 1,
        
        [JsonProperty("OutdoorAirWetBulb")]
        OutdoorAirWetBulb = 2,
    }
}