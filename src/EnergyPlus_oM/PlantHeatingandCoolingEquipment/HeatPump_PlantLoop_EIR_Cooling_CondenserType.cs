using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum HeatPump_PlantLoop_EIR_Cooling_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirSource")]
        AirSource = 1,
        
        [JsonProperty("WaterSource")]
        WaterSource = 2,
    }
}