using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    public enum Humidifier_Steam_Gas_InletWaterTemperatureOption
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedInletWaterTemperature")]
        FixedInletWaterTemperature = 1,
        
        [JsonProperty("VariableInletWaterTemperature")]
        VariableInletWaterTemperature = 2,
    }
}