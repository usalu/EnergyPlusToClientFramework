namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    public enum ZoneHVAC_EvaporativeCoolerUnit_CoolerUnitControlMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneCoolingLoadOnOffCycling")]
        ZoneCoolingLoadOnOffCycling = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneCoolingLoadVariableSpeedFan")]
        ZoneCoolingLoadVariableSpeedFan = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneTemperatureDeadbandOnOffCycling")]
        ZoneTemperatureDeadbandOnOffCycling = 2,
    }
}