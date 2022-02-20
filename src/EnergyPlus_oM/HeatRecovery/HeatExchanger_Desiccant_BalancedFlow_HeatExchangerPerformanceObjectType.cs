using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HeatRecovery
{
    public enum HeatExchanger_Desiccant_BalancedFlow_HeatExchangerPerformanceObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("HeatExchanger:Desiccant:BalancedFlow:PerformanceDataType1")]
        HeatExchangerDesiccantBalancedFlowPerformanceDataType1 = 1,
    }
}