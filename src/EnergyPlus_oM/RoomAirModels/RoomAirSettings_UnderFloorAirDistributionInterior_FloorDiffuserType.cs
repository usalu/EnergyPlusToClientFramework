using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    public enum RoomAirSettings_UnderFloorAirDistributionInterior_FloorDiffuserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Custom")]
        Custom = 1,
        
        [JsonProperty("HorizontalSwirl")]
        HorizontalSwirl = 2,
        
        [JsonProperty("LinearBarGrille")]
        LinearBarGrille = 3,
        
        [JsonProperty("Swirl")]
        Swirl = 4,
        
        [JsonProperty("VariableArea")]
        VariableArea = 5,
    }
}