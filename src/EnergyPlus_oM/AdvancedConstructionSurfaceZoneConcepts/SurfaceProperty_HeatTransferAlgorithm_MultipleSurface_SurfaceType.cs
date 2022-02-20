using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_SurfaceType
    {
        
        [JsonProperty("AllExteriorFloors")]
        AllExteriorFloors = 0,
        
        [JsonProperty("AllExteriorRoofs")]
        AllExteriorRoofs = 1,
        
        [JsonProperty("AllExteriorSurfaces")]
        AllExteriorSurfaces = 2,
        
        [JsonProperty("AllExteriorWalls")]
        AllExteriorWalls = 3,
        
        [JsonProperty("AllGroundContactSurfaces")]
        AllGroundContactSurfaces = 4,
        
        [JsonProperty("AllInteriorCeilings")]
        AllInteriorCeilings = 5,
        
        [JsonProperty("AllInteriorFloors")]
        AllInteriorFloors = 6,
        
        [JsonProperty("AllInteriorSurfaces")]
        AllInteriorSurfaces = 7,
        
        [JsonProperty("AllInteriorWalls")]
        AllInteriorWalls = 8,
    }
}