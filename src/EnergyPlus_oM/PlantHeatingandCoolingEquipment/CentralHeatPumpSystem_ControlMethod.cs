using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    public enum CentralHeatPumpSystem_ControlMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SmartMixing")]
        SmartMixing = 1,
    }
}