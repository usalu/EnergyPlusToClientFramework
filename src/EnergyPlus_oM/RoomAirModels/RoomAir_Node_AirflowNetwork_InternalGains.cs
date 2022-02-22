using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("define the internal gains that are associated with one particular RoomAir:Node")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node_AirflowNetwork_InternalGains : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("gains")]
        public string Gains { get; set; } = "";
    }
}