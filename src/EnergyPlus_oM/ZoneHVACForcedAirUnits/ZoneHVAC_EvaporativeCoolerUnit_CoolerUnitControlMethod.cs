using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_EvaporativeCoolerUnit_CoolerUnitControlMethod
    {
        
        [JsonProperty("ZoneCoolingLoadOnOffCycling")]
        ZoneCoolingLoadOnOffCycling = 0,
        
        [JsonProperty("ZoneCoolingLoadVariableSpeedFan")]
        ZoneCoolingLoadVariableSpeedFan = 1,
        
        [JsonProperty("ZoneTemperatureDeadbandOnOffCycling")]
        ZoneTemperatureDeadbandOnOffCycling = 2,
    }
}