using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("ConstantOnDemand")]
        ConstantOnDemand = 2,
        
        [JsonProperty("Cycling")]
        Cycling = 3,
    }
}