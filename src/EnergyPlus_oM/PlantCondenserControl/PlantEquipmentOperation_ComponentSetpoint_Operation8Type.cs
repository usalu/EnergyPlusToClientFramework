using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    public enum PlantEquipmentOperation_ComponentSetpoint_Operation8Type
    {
        
        [JsonProperty("Cooling")]
        Cooling = 0,
        
        [JsonProperty("Dual")]
        Dual = 1,
        
        [JsonProperty("Heating")]
        Heating = 2,
    }
}