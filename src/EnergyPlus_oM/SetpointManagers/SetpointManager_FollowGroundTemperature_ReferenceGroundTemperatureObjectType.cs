namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_FollowGroundTemperature_ReferenceGroundTemperatureObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:BuildingSurface")]
        SiteGroundTemperatureBuildingSurface = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Deep")]
        SiteGroundTemperatureDeep = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:FCfactorMethod")]
        SiteGroundTemperatureFCfactorMethod = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Site:GroundTemperature:Shallow")]
        SiteGroundTemperatureShallow = 3,
    }
}