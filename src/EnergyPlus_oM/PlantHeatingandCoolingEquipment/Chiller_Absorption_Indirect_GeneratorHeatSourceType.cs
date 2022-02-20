using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum Chiller_Absorption_Indirect_GeneratorHeatSourceType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("HotWater")]
        HotWater = 1,
        
        [JsonProperty("Steam")]
        Steam = 2,
    }
}