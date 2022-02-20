using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HeatRecovery
{
    public enum HeatExchanger_AirToAir_FlatPlate_FlowArrangementType
    {
        
        [JsonProperty("CounterFlow")]
        CounterFlow = 0,
        
        [JsonProperty("CrossFlowBothUnmixed")]
        CrossFlowBothUnmixed = 1,
        
        [JsonProperty("ParallelFlow")]
        ParallelFlow = 2,
    }
}