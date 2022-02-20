using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    public enum Dehumidifier_Desiccant_System_DesiccantHeatExchangerObjectType
    {
        
        [JsonProperty("HeatExchanger:Desiccant:BalancedFlow")]
        HeatExchangerDesiccantBalancedFlow = 0,
    }
}