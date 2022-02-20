using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 1,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 2,
        
        [JsonProperty("CoilSystem:Cooling:DX:HeatExchangerAssisted")]
        CoilSystemCoolingDXHeatExchangerAssisted = 3,
    }
}