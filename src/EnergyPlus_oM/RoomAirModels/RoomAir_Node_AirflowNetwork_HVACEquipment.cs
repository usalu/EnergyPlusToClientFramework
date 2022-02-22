using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("define the zone equipment associated with one particular RoomAir:Node")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node_AirflowNetwork_HVACEquipment : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("equipment_fractions")]
        public string EquipmentFractions { get; set; } = "";
    }
}