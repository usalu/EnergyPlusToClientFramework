using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_Chiller_ChillerType
    {
        
        [JsonProperty("DistrictChilledWater")]
        DistrictChilledWater = 0,
        
        [JsonProperty("ElectricCentrifugalChiller")]
        ElectricCentrifugalChiller = 1,
        
        [JsonProperty("ElectricReciprocatingChiller")]
        ElectricReciprocatingChiller = 2,
        
        [JsonProperty("ElectricScrewChiller")]
        ElectricScrewChiller = 3,
    }
}