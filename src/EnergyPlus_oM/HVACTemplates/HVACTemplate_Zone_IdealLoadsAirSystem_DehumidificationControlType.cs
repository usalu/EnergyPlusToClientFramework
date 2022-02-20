using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantSensibleHeatRatio")]
        ConstantSensibleHeatRatio = 1,
        
        [JsonProperty("ConstantSupplyHumidityRatio")]
        ConstantSupplyHumidityRatio = 2,
        
        [JsonProperty("Humidistat")]
        Humidistat = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
}