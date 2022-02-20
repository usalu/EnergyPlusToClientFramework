using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_IdealLoadsAirSystem_HumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantSupplyHumidityRatio")]
        ConstantSupplyHumidityRatio = 1,
        
        [JsonProperty("Humidistat")]
        Humidistat = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
}