using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.FluidProperties
{
    public enum FluidProperties_Saturated_FluidPhase
    {
        
        [JsonProperty("Fluid")]
        Fluid = 0,
        
        [JsonProperty("FluidGas")]
        FluidGas = 1,
    }
}