using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_UnitHeater_SupplyAirFanOperationDuringNoHeating
    {
        
        [JsonProperty("No")]
        No = 0,
        
        [JsonProperty("Yes")]
        Yes = 1,
    }
}