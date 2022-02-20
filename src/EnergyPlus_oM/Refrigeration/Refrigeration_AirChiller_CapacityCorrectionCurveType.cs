using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_AirChiller_CapacityCorrectionCurveType
    {
        
        [JsonProperty("European")]
        European = 0,
        
        [JsonProperty("LinearSHR60")]
        LinearSHR60 = 1,
        
        [JsonProperty("QuadraticSHR")]
        QuadraticSHR = 2,
        
        [JsonProperty("TabularRHxDT1xTRoom")]
        TabularRHxDT1xTRoom = 3,
    }
}