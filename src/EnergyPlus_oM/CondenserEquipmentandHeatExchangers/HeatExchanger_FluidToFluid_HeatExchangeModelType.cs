using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum HeatExchanger_FluidToFluid_HeatExchangeModelType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CounterFlow")]
        CounterFlow = 1,
        
        [JsonProperty("CrossFlowBothMixed")]
        CrossFlowBothMixed = 2,
        
        [JsonProperty("CrossFlowBothUnMixed")]
        CrossFlowBothUnMixed = 3,
        
        [JsonProperty("CrossFlowSupplyMixedDemandUnMixed")]
        CrossFlowSupplyMixedDemandUnMixed = 4,
        
        [JsonProperty("CrossFlowSupplyUnMixedDemandMixed")]
        CrossFlowSupplyUnMixedDemandMixed = 5,
        
        [JsonProperty("Ideal")]
        Ideal = 6,
        
        [JsonProperty("ParallelFlow")]
        ParallelFlow = 7,
    }
}