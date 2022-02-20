using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    public enum PlantLoop_FluidType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Steam")]
        Steam = 1,
        
        [JsonProperty("UserDefinedFluidType")]
        UserDefinedFluidType = 2,
        
        [JsonProperty("Water")]
        Water = 3,
    }
}