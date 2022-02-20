using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ZoneAirMassFlowConservation_AdjustZoneMixingAndReturnForAirMassFlowBalance
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AdjustMixingOnly")]
        AdjustMixingOnly = 1,
        
        [JsonProperty("AdjustMixingThenReturn")]
        AdjustMixingThenReturn = 2,
        
        [JsonProperty("AdjustReturnOnly")]
        AdjustReturnOnly = 3,
        
        [JsonProperty("AdjustReturnThenMixing")]
        AdjustReturnThenMixing = 4,
        
        [JsonProperty("None")]
        None = 5,
    }
}