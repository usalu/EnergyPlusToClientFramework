namespace BH.oM.Adapters.EnergyPlus.PerformanceTables
{
    public enum Table_Lookup_NormalizationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AutomaticWithDivisor")]
        AutomaticWithDivisor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DivisorOnly")]
        DivisorOnly = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
    }
}