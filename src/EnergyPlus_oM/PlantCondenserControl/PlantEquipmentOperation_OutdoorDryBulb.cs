using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description("Plant equipment operation scheme for outdoor dry-bulb temperature range operation" +
                 ". Specifies one or more groups of equipment which are available to operate for s" +
                 "uccessive outdoor dry-bulb temperature ranges.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperation_OutdoorDryBulb : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_range_1_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureRange1LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_range_1_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureRange1UpperLimit { get; set; } = null;
        

        [JsonProperty("range_1_equipment_list_name")]
        public string Range1EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_range_2_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureRange2LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_range_2_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureRange2UpperLimit { get; set; } = null;
        

        [JsonProperty("range_2_equipment_list_name")]
        public string Range2EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_range_3_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureRange3LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_range_3_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureRange3UpperLimit { get; set; } = null;
        

        [JsonProperty("range_3_equipment_list_name")]
        public string Range3EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_range_4_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureRange4LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_range_4_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureRange4UpperLimit { get; set; } = null;
        

        [JsonProperty("range_4_equipment_list_name")]
        public string Range4EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_range_5_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureRange5LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_range_5_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureRange5UpperLimit { get; set; } = null;
        

        [JsonProperty("range_5_equipment_list_name")]
        public string Range5EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_range_6_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureRange6LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_range_6_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureRange6UpperLimit { get; set; } = null;
        

        [JsonProperty("range_6_equipment_list_name")]
        public string Range6EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_range_7_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureRange7LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_range_7_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureRange7UpperLimit { get; set; } = null;
        

        [JsonProperty("range_7_equipment_list_name")]
        public string Range7EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_range_8_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureRange8LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_range_8_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureRange8UpperLimit { get; set; } = null;
        

        [JsonProperty("range_8_equipment_list_name")]
        public string Range8EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_range_9_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureRange9LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_range_9_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureRange9UpperLimit { get; set; } = null;
        

        [JsonProperty("range_9_equipment_list_name")]
        public string Range9EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_range_10_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureRange10LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_range_10_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureRange10UpperLimit { get; set; } = null;
        

        [JsonProperty("range_10_equipment_list_name")]
        public string Range10EquipmentListName { get; set; } = "";
    }
}