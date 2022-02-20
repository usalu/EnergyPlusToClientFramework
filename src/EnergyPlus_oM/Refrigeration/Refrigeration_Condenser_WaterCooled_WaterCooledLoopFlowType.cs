using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_Condenser_WaterCooled_WaterCooledLoopFlowType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantFlow")]
        ConstantFlow = 1,
        
        [JsonProperty("VariableFlow")]
        VariableFlow = 2,
    }
}