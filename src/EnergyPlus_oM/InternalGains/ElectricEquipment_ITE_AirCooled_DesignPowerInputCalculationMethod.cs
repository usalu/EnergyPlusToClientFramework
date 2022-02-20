using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum ElectricEquipment_ITE_AirCooled_DesignPowerInputCalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Watts/Area")]
        WattsArea = 1,
        
        [JsonProperty("Watts/Unit")]
        WattsUnit = 2,
    }
}