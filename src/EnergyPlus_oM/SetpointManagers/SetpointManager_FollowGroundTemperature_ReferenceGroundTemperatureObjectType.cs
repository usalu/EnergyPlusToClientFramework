using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_FollowGroundTemperature_ReferenceGroundTemperatureObjectType
    {
        
        [JsonProperty("Site:GroundTemperature:BuildingSurface")]
        SiteGroundTemperatureBuildingSurface = 0,
        
        [JsonProperty("Site:GroundTemperature:Deep")]
        SiteGroundTemperatureDeep = 1,
        
        [JsonProperty("Site:GroundTemperature:FCfactorMethod")]
        SiteGroundTemperatureFCfactorMethod = 2,
        
        [JsonProperty("Site:GroundTemperature:Shallow")]
        SiteGroundTemperatureShallow = 3,
    }
}