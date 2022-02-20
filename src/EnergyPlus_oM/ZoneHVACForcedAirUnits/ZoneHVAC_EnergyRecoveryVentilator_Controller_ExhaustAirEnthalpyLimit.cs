using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirEnthalpyLimit
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ExhaustAirEnthalpyLimit")]
        ExhaustAirEnthalpyLimit = 1,
        
        [JsonProperty("NoExhaustAirEnthalpyLimit")]
        NoExhaustAirEnthalpyLimit = 2,
    }
}