using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    public enum WaterUse_Connections_DrainWaterHeatExchangerDestination
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Equipment")]
        Equipment = 1,
        
        [JsonProperty("Plant")]
        Plant = 2,
        
        [JsonProperty("PlantAndEquipment")]
        PlantAndEquipment = 3,
    }
}