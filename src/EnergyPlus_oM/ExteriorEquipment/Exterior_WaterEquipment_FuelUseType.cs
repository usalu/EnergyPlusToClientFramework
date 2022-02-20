using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExteriorEquipment
{
    public enum Exterior_WaterEquipment_FuelUseType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Water")]
        Water = 1,
    }
}