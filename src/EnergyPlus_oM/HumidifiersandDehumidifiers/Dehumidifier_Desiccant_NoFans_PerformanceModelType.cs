using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    public enum Dehumidifier_Desiccant_NoFans_PerformanceModelType
    {
        
        [JsonProperty("Default")]
        Default = 0,
        
        [JsonProperty("UserCurves")]
        UserCurves = 1,
    }
}