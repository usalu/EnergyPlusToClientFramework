namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    public enum ZoneControl_Thermostat_OperativeTemperature_AdaptiveComfortModelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH5580PercentUpperLine")]
        AdaptiveASH5580PercentUpperLine = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH5590PercentUpperLine")]
        AdaptiveASH5590PercentUpperLine = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveASH55CentralLine")]
        AdaptiveASH55CentralLine = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251CategoryIIIUpperLine")]
        AdaptiveCEN15251CategoryIIIUpperLine = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251CategoryIIUpperLine")]
        AdaptiveCEN15251CategoryIIUpperLine = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251CategoryIUpperLine")]
        AdaptiveCEN15251CategoryIUpperLine = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveCEN15251CentralLine")]
        AdaptiveCEN15251CentralLine = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 8,
    }
}