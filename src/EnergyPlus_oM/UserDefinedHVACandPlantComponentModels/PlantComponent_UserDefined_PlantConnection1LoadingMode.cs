namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    public enum PlantComponent_UserDefined_PlantConnection1LoadingMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="DemandsLoad")]
        DemandsLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetsLoadWithNominalCapacity")]
        MeetsLoadWithNominalCapacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetsLoadWithNominalCapacityHiOutLimit")]
        MeetsLoadWithNominalCapacityHiOutLimit = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetsLoadWithNominalCapacityLowOutLimit")]
        MeetsLoadWithNominalCapacityLowOutLimit = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetsLoadWithPassiveCapacity")]
        MeetsLoadWithPassiveCapacity = 4,
    }
}