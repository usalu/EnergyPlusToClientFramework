using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.FluidProperties
{
    public enum FluidProperties_Superheated_FluidPropertyType
    {
        
        [JsonProperty("Density")]
        Density = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
    }
}