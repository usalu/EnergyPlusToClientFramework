namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    public enum ElectricLoadCenter_Transformer_PerformanceInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NominalEfficiency")]
        NominalEfficiency = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="RatedLosses")]
        RatedLosses = 2,
    }
}