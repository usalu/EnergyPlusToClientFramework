namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    public enum ZoneControl_Thermostat_ThermalComfort_AveragingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ObjectAverage")]
        ObjectAverage = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PeopleAverage")]
        PeopleAverage = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SpecificObject")]
        SpecificObject = 3,
    }
}