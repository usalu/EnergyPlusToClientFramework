using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ZoneAirMassFlowConservation_InfiltrationBalancingMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AddInfiltrationFlow")]
        AddInfiltrationFlow = 1,
        
        [JsonProperty("AdjustInfiltrationFlow")]
        AdjustInfiltrationFlow = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
}