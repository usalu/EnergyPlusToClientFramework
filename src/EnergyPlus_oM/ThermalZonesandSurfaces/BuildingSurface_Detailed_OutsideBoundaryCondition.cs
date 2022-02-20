using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum BuildingSurface_Detailed_OutsideBoundaryCondition
    {
        
        [JsonProperty("Adiabatic")]
        Adiabatic = 0,
        
        [JsonProperty("Foundation")]
        Foundation = 1,
        
        [JsonProperty("Ground")]
        Ground = 2,
        
        [JsonProperty("GroundBasementPreprocessorAverageFloor")]
        GroundBasementPreprocessorAverageFloor = 3,
        
        [JsonProperty("GroundBasementPreprocessorAverageWall")]
        GroundBasementPreprocessorAverageWall = 4,
        
        [JsonProperty("GroundBasementPreprocessorLowerWall")]
        GroundBasementPreprocessorLowerWall = 5,
        
        [JsonProperty("GroundBasementPreprocessorUpperWall")]
        GroundBasementPreprocessorUpperWall = 6,
        
        [JsonProperty("GroundFCfactorMethod")]
        GroundFCfactorMethod = 7,
        
        [JsonProperty("GroundSlabPreprocessorAverage")]
        GroundSlabPreprocessorAverage = 8,
        
        [JsonProperty("GroundSlabPreprocessorCore")]
        GroundSlabPreprocessorCore = 9,
        
        [JsonProperty("GroundSlabPreprocessorPerimeter")]
        GroundSlabPreprocessorPerimeter = 10,
        
        [JsonProperty("OtherSideCoefficients")]
        OtherSideCoefficients = 11,
        
        [JsonProperty("OtherSideConditionsModel")]
        OtherSideConditionsModel = 12,
        
        [JsonProperty("Outdoors")]
        Outdoors = 13,
        
        [JsonProperty("Surface")]
        Surface = 14,
        
        [JsonProperty("Zone")]
        Zone = 15,
    }
}