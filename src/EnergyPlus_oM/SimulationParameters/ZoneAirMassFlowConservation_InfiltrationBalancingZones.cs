using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum ZoneAirMassFlowConservation_InfiltrationBalancingZones
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AllZones")]
        AllZones = 1,
        
        [JsonProperty("MixingSourceZonesOnly")]
        MixingSourceZonesOnly = 2,
    }
}