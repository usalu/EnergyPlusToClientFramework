namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_UnitarySystem_HeatingCoilType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Electric")]
        Electric = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Gas")]
        Gas = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HotWater")]
        HotWater = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MultiSpeedDXHeatPumpAirSource")]
        MultiSpeedDXHeatPumpAirSource = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="MultiStageElectric")]
        MultiStageElectric = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="MultiStageGas")]
        MultiStageGas = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="SingleSpeedDXHeatPumpAirSource")]
        SingleSpeedDXHeatPumpAirSource = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="SingleSpeedDXHeatPumpWaterSource")]
        SingleSpeedDXHeatPumpWaterSource = 9,
    }
}