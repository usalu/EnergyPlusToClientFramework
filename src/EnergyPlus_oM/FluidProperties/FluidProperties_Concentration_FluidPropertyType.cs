using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.FluidProperties
{
    public enum FluidProperties_Concentration_FluidPropertyType
    {
        
        [JsonProperty("Conductivity")]
        Conductivity = 0,
        
        [JsonProperty("Density")]
        Density = 1,
        
        [JsonProperty("SpecificHeat")]
        SpecificHeat = 2,
        
        [JsonProperty("Viscosity")]
        Viscosity = 3,
    }
}