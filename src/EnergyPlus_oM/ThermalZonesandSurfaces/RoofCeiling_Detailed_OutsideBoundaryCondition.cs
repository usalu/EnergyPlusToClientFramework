namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum RoofCeiling_Detailed_OutsideBoundaryCondition
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Adiabatic")]
        Adiabatic = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Ground")]
        Ground = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageFloor")]
        GroundBasementPreprocessorAverageFloor = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorAverageWall")]
        GroundBasementPreprocessorAverageWall = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorLowerWall")]
        GroundBasementPreprocessorLowerWall = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundBasementPreprocessorUpperWall")]
        GroundBasementPreprocessorUpperWall = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorAverage")]
        GroundSlabPreprocessorAverage = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorCore")]
        GroundSlabPreprocessorCore = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="GroundSlabPreprocessorPerimeter")]
        GroundSlabPreprocessorPerimeter = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideCoefficients")]
        OtherSideCoefficients = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherSideConditionsModel")]
        OtherSideConditionsModel = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 11,
        
        [System.Runtime.Serialization.EnumMember(Value="Surface")]
        Surface = 12,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 13,
    }
}