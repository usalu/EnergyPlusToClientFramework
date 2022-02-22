namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    public enum WaterHeater_HeatPump_PumpedCondenser_InletAirConfiguration
    {
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAirOnly")]
        OutdoorAirOnly = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAirOnly")]
        ZoneAirOnly = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAndOutdoorAir")]
        ZoneAndOutdoorAir = 3,
    }
}