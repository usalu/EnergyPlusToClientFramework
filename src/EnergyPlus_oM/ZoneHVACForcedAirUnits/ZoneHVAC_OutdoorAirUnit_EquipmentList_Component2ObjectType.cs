namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_OutdoorAirUnit_EquipmentList_Component2ObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AirLoopHVAC:UnitarySystem")]
        AirLoopHVACUnitarySystem = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water")]
        CoilCoolingWater = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Electric")]
        CoilHeatingElectric = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Fuel")]
        CoilHeatingFuel = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Steam")]
        CoilHeatingSteam = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Heating:Water")]
        CoilHeatingWater = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:Cooling:DX")]
        CoilSystemCoolingDX = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:Cooling:Water:HeatexchangerAssisted")]
        CoilSystemCoolingWaterHeatexchangerAssisted = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:Heating:DX")]
        CoilSystemHeatingDX = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Dehumidifier:Desiccant:NoFans")]
        DehumidifierDesiccantNoFans = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchanger:AirToAir:FlatPlate")]
        HeatExchangerAirToAirFlatPlate = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchanger:AirToAir:SensibleAndLatent")]
        HeatExchangerAirToAirSensibleAndLatent = 12,
    }
}