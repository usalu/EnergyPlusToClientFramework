namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    public enum AirflowNetwork_Distribution_Component_Coil_CoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX")]
        CoilCoolingDX = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:MultiSpeed")]
        CoilCoolingDXMultiSpeed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water")]
        CoilCoolingWater = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:DX:MultiSpeed")]
        CoilHeatingDXMultiSpeed = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Electric")]
        CoilHeatingElectric = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Fuel")]
        CoilHeatingFuel = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Water")]
        CoilHeatingWater = 12,
    }
}