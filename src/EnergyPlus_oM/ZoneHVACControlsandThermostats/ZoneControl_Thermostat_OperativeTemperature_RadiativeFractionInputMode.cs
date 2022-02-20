using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    public enum ZoneControl_Thermostat_OperativeTemperature_RadiativeFractionInputMode
    {
        
        [JsonProperty("Constant")]
        Constant = 0,
        
        [JsonProperty("Scheduled")]
        Scheduled = 1,
    }
}