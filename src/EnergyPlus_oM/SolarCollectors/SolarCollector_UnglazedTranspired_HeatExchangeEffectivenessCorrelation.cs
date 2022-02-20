using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    public enum SolarCollector_UnglazedTranspired_HeatExchangeEffectivenessCorrelation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Kutscher1994")]
        Kutscher1994 = 1,
        
        [JsonProperty("VanDeckerHollandsBrunger2001")]
        VanDeckerHollandsBrunger2001 = 2,
    }
}