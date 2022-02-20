using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.FluidProperties
{
    public enum FluidProperties_Name_FluidType
    {
        
        [JsonProperty("Glycol")]
        Glycol = 0,
        
        [JsonProperty("Refrigerant")]
        Refrigerant = 1,
    }
}