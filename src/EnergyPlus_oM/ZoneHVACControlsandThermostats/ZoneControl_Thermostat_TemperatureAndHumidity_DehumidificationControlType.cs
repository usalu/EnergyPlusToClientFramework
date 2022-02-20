using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    public enum ZoneControl_Thermostat_TemperatureAndHumidity_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("Overcool")]
        Overcool = 2,
    }
}