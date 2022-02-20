using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    public enum CondenserLoop_PressureSimulationType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LoopFlowCorrection")]
        LoopFlowCorrection = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("PumpPowerCorrection")]
        PumpPowerCorrection = 3,
    }
}