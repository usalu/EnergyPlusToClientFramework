using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum LifeCycleCost_RecurringCosts_StartOfCosts
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BasePeriod")]
        BasePeriod = 1,
        
        [JsonProperty("ServicePeriod")]
        ServicePeriod = 2,
    }
}