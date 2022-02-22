namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_WalkIn_DefrostType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Electric")]
        Electric = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="HotFluid")]
        HotFluid = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OffCycle")]
        OffCycle = 4,
    }
}