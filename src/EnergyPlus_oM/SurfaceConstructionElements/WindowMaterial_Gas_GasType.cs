using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_Gas_GasType
    {
        
        [JsonProperty("Air")]
        Air = 0,
        
        [JsonProperty("Argon")]
        Argon = 1,
        
        [JsonProperty("Custom")]
        Custom = 2,
        
        [JsonProperty("Krypton")]
        Krypton = 3,
        
        [JsonProperty("Xenon")]
        Xenon = 4,
    }
}