using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum ElectricEquipment_DesignLevelCalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("EquipmentLevel")]
        EquipmentLevel = 1,
        
        [JsonProperty("Watts/Area")]
        WattsArea = 2,
        
        [JsonProperty("Watts/Person")]
        WattsPerson = 3,
    }
}