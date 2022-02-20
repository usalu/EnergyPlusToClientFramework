using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_MultiZone_Zone_VentilationControlMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAE55Adaptive")]
        ASHRAE55Adaptive = 1,
        
        [JsonProperty("CEN15251Adaptive")]
        CEN15251Adaptive = 2,
        
        [JsonProperty("Constant")]
        Constant = 3,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 4,
        
        [JsonProperty("NoVent")]
        NoVent = 5,
        
        [JsonProperty("Temperature")]
        Temperature = 6,
    }
}