namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitarySystem_CoolingCoilType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ChilledWater")]
        ChilledWater = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchangerAssistedChilledWater")]
        HeatExchangerAssistedChilledWater = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchangerAssistedDX")]
        HeatExchangerAssistedDX = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="MultiSpeedDX")]
        MultiSpeedDX = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="SingleSpeedDX")]
        SingleSpeedDX = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="SingleSpeedDXWaterCooled")]
        SingleSpeedDXWaterCooled = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="TwoSpeedDX")]
        TwoSpeedDX = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="TwoStageDX")]
        TwoStageDX = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="TwoStageHumidityControlDX")]
        TwoStageHumidityControlDX = 11,
    }
}