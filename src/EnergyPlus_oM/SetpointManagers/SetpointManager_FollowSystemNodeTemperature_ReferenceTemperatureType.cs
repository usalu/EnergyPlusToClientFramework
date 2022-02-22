namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_FollowSystemNodeTemperature_ReferenceTemperatureType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NodeDryBulb")]
        NodeDryBulb = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NodeWetBulb")]
        NodeWetBulb = 2,
    }
}