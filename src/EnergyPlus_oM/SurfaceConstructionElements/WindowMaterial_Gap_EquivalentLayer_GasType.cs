using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_Gap_EquivalentLayer_GasType
    {
        
        [JsonProperty("AIR")]
        AIR = 0,
        
        [JsonProperty("ARGON")]
        ARGON = 1,
        
        [JsonProperty("CUSTOM")]
        CUSTOM = 2,
        
        [JsonProperty("KRYPTON")]
        KRYPTON = 3,
        
        [JsonProperty("XENON")]
        XENON = 4,
    }
}