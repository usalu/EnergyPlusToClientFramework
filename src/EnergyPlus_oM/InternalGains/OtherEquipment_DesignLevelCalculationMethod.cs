using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum OtherEquipment_DesignLevelCalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("EquipmentLevel")]
        EquipmentLevel = 1,
        
        [JsonProperty("Power/Area")]
        PowerArea = 2,
        
        [JsonProperty("Power/Person")]
        PowerPerson = 3,
        
        [JsonProperty("Watts/Area")]
        WattsArea = 4,
        
        [JsonProperty("Watts/Person")]
        WattsPerson = 5,
    }
}