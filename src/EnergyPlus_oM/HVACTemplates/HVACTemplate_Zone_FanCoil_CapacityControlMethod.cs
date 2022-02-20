using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_FanCoil_CapacityControlMethod
    {
        
        [JsonProperty("ASHRAE90VariableFan")]
        ASHRAE90VariableFan = 0,
        
        [JsonProperty("ConstantFanVariableFlow")]
        ConstantFanVariableFlow = 1,
        
        [JsonProperty("CyclingFan")]
        CyclingFan = 2,
        
        [JsonProperty("MultiSpeedFan")]
        MultiSpeedFan = 3,
        
        [JsonProperty("VariableFanConstantFlow")]
        VariableFanConstantFlow = 4,
        
        [JsonProperty("VariableFanVariableFlow")]
        VariableFanVariableFlow = 5,
    }
}