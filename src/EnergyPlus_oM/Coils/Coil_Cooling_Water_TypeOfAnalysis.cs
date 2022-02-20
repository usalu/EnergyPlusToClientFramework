using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Cooling_Water_TypeOfAnalysis
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedAnalysis")]
        DetailedAnalysis = 1,
        
        [JsonProperty("SimpleAnalysis")]
        SimpleAnalysis = 2,
    }
}