namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum WindowShadingControl_ShadingControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="AlwaysOff")]
        AlwaysOff = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AlwaysOn")]
        AlwaysOn = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetDaylightIlluminanceSetpoint")]
        MeetDaylightIlluminanceSetpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OffNightAndOnDayIfCoolingAndHighSolarOnWindow")]
        OffNightAndOnDayIfCoolingAndHighSolarOnWindow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighGlare")]
        OnIfHighGlare = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighHorizontalSolar")]
        OnIfHighHorizontalSolar = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighOutdoorAirTempAndHighHorizontalSolar")]
        OnIfHighOutdoorAirTempAndHighHorizontalSolar = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighOutdoorAirTempAndHighSolarOnWindow")]
        OnIfHighOutdoorAirTempAndHighSolarOnWindow = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighOutdoorAirTemperature")]
        OnIfHighOutdoorAirTemperature = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighSolarOnWindow")]
        OnIfHighSolarOnWindow = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighZoneAirTempAndHighHorizontalSolar")]
        OnIfHighZoneAirTempAndHighHorizontalSolar = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighZoneAirTempAndHighSolarOnWindow")]
        OnIfHighZoneAirTempAndHighSolarOnWindow = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighZoneAirTemperature")]
        OnIfHighZoneAirTemperature = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfHighZoneCooling")]
        OnIfHighZoneCooling = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="OnIfScheduleAllows")]
        OnIfScheduleAllows = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightAndOnDayIfCoolingAndHighSolarOnWindow")]
        OnNightAndOnDayIfCoolingAndHighSolarOnWindow = 15,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightIfHeatingAndOffDay")]
        OnNightIfHeatingAndOffDay = 16,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightIfHeatingAndOnDayIfCooling")]
        OnNightIfHeatingAndOnDayIfCooling = 17,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightIfLowInsideTempAndOffDay")]
        OnNightIfLowInsideTempAndOffDay = 18,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightIfLowOutdoorTempAndOffDay")]
        OnNightIfLowOutdoorTempAndOffDay = 19,
        
        [System.Runtime.Serialization.EnumMember(Value="OnNightIfLowOutdoorTempAndOnDayIfCooling")]
        OnNightIfLowOutdoorTempAndOnDayIfCooling = 20,
    }
}