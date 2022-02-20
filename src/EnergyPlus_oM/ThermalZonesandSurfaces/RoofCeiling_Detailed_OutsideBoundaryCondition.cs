using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    public enum RoofCeiling_Detailed_OutsideBoundaryCondition
    {
        
        [JsonProperty("Adiabatic")]
        Adiabatic = 0,
        
        [JsonProperty("Ground")]
        Ground = 1,
        
        [JsonProperty("GroundBasementPreprocessorAverageFloor")]
        GroundBasementPreprocessorAverageFloor = 2,
        
        [JsonProperty("GroundBasementPreprocessorAverageWall")]
        GroundBasementPreprocessorAverageWall = 3,
        
        [JsonProperty("GroundBasementPreprocessorLowerWall")]
        GroundBasementPreprocessorLowerWall = 4,
        
        [JsonProperty("GroundBasementPreprocessorUpperWall")]
        GroundBasementPreprocessorUpperWall = 5,
        
        [JsonProperty("GroundSlabPreprocessorAverage")]
        GroundSlabPreprocessorAverage = 6,
        
        [JsonProperty("GroundSlabPreprocessorCore")]
        GroundSlabPreprocessorCore = 7,
        
        [JsonProperty("GroundSlabPreprocessorPerimeter")]
        GroundSlabPreprocessorPerimeter = 8,
        
        [JsonProperty("OtherSideCoefficients")]
        OtherSideCoefficients = 9,
        
        [JsonProperty("OtherSideConditionsModel")]
        OtherSideConditionsModel = 10,
        
        [JsonProperty("Outdoors")]
        Outdoors = 11,
        
        [JsonProperty("Surface")]
        Surface = 12,
        
        [JsonProperty("Zone")]
        Zone = 13,
    }
}