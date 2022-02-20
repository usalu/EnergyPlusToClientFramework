using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_MultiZone_ExternalNode_WindAngleType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Absolute")]
        Absolute = 1,
        
        [JsonProperty("Relative")]
        Relative = 2,
    }
}