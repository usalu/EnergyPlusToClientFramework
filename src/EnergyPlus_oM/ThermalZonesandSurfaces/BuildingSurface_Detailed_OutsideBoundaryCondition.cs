namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum BuildingSurface_Detailed_OutsideBoundaryCondition
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Adiabatic")]
        Adiabatic = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Foundation")]
        Foundation = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Ground")]
        Ground = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageFloor")]
        GroundBasementPreprocessorAverageFloor = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageWall")]
        GroundBasementPreprocessorAverageWall = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorLowerWall")]
        GroundBasementPreprocessorLowerWall = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorUpperWall")]
        GroundBasementPreprocessorUpperWall = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundFCfactorMethod")]
        GroundFCfactorMethod = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorAverage")]
        GroundSlabPreprocessorAverage = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorCore")]
        GroundSlabPreprocessorCore = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorPerimeter")]
        GroundSlabPreprocessorPerimeter = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideCoefficients")]
        OtherSideCoefficients = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideConditionsModel")]
        OtherSideConditionsModel = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 13,
        
        [System.Runtime.Serialization.EnumMember(Value="Surface")]
        Surface = 14,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 15,
    }
}