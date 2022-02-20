using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_SimulationControl_BuildingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("HighRise")]
        HighRise = 1,
        
        [JsonProperty("LowRise")]
        LowRise = 2,
    }
}