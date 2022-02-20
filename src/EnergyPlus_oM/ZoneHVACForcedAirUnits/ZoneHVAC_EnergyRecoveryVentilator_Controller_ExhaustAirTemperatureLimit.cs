using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirTemperatureLimit
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ExhaustAirTemperatureLimit")]
        ExhaustAirTemperatureLimit = 1,
        
        [JsonProperty("NoExhaustAirTemperatureLimit")]
        NoExhaustAirTemperatureLimit = 2,
    }
}