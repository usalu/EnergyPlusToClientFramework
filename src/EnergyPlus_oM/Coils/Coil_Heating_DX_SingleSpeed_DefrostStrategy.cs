using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Heating_DX_SingleSpeed_DefrostStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Resistive")]
        Resistive = 1,
        
        [JsonProperty("ReverseCycle")]
        ReverseCycle = 2,
    }
}