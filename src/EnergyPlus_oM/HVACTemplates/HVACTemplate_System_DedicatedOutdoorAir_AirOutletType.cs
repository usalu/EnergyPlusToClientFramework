using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DedicatedOutdoorAir_AirOutletType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DirectIntoZone")]
        DirectIntoZone = 1,
    }
}