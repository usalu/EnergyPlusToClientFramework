using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description(null)]
    [JsonObject("RoomAir:Node:AirflowNetwork:AdjacentSurfaceList")]
    public class RoomAir_Node_AirflowNetwork_AdjacentSurfaceList : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("surfaces")]
        public string Surfaces { get; set; } = "";
    }
}