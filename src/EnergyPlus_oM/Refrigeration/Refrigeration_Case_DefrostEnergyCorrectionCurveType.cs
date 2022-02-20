using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_Case_DefrostEnergyCorrectionCurveType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CaseTemperatureMethod")]
        CaseTemperatureMethod = 1,
        
        [JsonProperty("DewpointMethod")]
        DewpointMethod = 2,
        
        [JsonProperty("None")]
        None = 3,
        
        [JsonProperty("RelativeHumidityMethod")]
        RelativeHumidityMethod = 4,
    }
}