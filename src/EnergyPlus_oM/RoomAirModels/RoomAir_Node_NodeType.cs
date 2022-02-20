using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    public enum RoomAir_Node_NodeType
    {
        
        [JsonProperty("Ceiling")]
        Ceiling = 0,
        
        [JsonProperty("Control")]
        Control = 1,
        
        [JsonProperty("Floor")]
        Floor = 2,
        
        [JsonProperty("Inlet")]
        Inlet = 3,
        
        [JsonProperty("MundtRoom")]
        MundtRoom = 4,
        
        [JsonProperty("Return")]
        Return = 5,
    }
}