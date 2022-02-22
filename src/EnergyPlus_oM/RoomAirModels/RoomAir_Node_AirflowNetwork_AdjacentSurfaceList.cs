using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description(null)]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node_AirflowNetwork_AdjacentSurfaceList : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("surfaces")]
        public string Surfaces { get; set; } = "";
    }
}