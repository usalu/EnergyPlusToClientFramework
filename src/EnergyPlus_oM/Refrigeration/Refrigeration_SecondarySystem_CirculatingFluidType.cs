using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_SecondarySystem_CirculatingFluidType
    {
        
        [JsonProperty("FluidAlwaysLiquid")]
        FluidAlwaysLiquid = 0,
        
        [JsonProperty("FluidPhaseChange")]
        FluidPhaseChange = 1,
    }
}