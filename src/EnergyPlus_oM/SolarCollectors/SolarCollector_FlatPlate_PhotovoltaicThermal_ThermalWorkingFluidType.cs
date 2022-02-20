using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    public enum SolarCollector_FlatPlate_PhotovoltaicThermal_ThermalWorkingFluidType
    {
        
        [JsonProperty("Air")]
        Air = 0,
        
        [JsonProperty("Water")]
        Water = 1,
    }
}