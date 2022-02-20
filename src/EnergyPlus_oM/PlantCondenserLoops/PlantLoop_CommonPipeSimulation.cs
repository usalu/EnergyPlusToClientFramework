using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    public enum PlantLoop_CommonPipeSimulation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CommonPipe")]
        CommonPipe = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("TwoWayCommonPipe")]
        TwoWayCommonPipe = 3,
    }
}