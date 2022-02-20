using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    public enum WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DoNotModel")]
        DoNotModel = 1,
        
        [JsonProperty("ModelAsDiffuse")]
        ModelAsDiffuse = 2,
        
        [JsonProperty("ModelAsDirectBeam")]
        ModelAsDirectBeam = 3,
    }
}