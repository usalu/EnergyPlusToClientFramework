using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    public enum PlantLoop_PlantLoopDemandCalculationScheme
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DualSetpointDeadband")]
        DualSetpointDeadband = 1,
        
        [JsonProperty("SingleSetpoint")]
        SingleSetpoint = 2,
    }
}