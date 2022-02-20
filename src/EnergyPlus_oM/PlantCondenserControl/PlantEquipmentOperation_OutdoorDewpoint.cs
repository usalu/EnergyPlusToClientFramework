using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description("Plant equipment operation scheme for outdoor dewpoint temperature range operation" +
                 ". Specifies one or more groups of equipment which are available to operate for s" +
                 "uccessive outdoor dewpoint temperature ranges.")]
    [JsonObject("PlantEquipmentOperation:OutdoorDewpoint")]
    public class PlantEquipmentOperation_OutdoorDewpoint : BHoMObject
    {
        

        [JsonProperty("dewpoint_temperature_range_1_lower_limit")]
        public System.Nullable<float> DewpointTemperatureRange1LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_range_1_upper_limit")]
        public System.Nullable<float> DewpointTemperatureRange1UpperLimit { get; set; } = null;
        

        [JsonProperty("range_1_equipment_list_name")]
        public string Range1EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_range_2_lower_limit")]
        public System.Nullable<float> DewpointTemperatureRange2LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_range_2_upper_limit")]
        public System.Nullable<float> DewpointTemperatureRange2UpperLimit { get; set; } = null;
        

        [JsonProperty("range_2_equipment_list_name")]
        public string Range2EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_range_3_lower_limit")]
        public System.Nullable<float> DewpointTemperatureRange3LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_range_3_upper_limit")]
        public System.Nullable<float> DewpointTemperatureRange3UpperLimit { get; set; } = null;
        

        [JsonProperty("range_3_equipment_list_name")]
        public string Range3EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_range_4_lower_limit")]
        public System.Nullable<float> DewpointTemperatureRange4LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_range_4_upper_limit")]
        public System.Nullable<float> DewpointTemperatureRange4UpperLimit { get; set; } = null;
        

        [JsonProperty("range_4_equipment_list_name")]
        public string Range4EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_range_5_lower_limit")]
        public System.Nullable<float> DewpointTemperatureRange5LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_range_5_upper_limit")]
        public System.Nullable<float> DewpointTemperatureRange5UpperLimit { get; set; } = null;
        

        [JsonProperty("range_5_equipment_list_name")]
        public string Range5EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_range_6_lower_limit")]
        public System.Nullable<float> DewpointTemperatureRange6LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_range_6_upper_limit")]
        public System.Nullable<float> DewpointTemperatureRange6UpperLimit { get; set; } = null;
        

        [JsonProperty("range_6_equipment_list_name")]
        public string Range6EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_range_7_lower_limit")]
        public System.Nullable<float> DewpointTemperatureRange7LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_range_7_upper_limit")]
        public System.Nullable<float> DewpointTemperatureRange7UpperLimit { get; set; } = null;
        

        [JsonProperty("range_7_equipment_list_name")]
        public string Range7EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_range_8_lower_limit")]
        public System.Nullable<float> DewpointTemperatureRange8LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_range_8_upper_limit")]
        public System.Nullable<float> DewpointTemperatureRange8UpperLimit { get; set; } = null;
        

        [JsonProperty("range_8_equipment_list_name")]
        public string Range8EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_range_9_lower_limit")]
        public System.Nullable<float> DewpointTemperatureRange9LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_range_9_upper_limit")]
        public System.Nullable<float> DewpointTemperatureRange9UpperLimit { get; set; } = null;
        

        [JsonProperty("range_9_equipment_list_name")]
        public string Range9EquipmentListName { get; set; } = "";
        

        [JsonProperty("dewpoint_temperature_range_10_lower_limit")]
        public System.Nullable<float> DewpointTemperatureRange10LowerLimit { get; set; } = null;
        

        [JsonProperty("dewpoint_temperature_range_10_upper_limit")]
        public System.Nullable<float> DewpointTemperatureRange10UpperLimit { get; set; } = null;
        

        [JsonProperty("range_10_equipment_list_name")]
        public string Range10EquipmentListName { get; set; } = "";
    }
}