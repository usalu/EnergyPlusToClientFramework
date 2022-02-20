using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_HotWaterLoop_HotWaterPlantOperationSchemeType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Default")]
        Default = 1,
        
        [JsonProperty("UserDefined")]
        UserDefined = 2,
    }
}