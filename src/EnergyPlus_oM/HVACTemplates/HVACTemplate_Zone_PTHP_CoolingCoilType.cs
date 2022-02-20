using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_PTHP_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SingleSpeedDX")]
        SingleSpeedDX = 1,
    }
}