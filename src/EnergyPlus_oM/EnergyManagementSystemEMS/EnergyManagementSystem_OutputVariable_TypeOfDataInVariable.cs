using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    public enum EnergyManagementSystem_OutputVariable_TypeOfDataInVariable
    {
        
        [JsonProperty("Averaged")]
        Averaged = 0,
        
        [JsonProperty("Summed")]
        Summed = 1,
    }
}