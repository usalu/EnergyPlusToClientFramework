using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    public enum DemandManagerAssignmentList_DemandManagerPriority
    {
        
        [JsonProperty("All")]
        All = 0,
        
        [JsonProperty("Sequential")]
        Sequential = 1,
    }
}