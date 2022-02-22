namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    public enum ZoneVentilation_DesignFlowRate_VentilationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Balanced")]
        Balanced = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Exhaust")]
        Exhaust = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Intake")]
        Intake = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Natural")]
        Natural = 4,
    }
}