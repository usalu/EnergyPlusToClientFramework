using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpDefrostStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Resistive")]
        Resistive = 1,
        
        [JsonProperty("ReverseCycle")]
        ReverseCycle = 2,
    }
}