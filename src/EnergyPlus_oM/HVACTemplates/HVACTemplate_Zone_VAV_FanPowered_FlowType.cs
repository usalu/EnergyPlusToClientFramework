namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_VAV_FanPowered_FlowType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Parallel")]
        Parallel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ParallelFromPlenum")]
        ParallelFromPlenum = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Series")]
        Series = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SeriesFromPlenum")]
        SeriesFromPlenum = 4,
    }
}