using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    public enum WaterUse_Storage_WaterThermalMode
    {
        
        [JsonProperty("ScheduledTemperature")]
        ScheduledTemperature = 0,
        
        [JsonProperty("ThermalModel")]
        ThermalModel = 1,
    }
}