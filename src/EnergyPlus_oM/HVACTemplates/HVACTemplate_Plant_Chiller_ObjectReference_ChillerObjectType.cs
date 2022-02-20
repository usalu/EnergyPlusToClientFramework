using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_Chiller_ObjectReference_ChillerObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Chiller:Electric:EIR")]
        ChillerElectricEIR = 1,
        
        [JsonProperty("Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 2,
    }
}