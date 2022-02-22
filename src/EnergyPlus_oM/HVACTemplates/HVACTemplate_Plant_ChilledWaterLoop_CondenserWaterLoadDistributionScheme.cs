namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterLoadDistributionScheme
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Optimal")]
        Optimal = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SequentialLoad")]
        SequentialLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SequentialUniformPLR")]
        SequentialUniformPLR = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="UniformLoad")]
        UniformLoad = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="UniformPLR")]
        UniformPLR = 5,
    }
}