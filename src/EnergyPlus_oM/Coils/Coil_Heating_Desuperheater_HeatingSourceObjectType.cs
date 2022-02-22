namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum Coil_Heating_Desuperheater_HeatingSourceObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Refrigeration:CompressorRack")]
        RefrigerationCompressorRack = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Refrigeration:Condenser:AirCooled")]
        RefrigerationCondenserAirCooled = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Refrigeration:Condenser:EvaporativeCooled")]
        RefrigerationCondenserEvaporativeCooled = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Refrigeration:Condenser:WaterCooled")]
        RefrigerationCondenserWaterCooled = 7,
    }
}