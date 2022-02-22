namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    public enum ZoneControl_Thermostat_TemperatureAndHumidity_OvercoolRangeInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 2,
    }
}