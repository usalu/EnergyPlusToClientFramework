namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_PTHP_OutdoorAirMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DetailedSpecification")]
        DetailedSpecification = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Area")]
        FlowArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Person")]
        FlowPerson = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Zone")]
        FlowZone = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Maximum")]
        Maximum = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Sum")]
        Sum = 6,
    }
}