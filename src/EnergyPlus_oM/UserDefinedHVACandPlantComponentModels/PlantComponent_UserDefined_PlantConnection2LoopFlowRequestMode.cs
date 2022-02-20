using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    public enum PlantComponent_UserDefined_PlantConnection2LoopFlowRequestMode
    {
        
        [JsonProperty("NeedsFlowAndTurnsLoopOn")]
        NeedsFlowAndTurnsLoopOn = 0,
        
        [JsonProperty("NeedsFlowIfLoopOn")]
        NeedsFlowIfLoopOn = 1,
        
        [JsonProperty("ReceivesWhateverFlowAvailable")]
        ReceivesWhateverFlowAvailable = 2,
    }
}