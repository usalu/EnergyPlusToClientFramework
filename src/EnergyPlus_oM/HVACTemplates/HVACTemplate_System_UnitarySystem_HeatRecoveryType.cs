using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitarySystem_HeatRecoveryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Sensible")]
        Sensible = 3,
    }
}