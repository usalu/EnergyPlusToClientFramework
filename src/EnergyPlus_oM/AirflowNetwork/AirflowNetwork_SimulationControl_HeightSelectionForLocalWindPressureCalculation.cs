using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_SimulationControl_HeightSelectionForLocalWindPressureCalculation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ExternalNode")]
        ExternalNode = 1,
        
        [JsonProperty("OpeningHeight")]
        OpeningHeight = 2,
    }
}