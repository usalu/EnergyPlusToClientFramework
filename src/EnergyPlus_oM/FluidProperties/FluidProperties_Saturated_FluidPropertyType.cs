using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.FluidProperties
{
    public enum FluidProperties_Saturated_FluidPropertyType
    {
        
        [JsonProperty("Density")]
        Density = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
        
        [JsonProperty("Pressure")]
        Pressure = 2,
        
        [JsonProperty("SpecificHeat")]
        SpecificHeat = 3,
    }
}