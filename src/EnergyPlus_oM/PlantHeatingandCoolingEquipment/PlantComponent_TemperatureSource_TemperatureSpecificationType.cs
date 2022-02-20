using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum PlantComponent_TemperatureSource_TemperatureSpecificationType
    {
        
        [JsonProperty("Constant")]
        Constant = 0,
        
        [JsonProperty("Scheduled")]
        Scheduled = 1,
    }
}