using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_UnitHeater_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:Electric")]
        CoilHeatingElectric = 0,
        
        [JsonProperty("Coil:Heating:Fuel")]
        CoilHeatingFuel = 1,
        
        [JsonProperty("Coil:Heating:Steam")]
        CoilHeatingSteam = 2,
        
        [JsonProperty("Coil:Heating:Water")]
        CoilHeatingWater = 3,
    }
}