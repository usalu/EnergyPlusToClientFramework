using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Distribution_ElectricalBussType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AlternatingCurrent")]
        AlternatingCurrent = 1,
        
        [JsonProperty("AlternatingCurrentWithStorage")]
        AlternatingCurrentWithStorage = 2,
        
        [JsonProperty("DirectCurrentWithInverter")]
        DirectCurrentWithInverter = 3,
        
        [JsonProperty("DirectCurrentWithInverterACStorage")]
        DirectCurrentWithInverterACStorage = 4,
        
        [JsonProperty("DirectCurrentWithInverterDCStorage")]
        DirectCurrentWithInverterDCStorage = 5,
    }
}