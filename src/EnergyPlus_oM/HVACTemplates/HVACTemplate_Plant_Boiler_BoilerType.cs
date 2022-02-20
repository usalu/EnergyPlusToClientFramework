using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_Boiler_BoilerType
    {
        
        [JsonProperty("CondensingHotWaterBoiler")]
        CondensingHotWaterBoiler = 0,
        
        [JsonProperty("DistrictHotWater")]
        DistrictHotWater = 1,
        
        [JsonProperty("HotWaterBoiler")]
        HotWaterBoiler = 2,
    }
}