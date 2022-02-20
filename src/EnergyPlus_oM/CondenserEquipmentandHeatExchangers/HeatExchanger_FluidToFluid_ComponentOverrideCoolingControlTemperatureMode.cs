using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DryBulbTemperature")]
        DryBulbTemperature = 1,
        
        [JsonProperty("Loop")]
        Loop = 2,
        
        [JsonProperty("WetBulbTemperature")]
        WetBulbTemperature = 3,
    }
}