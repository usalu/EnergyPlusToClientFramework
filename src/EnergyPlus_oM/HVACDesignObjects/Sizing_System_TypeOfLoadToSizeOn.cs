using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    public enum Sizing_System_TypeOfLoadToSizeOn
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Sensible")]
        Sensible = 1,
        
        [JsonProperty("Total")]
        Total = 2,
        
        [JsonProperty("VentilationRequirement")]
        VentilationRequirement = 3,
    }
}