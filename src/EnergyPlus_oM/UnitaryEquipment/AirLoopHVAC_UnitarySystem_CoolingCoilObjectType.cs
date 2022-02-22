namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    public enum AirLoopHVAC_UnitarySystem_CoolingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX")]
        CoilCoolingDX = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:MultiSpeed")]
        CoilCoolingDXMultiSpeed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:SingleSpeed:ThermalStorage")]
        CoilCoolingDXSingleSpeedThermalStorage = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water")]
        CoilCoolingWater = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:WaterToAirHeatPump:EquationFit")]
        CoilCoolingWaterToAirHeatPumpEquationFit = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:WaterToAirHeatPump:ParameterEstimation")]
        CoilCoolingWaterToAirHeatPumpParameterEstimation = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit")]
        CoilCoolingWaterToAirHeatPumpVariableSpeedEquationFit = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:UserDefined")]
        CoilUserDefined = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:Cooling:DX:HeatExchangerAssisted")]
        CoilSystemCoolingDXHeatExchangerAssisted = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:Cooling:Water:HeatExchangerAssisted")]
        CoilSystemCoolingWaterHeatExchangerAssisted = 14,
    }
}