using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Pumps
{
    public enum Pump_VariableSpeed_PumpControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Continuous")]
        Continuous = 1,
        
        [JsonProperty("Intermittent")]
        Intermittent = 2,
    }
}