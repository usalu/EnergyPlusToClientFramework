using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    public enum Controller_OutdoorAir_EconomizerControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [JsonProperty("DifferentialDryBulbAndEnthalpy")]
        DifferentialDryBulbAndEnthalpy = 2,
        
        [JsonProperty("DifferentialEnthalpy")]
        DifferentialEnthalpy = 3,
        
        [JsonProperty("ElectronicEnthalpy")]
        ElectronicEnthalpy = 4,
        
        [JsonProperty("FixedDewPointAndDryBulb")]
        FixedDewPointAndDryBulb = 5,
        
        [JsonProperty("FixedDryBulb")]
        FixedDryBulb = 6,
        
        [JsonProperty("FixedEnthalpy")]
        FixedEnthalpy = 7,
        
        [JsonProperty("NoEconomizer")]
        NoEconomizer = 8,
    }
}