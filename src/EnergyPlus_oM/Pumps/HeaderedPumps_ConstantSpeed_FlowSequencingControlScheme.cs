using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Pumps
{
    public enum HeaderedPumps_ConstantSpeed_FlowSequencingControlScheme
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Sequential")]
        Sequential = 1,
    }
}