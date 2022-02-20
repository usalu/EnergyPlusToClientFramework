using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Distribution_StorageOperationScheme
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FacilityDemandLeveling")]
        FacilityDemandLeveling = 1,
        
        [JsonProperty("TrackChargeDischargeSchedules")]
        TrackChargeDischargeSchedules = 2,
        
        [JsonProperty("TrackFacilityElectricDemandStoreExcessOnSite")]
        TrackFacilityElectricDemandStoreExcessOnSite = 3,
        
        [JsonProperty("TrackMeterDemandStoreExcessOnSite")]
        TrackMeterDemandStoreExcessOnSite = 4,
    }
}