using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("define the internal gains that are associated with one particular RoomAir:Node")]
    [JsonObject("RoomAir:Node:AirflowNetwork:InternalGains")]
    public class RoomAir_Node_AirflowNetwork_InternalGains : BHoMObject
    {
        

        [JsonProperty("gains")]
        public string Gains { get; set; } = "";
    }
}