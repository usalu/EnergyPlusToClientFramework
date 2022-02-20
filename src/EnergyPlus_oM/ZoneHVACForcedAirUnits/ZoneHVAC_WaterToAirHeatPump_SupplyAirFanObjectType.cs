using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_WaterToAirHeatPump_SupplyAirFanObjectType
    {
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 0,
        
        [JsonProperty("Fan:SystemModel")]
        FanSystemModel = 1,
    }
}