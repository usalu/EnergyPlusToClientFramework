using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_System_IntercoolerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Flash Intercooler")]
        FlashIntercooler = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Shell-and-Coil Intercooler")]
        ShellandCoilIntercooler = 3,
    }
}