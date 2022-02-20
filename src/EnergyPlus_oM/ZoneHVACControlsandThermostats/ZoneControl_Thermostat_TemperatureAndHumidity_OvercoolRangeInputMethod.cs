using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    public enum ZoneControl_Thermostat_TemperatureAndHumidity_OvercoolRangeInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("Scheduled")]
        Scheduled = 2,
    }
}