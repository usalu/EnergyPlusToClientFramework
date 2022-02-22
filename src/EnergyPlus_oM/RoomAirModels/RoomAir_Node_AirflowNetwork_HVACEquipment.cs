using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("define the zone equipment associated with one particular RoomAir:Node")]
    public class RoomAir_Node_AirflowNetwork_HVACEquipment : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("equipment_fractions")]
        public string EquipmentFractions { get; set; } = "";
    }
}