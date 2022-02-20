using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_IdealLoadsAirSystem_OutdoorAirEconomizerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [JsonProperty("DifferentialEnthalpy")]
        DifferentialEnthalpy = 2,
        
        [JsonProperty("NoEconomizer")]
        NoEconomizer = 3,
    }
}