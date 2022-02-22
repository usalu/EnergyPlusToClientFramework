namespace BH.oM.Adapters.EnergyPlus.Economics
{
    public enum UtilityCost_Variable_VariableType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Currency")]
        Currency = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Demand")]
        Demand = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Dimensionless")]
        Dimensionless = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Energy")]
        Energy = 4,
    }
}