using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_MultiZone_Zone_SingleSidedWindPressureCoefficientAlgorithm
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Advanced")]
        Advanced = 1,
        
        [JsonProperty("Standard")]
        Standard = 2,
    }
}