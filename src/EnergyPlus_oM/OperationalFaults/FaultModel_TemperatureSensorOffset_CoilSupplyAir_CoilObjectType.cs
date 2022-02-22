namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    public enum FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AirLoopHVAC:UnitarySystem")]
        AirLoopHVACUnitarySystem = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water")]
        CoilCoolingWater = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water:Detailedgeometry")]
        CoilCoolingWaterDetailedgeometry = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Desuperheater")]
        CoilHeatingDesuperheater = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Electric")]
        CoilHeatingElectric = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Gas")]
        CoilHeatingGas = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Steam")]
        CoilHeatingSteam = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Water")]
        CoilHeatingWater = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:Cooling:DX")]
        CoilSystemCoolingDX = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:Heating:DX")]
        CoilSystemHeatingDX = 9,
    }
}