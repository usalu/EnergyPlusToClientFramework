using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum ThermalStorage_ChilledWater_Stratified_TankShape
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("HorizontalCylinder")]
        HorizontalCylinder = 1,
        
        [JsonProperty("Other")]
        Other = 2,
        
        [JsonProperty("VerticalCylinder")]
        VerticalCylinder = 3,
    }
}