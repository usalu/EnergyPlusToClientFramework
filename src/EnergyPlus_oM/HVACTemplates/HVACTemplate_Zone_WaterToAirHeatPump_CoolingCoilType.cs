using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_WaterToAirHeatPump_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:EquationFit")]
        CoilCoolingWaterToAirHeatPumpEquationFit = 1,
    }
}