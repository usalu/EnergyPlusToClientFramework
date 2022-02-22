using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description("Plant equipment operation scheme for outdoor relative humidity range operation. S" +
                 "pecifies one or more groups of equipment which are available to operate for succ" +
                 "essive outdoor relative humidity ranges.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperation_OutdoorRelativeHumidity : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("relative_humidity_range_1_lower_limit")]
        public System.Nullable<float> RelativeHumidityRange1LowerLimit { get; set; } = null;
        

        [JsonProperty("relative_humidity_range_1_upper_limit")]
        public System.Nullable<float> RelativeHumidityRange1UpperLimit { get; set; } = null;
        

        [JsonProperty("range_1_equipment_list_name")]
        public string Range1EquipmentListName { get; set; } = "";
        

        [JsonProperty("relative_humidity_range_2_lower_limit")]
        public System.Nullable<float> RelativeHumidityRange2LowerLimit { get; set; } = null;
        

        [JsonProperty("relative_humidity_range_2_upper_limit")]
        public System.Nullable<float> RelativeHumidityRange2UpperLimit { get; set; } = null;
        

        [JsonProperty("range_2_equipment_list_name")]
        public string Range2EquipmentListName { get; set; } = "";
        

        [JsonProperty("relative_humidity_range_3_lower_limit")]
        public System.Nullable<float> RelativeHumidityRange3LowerLimit { get; set; } = null;
        

        [JsonProperty("relative_humidity_range_3_upper_limit")]
        public System.Nullable<float> RelativeHumidityRange3UpperLimit { get; set; } = null;
        

        [JsonProperty("range_3_equipment_list_name")]
        public string Range3EquipmentListName { get; set; } = "";
        

        [JsonProperty("relative_humidity_range_4_lower_limit")]
        public System.Nullable<float> RelativeHumidityRange4LowerLimit { get; set; } = null;
        

        [JsonProperty("relative_humidity_range_4_upper_limit")]
        public System.Nullable<float> RelativeHumidityRange4UpperLimit { get; set; } = null;
        

        [JsonProperty("range_4_equipment_list_name")]
        public string Range4EquipmentListName { get; set; } = "";
        

        [JsonProperty("relative_humidity_range_5_lower_limit")]
        public System.Nullable<float> RelativeHumidityRange5LowerLimit { get; set; } = null;
        

        [JsonProperty("relative_humidity_range_5_upper_limit")]
        public System.Nullable<float> RelativeHumidityRange5UpperLimit { get; set; } = null;
        

        [JsonProperty("range_5_equipment_list_name")]
        public string Range5EquipmentListName { get; set; } = "";
        

        [JsonProperty("relative_humidity_range_6_lower_limit")]
        public System.Nullable<float> RelativeHumidityRange6LowerLimit { get; set; } = null;
        

        [JsonProperty("relative_humidity_range_6_upper_limit")]
        public System.Nullable<float> RelativeHumidityRange6UpperLimit { get; set; } = null;
        

        [JsonProperty("range_6_equipment_list_name")]
        public string Range6EquipmentListName { get; set; } = "";
        

        [JsonProperty("relative_humidity_range_7_lower_limit")]
        public System.Nullable<float> RelativeHumidityRange7LowerLimit { get; set; } = null;
        

        [JsonProperty("relative_humidity_range_7_upper_limit")]
        public System.Nullable<float> RelativeHumidityRange7UpperLimit { get; set; } = null;
        

        [JsonProperty("range_7_equipment_list_name")]
        public string Range7EquipmentListName { get; set; } = "";
        

        [JsonProperty("relative_humidity_range_8_lower_limit")]
        public System.Nullable<float> RelativeHumidityRange8LowerLimit { get; set; } = null;
        

        [JsonProperty("relative_humidity_range_8_upper_limit")]
        public System.Nullable<float> RelativeHumidityRange8UpperLimit { get; set; } = null;
        

        [JsonProperty("range_8_equipment_list_name")]
        public string Range8EquipmentListName { get; set; } = "";
        

        [JsonProperty("relative_humidity_range_9_lower_limit")]
        public System.Nullable<float> RelativeHumidityRange9LowerLimit { get; set; } = null;
        

        [JsonProperty("relative_humidity_range_9_upper_limit")]
        public System.Nullable<float> RelativeHumidityRange9UpperLimit { get; set; } = null;
        

        [JsonProperty("range_9_equipment_list_name")]
        public string Range9EquipmentListName { get; set; } = "";
        

        [JsonProperty("relative_humidity_range_10_lower_limit")]
        public System.Nullable<float> RelativeHumidityRange10LowerLimit { get; set; } = null;
        

        [JsonProperty("relative_humidity_range_10_upper_limit")]
        public System.Nullable<float> RelativeHumidityRange10UpperLimit { get; set; } = null;
        

        [JsonProperty("range_10_equipment_list_name")]
        public string Range10EquipmentListName { get; set; } = "";
    }
}