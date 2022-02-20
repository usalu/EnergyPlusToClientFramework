using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_SimulationControl_AirflownetworkControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MultizoneWithDistribution")]
        MultizoneWithDistribution = 1,
        
        [JsonProperty("MultizoneWithDistributionOnlyDuringFanOperation")]
        MultizoneWithDistributionOnlyDuringFanOperation = 2,
        
        [JsonProperty("MultizoneWithoutDistribution")]
        MultizoneWithoutDistribution = 3,
        
        [JsonProperty("NoMultizoneOrDistribution")]
        NoMultizoneOrDistribution = 4,
    }
}