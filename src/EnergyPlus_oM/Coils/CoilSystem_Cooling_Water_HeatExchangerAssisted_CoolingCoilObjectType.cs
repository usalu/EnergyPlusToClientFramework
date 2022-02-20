using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum CoilSystem_Cooling_Water_HeatExchangerAssisted_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:Water")]
        CoilCoolingWater = 0,
        
        [JsonProperty("Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 1,
    }
}