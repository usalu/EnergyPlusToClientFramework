using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    public enum PlantComponent_UserDefined_PlantConnection1LoadingMode
    {
        
        [JsonProperty("DemandsLoad")]
        DemandsLoad = 0,
        
        [JsonProperty("MeetsLoadWithNominalCapacity")]
        MeetsLoadWithNominalCapacity = 1,
        
        [JsonProperty("MeetsLoadWithNominalCapacityHiOutLimit")]
        MeetsLoadWithNominalCapacityHiOutLimit = 2,
        
        [JsonProperty("MeetsLoadWithNominalCapacityLowOutLimit")]
        MeetsLoadWithNominalCapacityLowOutLimit = 3,
        
        [JsonProperty("MeetsLoadWithPassiveCapacity")]
        MeetsLoadWithPassiveCapacity = 4,
    }
}