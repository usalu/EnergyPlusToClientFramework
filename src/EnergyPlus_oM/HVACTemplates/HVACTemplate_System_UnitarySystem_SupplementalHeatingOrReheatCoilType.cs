using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitarySystem_SupplementalHeatingOrReheatCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DesuperHeater")]
        DesuperHeater = 1,
        
        [JsonProperty("Electric")]
        Electric = 2,
        
        [JsonProperty("Gas")]
        Gas = 3,
        
        [JsonProperty("HotWater")]
        HotWater = 4,
        
        [JsonProperty("None")]
        None = 5,
    }
}