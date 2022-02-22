namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Distribution_StorageOperationScheme
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FacilityDemandLeveling")]
        FacilityDemandLeveling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TrackChargeDischargeSchedules")]
        TrackChargeDischargeSchedules = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="TrackFacilityElectricDemandStoreExcessOnSite")]
        TrackFacilityElectricDemandStoreExcessOnSite = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="TrackMeterDemandStoreExcessOnSite")]
        TrackMeterDemandStoreExcessOnSite = 4,
    }
}