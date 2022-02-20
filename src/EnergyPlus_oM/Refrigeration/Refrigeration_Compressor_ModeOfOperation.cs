using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_Compressor_ModeOfOperation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Subcritical")]
        Subcritical = 1,
        
        [JsonProperty("Transcritical")]
        Transcritical = 2,
    }
}