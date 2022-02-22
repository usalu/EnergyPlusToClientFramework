namespace BH.oM.Adapters.EnergyPlus.Coils
{
    public enum CoilSystem_Cooling_DX_CoolingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:SingleSpeed:ThermalStorage")]
        CoilCoolingDXSingleSpeedThermalStorage = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:Cooling:DX:HeatExchangerAssisted")]
        CoilSystemCoolingDXHeatExchangerAssisted = 5,
    }
}