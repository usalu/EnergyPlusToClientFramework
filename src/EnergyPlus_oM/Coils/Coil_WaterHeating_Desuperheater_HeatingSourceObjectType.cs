namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_WaterHeating_Desuperheater_HeatingSourceObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:MultiSpeed")]
        CoilCoolingDXMultiSpeed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:WaterToAirHeatPump:EquationFit")]
        CoilCoolingWaterToAirHeatPumpEquationFit = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Refrigeration:CompressorRack")]
        RefrigerationCompressorRack = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Refrigeration:Condenser:AirCooled")]
        RefrigerationCondenserAirCooled = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Refrigeration:Condenser:EvaporativeCooled")]
        RefrigerationCondenserEvaporativeCooled = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Refrigeration:Condenser:WaterCooled")]
        RefrigerationCondenserWaterCooled = 9,
    }
}