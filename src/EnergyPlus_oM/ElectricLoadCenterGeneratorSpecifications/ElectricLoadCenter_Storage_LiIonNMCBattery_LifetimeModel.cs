using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Storage_LiIonNMCBattery_LifetimeModel
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("KandlerSmith")]
        KandlerSmith = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
}