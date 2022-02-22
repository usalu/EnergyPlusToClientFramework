namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum WindowProperty_AirflowControl_AirflowDestination
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="IndoorAir")]
        IndoorAir = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAir")]
        OutdoorAir = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ReturnAir")]
        ReturnAir = 3,
    }
}