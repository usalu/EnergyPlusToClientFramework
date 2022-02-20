using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_Unitary_Furnace_HeatCool_SupplyFanObjectType
    {
        
        [JsonProperty("Fan:ConstantVolume")]
        FanConstantVolume = 0,
        
        [JsonProperty("Fan:OnOff")]
        FanOnOff = 1,
    }
}