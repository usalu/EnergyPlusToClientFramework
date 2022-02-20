using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    public enum EnergyManagementSystem_MeteredOutputVariable_GroupType
    {
        
        [JsonProperty("Building")]
        Building = 0,
        
        [JsonProperty("HVAC")]
        HVAC = 1,
        
        [JsonProperty("Plant")]
        Plant = 2,
        
        [JsonProperty("System")]
        System = 3,
    }
}