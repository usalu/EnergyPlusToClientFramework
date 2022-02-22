namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_UnitVentilator_CoolingCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water")]
        CoilCoolingWater = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:Cooling:Water:HeatExchangerAssisted")]
        CoilSystemCoolingWaterHeatExchangerAssisted = 2,
    }
}