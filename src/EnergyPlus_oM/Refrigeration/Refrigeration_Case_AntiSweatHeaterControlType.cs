namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    public enum Refrigeration_Case_AntiSweatHeaterControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DewpointMethod")]
        DewpointMethod = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatBalanceMethod")]
        HeatBalanceMethod = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Linear")]
        Linear = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 5,
    }
}