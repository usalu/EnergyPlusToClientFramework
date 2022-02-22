using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description(@"Plant equipment operation scheme for outdoor dry-bulb temperature difference operation. Specifies one or more groups of equipment which are available to operate for successive ranges based the difference between a reference node temperature and the outdoor dry-bulb temperature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperation_OutdoorDryBulbDifference : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("reference_temperature_node_name")]
        public string ReferenceTemperatureNodeName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_difference_range_1_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange1LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_difference_range_1_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange1UpperLimit { get; set; } = null;
        

        [JsonProperty("range_1_equipment_list_name")]
        public string Range1EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_difference_range_2_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange2LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_difference_range_2_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange2UpperLimit { get; set; } = null;
        

        [JsonProperty("range_2_equipment_list_name")]
        public string Range2EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_difference_range_3_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange3LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_difference_range_3_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange3UpperLimit { get; set; } = null;
        

        [JsonProperty("range_3_equipment_list_name")]
        public string Range3EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_difference_range_4_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange4LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_difference_range_4_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange4UpperLimit { get; set; } = null;
        

        [JsonProperty("range_4_equipment_list_name")]
        public string Range4EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_difference_range_5_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange5LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_difference_range_5_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange5UpperLimit { get; set; } = null;
        

        [JsonProperty("range_5_equipment_list_name")]
        public string Range5EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_difference_range_6_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange6LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_difference_range_6_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange6UpperLimit { get; set; } = null;
        

        [JsonProperty("range_6_equipment_list_name")]
        public string Range6EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_difference_range_7_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange7LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_difference_range_7_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange7UpperLimit { get; set; } = null;
        

        [JsonProperty("range_7_equipment_list_name")]
        public string Range7EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_difference_range_8_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange8LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_difference_range_8_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange8UpperLimit { get; set; } = null;
        

        [JsonProperty("range_8_equipment_list_name")]
        public string Range8EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_difference_range_9_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange9LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_difference_range_9_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange9UpperLimit { get; set; } = null;
        

        [JsonProperty("range_9_equipment_list_name")]
        public string Range9EquipmentListName { get; set; } = "";
        

        [JsonProperty("dry_bulb_temperature_difference_range_10_lower_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange10LowerLimit { get; set; } = null;
        

        [JsonProperty("dry_bulb_temperature_difference_range_10_upper_limit")]
        public System.Nullable<float> DryBulbTemperatureDifferenceRange10UpperLimit { get; set; } = null;
        

        [JsonProperty("range_10_equipment_list_name")]
        public string Range10EquipmentListName { get; set; } = "";
    }
}