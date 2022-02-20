using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Cooling_DX_SingleSpeed_ThermalStorage_StorageType
    {
        
        [JsonProperty("Ice")]
        Ice = 0,
        
        [JsonProperty("UserDefinedFluidType")]
        UserDefinedFluidType = 1,
        
        [JsonProperty("Water")]
        Water = 2,
    }
}