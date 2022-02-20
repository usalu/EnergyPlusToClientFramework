using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPumpConfiguration
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantPrimaryNoSecondary")]
        ConstantPrimaryNoSecondary = 1,
        
        [JsonProperty("ConstantPrimaryVariableSecondary")]
        ConstantPrimaryVariableSecondary = 2,
        
        [JsonProperty("VariablePrimaryNoSecondary")]
        VariablePrimaryNoSecondary = 3,
    }
}