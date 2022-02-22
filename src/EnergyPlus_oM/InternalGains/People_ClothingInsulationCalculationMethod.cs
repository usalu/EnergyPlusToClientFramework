namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    public enum People_ClothingInsulationCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CalculationMethodSchedule")]
        CalculationMethodSchedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ClothingInsulationSchedule")]
        ClothingInsulationSchedule = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="DynamicClothingModelASHRAE55")]
        DynamicClothingModelASHRAE55 = 3,
    }
}