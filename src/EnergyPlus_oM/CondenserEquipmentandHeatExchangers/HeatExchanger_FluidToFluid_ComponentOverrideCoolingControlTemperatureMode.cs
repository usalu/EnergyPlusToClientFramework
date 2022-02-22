namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    public enum HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DryBulbTemperature")]
        DryBulbTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Loop")]
        Loop = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="WetBulbTemperature")]
        WetBulbTemperature = 3,
    }
}