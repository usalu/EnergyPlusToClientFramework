namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum People_NumberOfPeopleCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Area/Person")]
        AreaPerson = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="People")]
        People = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="People/Area")]
        PeopleArea = 3,
    }
}