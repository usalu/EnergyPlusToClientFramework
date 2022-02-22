namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_VentilatedSlab_SystemConfigurationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SeriesSlabs")]
        SeriesSlabs = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SlabAndZone")]
        SlabAndZone = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SlabOnly")]
        SlabOnly = 3,
    }
}