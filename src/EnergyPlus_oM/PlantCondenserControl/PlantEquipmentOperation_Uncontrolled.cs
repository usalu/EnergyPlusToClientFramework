using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description("Plant equipment operation scheme for uncontrolled operation. Specifies a group of" +
                 " equipment that runs if the loop is active, unless turned off by the loop flow r" +
                 "esolver to maintain continuity in the fluid loop.")]
    [JsonObject("PlantEquipmentOperation:Uncontrolled")]
    public class PlantEquipmentOperation_Uncontrolled : BHoMObject
    {
        

        [JsonProperty("equipment_list_name")]
        public string EquipmentListName { get; set; } = "";
    }
}