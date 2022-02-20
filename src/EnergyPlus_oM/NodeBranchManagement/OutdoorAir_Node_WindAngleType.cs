using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    public enum OutdoorAir_Node_WindAngleType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Absolute")]
        Absolute = 1,
        
        [JsonProperty("Relative")]
        Relative = 2,
    }
}