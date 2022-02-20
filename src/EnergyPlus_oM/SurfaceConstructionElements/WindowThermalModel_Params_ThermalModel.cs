using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowThermalModel_Params_ThermalModel
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConvectiveScalarModel_NoSDThickness")]
        ConvectiveScalarModelNoSDThickness = 1,
        
        [JsonProperty("ConvectiveScalarModel_withSDThickness")]
        ConvectiveScalarModelWithSDThickness = 2,
        
        [JsonProperty("ISO15099")]
        ISO15099 = 3,
        
        [JsonProperty("ScaledCavityWidth")]
        ScaledCavityWidth = 4,
    }
}