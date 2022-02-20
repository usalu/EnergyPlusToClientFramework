using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterTemperatureControlType
    {
        
        [JsonProperty("OutdoorWetBulbTemperature")]
        OutdoorWetBulbTemperature = 0,
        
        [JsonProperty("SpecifiedSetpoint")]
        SpecifiedSetpoint = 1,
    }
}