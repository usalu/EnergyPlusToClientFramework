using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowsCalculationEngine_WindowsEngine
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BuiltInWindowsModel")]
        BuiltInWindowsModel = 1,
        
        [JsonProperty("ExternalWindowsModel")]
        ExternalWindowsModel = 2,
    }
}