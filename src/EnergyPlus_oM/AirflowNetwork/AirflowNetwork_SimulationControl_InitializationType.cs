using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_SimulationControl_InitializationType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LinearInitializationMethod")]
        LinearInitializationMethod = 1,
        
        [JsonProperty("ZeroNodePressures")]
        ZeroNodePressures = 2,
    }
}