using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_WrappedCondenser_InletAirConfiguration
    {
        
        [JsonProperty("OutdoorAirOnly")]
        OutdoorAirOnly = 0,
        
        [JsonProperty("Schedule")]
        Schedule = 1,
        
        [JsonProperty("ZoneAirOnly")]
        ZoneAirOnly = 2,
        
        [JsonProperty("ZoneAndOutdoorAir")]
        ZoneAndOutdoorAir = 3,
    }
}