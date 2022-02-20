using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_MixedWaterLoop_OperationSchemeType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Default")]
        Default = 1,
        
        [JsonProperty("UserDefined")]
        UserDefined = 2,
    }
}