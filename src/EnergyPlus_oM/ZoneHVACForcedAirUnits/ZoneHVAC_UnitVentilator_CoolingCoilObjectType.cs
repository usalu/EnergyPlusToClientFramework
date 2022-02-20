using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_UnitVentilator_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:Water")]
        CoilCoolingWater = 0,
        
        [JsonProperty("Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 1,
        
        [JsonProperty("CoilSystem:Cooling:Water:HeatExchangerAssisted")]
        CoilSystemCoolingWaterHeatExchangerAssisted = 2,
    }
}