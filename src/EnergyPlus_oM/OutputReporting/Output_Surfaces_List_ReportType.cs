using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    public enum Output_Surfaces_List_ReportType
    {
        
        [JsonProperty("CostInfo")]
        CostInfo = 0,
        
        [JsonProperty("DecayCurvesFromComponentLoadsSummary")]
        DecayCurvesFromComponentLoadsSummary = 1,
        
        [JsonProperty("Details")]
        Details = 2,
        
        [JsonProperty("DetailsWithVertices")]
        DetailsWithVertices = 3,
        
        [JsonProperty("Lines")]
        Lines = 4,
        
        [JsonProperty("Vertices")]
        Vertices = 5,
        
        [JsonProperty("ViewFactorInfo")]
        ViewFactorInfo = 6,
    }
}