using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_Gap_EquivalentLayer_GapVentType
    {
        
        [JsonProperty("Sealed")]
        Sealed = 0,
        
        [JsonProperty("VentedIndoor")]
        VentedIndoor = 1,
        
        [JsonProperty("VentedOutdoor")]
        VentedOutdoor = 2,
    }
}