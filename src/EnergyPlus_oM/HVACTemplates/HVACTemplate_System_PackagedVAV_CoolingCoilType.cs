using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_PackagedVAV_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("TwoSpeedDX")]
        TwoSpeedDX = 1,
        
        [JsonProperty("TwoSpeedHumidControlDX")]
        TwoSpeedHumidControlDX = 2,
    }
}