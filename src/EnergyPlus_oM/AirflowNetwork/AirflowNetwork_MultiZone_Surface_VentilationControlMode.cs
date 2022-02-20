using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_MultiZone_Surface_VentilationControlMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAE55Adaptive")]
        ASHRAE55Adaptive = 1,
        
        [JsonProperty("AdjacentEnthalpy")]
        AdjacentEnthalpy = 2,
        
        [JsonProperty("AdjacentTemperature")]
        AdjacentTemperature = 3,
        
        [JsonProperty("CEN15251Adaptive")]
        CEN15251Adaptive = 4,
        
        [JsonProperty("Constant")]
        Constant = 5,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 6,
        
        [JsonProperty("NoVent")]
        NoVent = 7,
        
        [JsonProperty("Temperature")]
        Temperature = 8,
        
        [JsonProperty("ZoneLevel")]
        ZoneLevel = 9,
    }
}