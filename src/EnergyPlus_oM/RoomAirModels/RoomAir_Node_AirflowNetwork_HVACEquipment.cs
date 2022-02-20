using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("define the zone equipment associated with one particular RoomAir:Node")]
    [JsonObject("RoomAir:Node:AirflowNetwork:HVACEquipment")]
    public class RoomAir_Node_AirflowNetwork_HVACEquipment : BHoMObject
    {
        

        [JsonProperty("equipment_fractions")]
        public string EquipmentFractions { get; set; } = "";
    }
}