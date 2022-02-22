namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_FollowOutdoorAirTemperature_ReferenceTemperatureType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAirDryBulb")]
        OutdoorAirDryBulb = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAirWetBulb")]
        OutdoorAirWetBulb = 2,
    }
}