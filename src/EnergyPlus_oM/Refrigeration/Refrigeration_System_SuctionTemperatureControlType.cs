using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_System_SuctionTemperatureControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantSuctionTemperature")]
        ConstantSuctionTemperature = 1,
        
        [JsonProperty("FloatSuctionTemperature")]
        FloatSuctionTemperature = 2,
    }
}