namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceProperty_OtherSideConditionsModel_TypeOfModeling
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConvectiveUnderwater")]
        ConvectiveUnderwater = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="GapConvectionRadiation")]
        GapConvectionRadiation = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundCoupledSurface")]
        GroundCoupledSurface = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="UndergroundPipingSystemSurface")]
        UndergroundPipingSystemSurface = 4,
    }
}