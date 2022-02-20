using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    public enum PlantComponent_UserDefined_PlantConnection4LoadingMode
    {
        
        [JsonProperty("DemandsLoad")]
        DemandsLoad = 0,
        
        [JsonProperty("MeetLoadWithNominalCapacity")]
        MeetLoadWithNominalCapacity = 1,
        
        [JsonProperty("MeetLoadWithNominalCapacityHiOutLimit")]
        MeetLoadWithNominalCapacityHiOutLimit = 2,
        
        [JsonProperty("MeetLoadWithNominalCapacityLowOutLimit")]
        MeetLoadWithNominalCapacityLowOutLimit = 3,
        
        [JsonProperty("MeetLoadWithPassiveCapacity")]
        MeetLoadWithPassiveCapacity = 4,
    }
}