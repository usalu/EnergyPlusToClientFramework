using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    public enum PipingSystem_Underground_PipeSegment_FlowDirection
    {
        
        [JsonProperty("DecreasingZ")]
        DecreasingZ = 0,
        
        [JsonProperty("IncreasingZ")]
        IncreasingZ = 1,
    }
}