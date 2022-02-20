using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirEconomizerType
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