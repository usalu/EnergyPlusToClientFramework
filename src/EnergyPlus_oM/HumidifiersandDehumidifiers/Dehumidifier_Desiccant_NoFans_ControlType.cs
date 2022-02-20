using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    public enum Dehumidifier_Desiccant_NoFans_ControlType
    {
        
        [JsonProperty("LeavingMaximumHumidityRatioSetpoint")]
        LeavingMaximumHumidityRatioSetpoint = 0,
        
        [JsonProperty("SystemNodeMaximumHumidityRatioSetpoint")]
        SystemNodeMaximumHumidityRatioSetpoint = 1,
    }
}