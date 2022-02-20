using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_Case_LatentCaseCreditCurveType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CaseTemperatureMethod")]
        CaseTemperatureMethod = 1,
        
        [JsonProperty("DewpointMethod")]
        DewpointMethod = 2,
        
        [JsonProperty("RelativeHumidityMethod")]
        RelativeHumidityMethod = 3,
    }
}