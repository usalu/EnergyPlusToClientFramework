using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HeatRecovery
{
    public enum HeatExchanger_AirToAir_SensibleAndLatent_HeatExchangerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Plate")]
        Plate = 1,
        
        [JsonProperty("Rotary")]
        Rotary = 2,
    }
}