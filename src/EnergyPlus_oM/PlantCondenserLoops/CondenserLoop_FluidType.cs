using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    public enum CondenserLoop_FluidType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("UserDefinedFluidType")]
        UserDefinedFluidType = 1,
        
        [JsonProperty("Water")]
        Water = 2,
    }
}