using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_Unitary_HeatingCoilType
    {
        
        [JsonProperty("Electric")]
        Electric = 0,
        
        [JsonProperty("Gas")]
        Gas = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
    }
}