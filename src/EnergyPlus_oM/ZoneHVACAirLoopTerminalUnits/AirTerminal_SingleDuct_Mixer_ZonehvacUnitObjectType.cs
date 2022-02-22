namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    public enum AirTerminal_SingleDuct_Mixer_ZonehvacUnitObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AirLoopHVAC:UnitarySystem")]
        AirLoopHVACUnitarySystem = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:FourPipeFanCoil")]
        ZoneHVACFourPipeFanCoil = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:PackagedTerminalAirConditioner")]
        ZoneHVACPackagedTerminalAirConditioner = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:PackagedTerminalHeatPump")]
        ZoneHVACPackagedTerminalHeatPump = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:TerminalUnit:VariableRefrigerantFlow")]
        ZoneHVACTerminalUnitVariableRefrigerantFlow = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:UnitVentilator")]
        ZoneHVACUnitVentilator = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneHVAC:WaterToAirHeatPump")]
        ZoneHVACWaterToAirHeatPump = 6,
    }
}