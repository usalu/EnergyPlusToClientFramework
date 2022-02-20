using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum ChillerHeater_Absorption_DoubleEffect_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("WaterCooled")]
        WaterCooled = 2,
    }
}