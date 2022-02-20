using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitarySystem_ControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Load")]
        Load = 1,
        
        [JsonProperty("SetPoint")]
        SetPoint = 2,
    }
}