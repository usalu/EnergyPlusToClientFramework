using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_GasCooler_AirCooled_GasCoolerFanSpeedControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Fixed")]
        Fixed = 1,
        
        [JsonProperty("FixedLinear")]
        FixedLinear = 2,
        
        [JsonProperty("TwoSpeed")]
        TwoSpeed = 3,
        
        [JsonProperty("VariableSpeed")]
        VariableSpeed = 4,
    }
}