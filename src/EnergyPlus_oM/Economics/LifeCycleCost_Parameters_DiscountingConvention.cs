namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum LifeCycleCost_Parameters_DiscountingConvention
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BeginningOfYear")]
        BeginningOfYear = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="EndOfYear")]
        EndOfYear = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MidYear")]
        MidYear = 3,
    }
}