using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX")]
        CoilCoolingDX = 0,
        
        [JsonProperty("Coil:Cooling:DX:MultiSpeed")]
        CoilCoolingDXMultiSpeed = 1,
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 2,
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed:ThermalStorage")]
        CoilCoolingDXSingleSpeedThermalStorage = 3,
        
        [JsonProperty("Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 4,
        
        [JsonProperty("Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 5,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 6,
        
        [JsonProperty("Coil:Cooling:Water")]
        CoilCoolingWater = 7,
        
        [JsonProperty("Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 8,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:EquationFit")]
        CoilCoolingWaterToAirHeatPumpEquationFit = 9,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:ParameterEstimation")]
        CoilCoolingWaterToAirHeatPumpParameterEstimation = 10,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit")]
        CoilCoolingWaterToAirHeatPumpVariableSpeedEquationFit = 11,
        
        [JsonProperty("Coil:UserDefined")]
        CoilUserDefined = 12,
        
        [JsonProperty("CoilSystem:Cooling:DX:HeatExchangerAssisted")]
        CoilSystemCoolingDXHeatExchangerAssisted = 13,
        
        [JsonProperty("CoilSystem:Cooling:Water:HeatExchangerAssisted")]
        CoilSystemCoolingWaterHeatExchangerAssisted = 14,
    }
}