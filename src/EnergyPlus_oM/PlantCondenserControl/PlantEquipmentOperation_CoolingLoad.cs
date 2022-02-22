using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description("Plant equipment operation scheme for cooling load range operation. Specifies one " +
                 "or more groups of equipment which are available to operate for successive coolin" +
                 "g load ranges.")]
    [JsonObject("PlantEquipmentOperation:CoolingLoad")]
    public class PlantEquipmentOperation_CoolingLoad : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("load_range_1_lower_limit")]
        public System.Nullable<float> LoadRange1LowerLimit { get; set; } = null;
        

        [JsonProperty("load_range_1_upper_limit")]
        public System.Nullable<float> LoadRange1UpperLimit { get; set; } = null;
        

        [JsonProperty("range_1_equipment_list_name")]
        public string Range1EquipmentListName { get; set; } = "";
        

        [JsonProperty("load_range_2_lower_limit")]
        public System.Nullable<float> LoadRange2LowerLimit { get; set; } = null;
        

        [JsonProperty("load_range_2_upper_limit")]
        public System.Nullable<float> LoadRange2UpperLimit { get; set; } = null;
        

        [JsonProperty("range_2_equipment_list_name")]
        public string Range2EquipmentListName { get; set; } = "";
        

        [JsonProperty("load_range_3_lower_limit")]
        public System.Nullable<float> LoadRange3LowerLimit { get; set; } = null;
        

        [JsonProperty("load_range_3_upper_limit")]
        public System.Nullable<float> LoadRange3UpperLimit { get; set; } = null;
        

        [JsonProperty("range_3_equipment_list_name")]
        public string Range3EquipmentListName { get; set; } = "";
        

        [JsonProperty("load_range_4_lower_limit")]
        public System.Nullable<float> LoadRange4LowerLimit { get; set; } = null;
        

        [JsonProperty("load_range_4_upper_limit")]
        public System.Nullable<float> LoadRange4UpperLimit { get; set; } = null;
        

        [JsonProperty("range_4_equipment_list_name")]
        public string Range4EquipmentListName { get; set; } = "";
        

        [JsonProperty("load_range_5_lower_limit")]
        public System.Nullable<float> LoadRange5LowerLimit { get; set; } = null;
        

        [JsonProperty("load_range_5_upper_limit")]
        public System.Nullable<float> LoadRange5UpperLimit { get; set; } = null;
        

        [JsonProperty("range_5_equipment_list_name")]
        public string Range5EquipmentListName { get; set; } = "";
        

        [JsonProperty("load_range_6_lower_limit")]
        public System.Nullable<float> LoadRange6LowerLimit { get; set; } = null;
        

        [JsonProperty("load_range_6_upper_limit")]
        public System.Nullable<float> LoadRange6UpperLimit { get; set; } = null;
        

        [JsonProperty("range_6_equipment_list_name")]
        public string Range6EquipmentListName { get; set; } = "";
        

        [JsonProperty("load_range_7_lower_limit")]
        public System.Nullable<float> LoadRange7LowerLimit { get; set; } = null;
        

        [JsonProperty("load_range_7_upper_limit")]
        public System.Nullable<float> LoadRange7UpperLimit { get; set; } = null;
        

        [JsonProperty("range_7_equipment_list_name")]
        public string Range7EquipmentListName { get; set; } = "";
        

        [JsonProperty("load_range_8_lower_limit")]
        public System.Nullable<float> LoadRange8LowerLimit { get; set; } = null;
        

        [JsonProperty("load_range_8_upper_limit")]
        public System.Nullable<float> LoadRange8UpperLimit { get; set; } = null;
        

        [JsonProperty("range_8_equipment_list_name")]
        public string Range8EquipmentListName { get; set; } = "";
        

        [JsonProperty("load_range_9_lower_limit")]
        public System.Nullable<float> LoadRange9LowerLimit { get; set; } = null;
        

        [JsonProperty("load_range_9_upper_limit")]
        public System.Nullable<float> LoadRange9UpperLimit { get; set; } = null;
        

        [JsonProperty("range_9_equipment_list_name")]
        public string Range9EquipmentListName { get; set; } = "";
        

        [JsonProperty("load_range_10_lower_limit")]
        public System.Nullable<float> LoadRange10LowerLimit { get; set; } = null;
        

        [JsonProperty("load_range_10_upper_limit")]
        public System.Nullable<float> LoadRange10UpperLimit { get; set; } = null;
        

        [JsonProperty("range_10_equipment_list_name")]
        public string Range10EquipmentListName { get; set; } = "";
    }
}