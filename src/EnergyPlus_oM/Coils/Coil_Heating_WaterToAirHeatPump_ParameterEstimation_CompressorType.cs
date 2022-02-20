using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Heating_WaterToAirHeatPump_ParameterEstimation_CompressorType
    {
        
        [JsonProperty("Reciprocating")]
        Reciprocating = 0,
        
        [JsonProperty("Rotary")]
        Rotary = 1,
        
        [JsonProperty("Scroll")]
        Scroll = 2,
    }
}