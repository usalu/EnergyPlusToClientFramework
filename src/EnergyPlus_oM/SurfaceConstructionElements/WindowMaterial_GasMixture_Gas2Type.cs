using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_GasMixture_Gas2Type
    {
        
        [JsonProperty("Air")]
        Air = 0,
        
        [JsonProperty("Argon")]
        Argon = 1,
        
        [JsonProperty("Krypton")]
        Krypton = 2,
        
        [JsonProperty("Xenon")]
        Xenon = 3,
    }
}