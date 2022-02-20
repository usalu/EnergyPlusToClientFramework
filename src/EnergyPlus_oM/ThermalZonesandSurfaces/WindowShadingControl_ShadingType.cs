using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum WindowShadingControl_ShadingType
    {
        
        [JsonProperty("BetweenGlassBlind")]
        BetweenGlassBlind = 0,
        
        [JsonProperty("BetweenGlassShade")]
        BetweenGlassShade = 1,
        
        [JsonProperty("ExteriorBlind")]
        ExteriorBlind = 2,
        
        [JsonProperty("ExteriorScreen")]
        ExteriorScreen = 3,
        
        [JsonProperty("ExteriorShade")]
        ExteriorShade = 4,
        
        [JsonProperty("InteriorBlind")]
        InteriorBlind = 5,
        
        [JsonProperty("InteriorShade")]
        InteriorShade = 6,
        
        [JsonProperty("SwitchableGlazing")]
        SwitchableGlazing = 7,
    }
}