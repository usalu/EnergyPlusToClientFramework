using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_Boiler_ObjectReference_BoilerObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Boiler:HotWater")]
        BoilerHotWater = 1,
    }
}