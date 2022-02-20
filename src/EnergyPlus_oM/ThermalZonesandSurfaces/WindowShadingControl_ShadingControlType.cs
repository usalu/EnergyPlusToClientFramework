using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum WindowShadingControl_ShadingControlType
    {
        
        [JsonProperty("AlwaysOff")]
        AlwaysOff = 0,
        
        [JsonProperty("AlwaysOn")]
        AlwaysOn = 1,
        
        [JsonProperty("MeetDaylightIlluminanceSetpoint")]
        MeetDaylightIlluminanceSetpoint = 2,
        
        [JsonProperty("OffNightAndOnDayIfCoolingAndHighSolarOnWindow")]
        OffNightAndOnDayIfCoolingAndHighSolarOnWindow = 3,
        
        [JsonProperty("OnIfHighGlare")]
        OnIfHighGlare = 4,
        
        [JsonProperty("OnIfHighHorizontalSolar")]
        OnIfHighHorizontalSolar = 5,
        
        [JsonProperty("OnIfHighOutdoorAirTempAndHighHorizontalSolar")]
        OnIfHighOutdoorAirTempAndHighHorizontalSolar = 6,
        
        [JsonProperty("OnIfHighOutdoorAirTempAndHighSolarOnWindow")]
        OnIfHighOutdoorAirTempAndHighSolarOnWindow = 7,
        
        [JsonProperty("OnIfHighOutdoorAirTemperature")]
        OnIfHighOutdoorAirTemperature = 8,
        
        [JsonProperty("OnIfHighSolarOnWindow")]
        OnIfHighSolarOnWindow = 9,
        
        [JsonProperty("OnIfHighZoneAirTempAndHighHorizontalSolar")]
        OnIfHighZoneAirTempAndHighHorizontalSolar = 10,
        
        [JsonProperty("OnIfHighZoneAirTempAndHighSolarOnWindow")]
        OnIfHighZoneAirTempAndHighSolarOnWindow = 11,
        
        [JsonProperty("OnIfHighZoneAirTemperature")]
        OnIfHighZoneAirTemperature = 12,
        
        [JsonProperty("OnIfHighZoneCooling")]
        OnIfHighZoneCooling = 13,
        
        [JsonProperty("OnIfScheduleAllows")]
        OnIfScheduleAllows = 14,
        
        [JsonProperty("OnNightAndOnDayIfCoolingAndHighSolarOnWindow")]
        OnNightAndOnDayIfCoolingAndHighSolarOnWindow = 15,
        
        [JsonProperty("OnNightIfHeatingAndOffDay")]
        OnNightIfHeatingAndOffDay = 16,
        
        [JsonProperty("OnNightIfHeatingAndOnDayIfCooling")]
        OnNightIfHeatingAndOnDayIfCooling = 17,
        
        [JsonProperty("OnNightIfLowInsideTempAndOffDay")]
        OnNightIfLowInsideTempAndOffDay = 18,
        
        [JsonProperty("OnNightIfLowOutdoorTempAndOffDay")]
        OnNightIfLowOutdoorTempAndOffDay = 19,
        
        [JsonProperty("OnNightIfLowOutdoorTempAndOnDayIfCooling")]
        OnNightIfLowOutdoorTempAndOnDayIfCooling = 20,
    }
}