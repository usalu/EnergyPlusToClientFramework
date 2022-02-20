using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowThermalModel_Params_Standard
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("EN673Declared")]
        EN673Declared = 1,
        
        [JsonProperty("EN673Design")]
        EN673Design = 2,
        
        [JsonProperty("ISO15099")]
        ISO15099 = 3,
    }
}