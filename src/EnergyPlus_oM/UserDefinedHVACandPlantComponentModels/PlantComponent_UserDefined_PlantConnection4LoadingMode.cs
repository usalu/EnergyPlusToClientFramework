namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    public enum PlantComponent_UserDefined_PlantConnection4LoadingMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="DemandsLoad")]
        DemandsLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacity")]
        MeetLoadWithNominalCapacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacityHiOutLimit")]
        MeetLoadWithNominalCapacityHiOutLimit = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacityLowOutLimit")]
        MeetLoadWithNominalCapacityLowOutLimit = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithPassiveCapacity")]
        MeetLoadWithPassiveCapacity = 4,
    }
}