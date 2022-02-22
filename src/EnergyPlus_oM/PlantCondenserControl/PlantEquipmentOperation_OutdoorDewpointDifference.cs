using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description(@"Plant equipment operation scheme for outdoor dewpoint temperature difference operation. Specifies one or more groups of equipment which are available to operate for successive ranges based the difference between a reference node temperature and the outdoor dewpoint temperature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperation_OutdoorDewpointDifference : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("reference_temperature_node_name")]
        public string ReferenceTemperatureNodeName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_difference_range_1_lower_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange1LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_difference_range_1_upper_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange1UpperLimit { get; set; } = null;
        

        [JsonProperty("range_1_equipment_list_name")]
        public string Range1EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_difference_range_2_lower_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange2LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_difference_range_2_upper_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange2UpperLimit { get; set; } = null;
        

        [JsonProperty("range_2_equipment_list_name")]
        public string Range2EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_difference_range_3_lower_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange3LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_difference_range_3_upper_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange3UpperLimit { get; set; } = null;
        

        [JsonProperty("range_3_equipment_list_name")]
        public string Range3EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_difference_range_4_lower_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange4LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_difference_range_4_upper_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange4UpperLimit { get; set; } = null;
        

        [JsonProperty("range_4_equipment_list_name")]
        public string Range4EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_difference_range_5_lower_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange5LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_difference_range_5_upper_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange5UpperLimit { get; set; } = null;
        

        [JsonProperty("range_5_equipment_list_name")]
        public string Range5EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_difference_range_6_lower_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange6LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_difference_range_6_upper_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange6UpperLimit { get; set; } = null;
        

        [JsonProperty("range_6_equipment_list_name")]
        public string Range6EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_difference_range_7_lower_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange7LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_difference_range_7_upper_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange7UpperLimit { get; set; } = null;
        

        [JsonProperty("range_7_equipment_list_name")]
        public string Range7EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_difference_range_8_lower_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange8LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_difference_range_8_upper_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange8UpperLimit { get; set; } = null;
        

        [JsonProperty("range_8_equipment_list_name")]
        public string Range8EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_difference_range_9_lower_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange9LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_difference_range_9_upper_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange9UpperLimit { get; set; } = null;
        

        [JsonProperty("range_9_equipment_list_name")]
        public string Range9EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_difference_range_10_lower_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange10LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_difference_range_10_upper_limit")]
        public System.Nullable<float> DewpointTemperatureDifferenceRange10UpperLimit { get; set; } = null;
        

        [JsonProperty("range_10_equipment_list_name")]
        public string Range10EquipmentListName { get; set; } = "";
    }
}