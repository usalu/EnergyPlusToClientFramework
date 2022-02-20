using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    public enum RoomAirModelType_RoomAirModelingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirflowNetwork")]
        AirflowNetwork = 1,
        
        [JsonProperty("CrossVentilation")]
        CrossVentilation = 2,
        
        [JsonProperty("Mixing")]
        Mixing = 3,
        
        [JsonProperty("OneNodeDisplacementVentilation")]
        OneNodeDisplacementVentilation = 4,
        
        [JsonProperty("ThreeNodeDisplacementVentilation")]
        ThreeNodeDisplacementVentilation = 5,
        
        [JsonProperty("UnderFloorAirDistributionExterior")]
        UnderFloorAirDistributionExterior = 6,
        
        [JsonProperty("UnderFloorAirDistributionInterior")]
        UnderFloorAirDistributionInterior = 7,
        
        [JsonProperty("UserDefined")]
        UserDefined = 8,
    }
}