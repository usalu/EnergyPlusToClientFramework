using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    public enum SolarCollectorPerformance_PhotovoltaicThermal_Simple_ThermalConversionEfficiencyInputModeType
    {
        
        [JsonProperty("Fixed")]
        Fixed = 0,
        
        [JsonProperty("Scheduled")]
        Scheduled = 1,
    }
}