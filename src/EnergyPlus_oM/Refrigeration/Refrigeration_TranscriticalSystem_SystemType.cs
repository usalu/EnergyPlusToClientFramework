using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_TranscriticalSystem_SystemType
    {
        
        [JsonProperty("SingleStage")]
        SingleStage = 0,
        
        [JsonProperty("TwoStage")]
        TwoStage = 1,
    }
}