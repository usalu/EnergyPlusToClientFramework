using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description("Plant equipment operation scheme for outdoor wet-bulb temperature range operation" +
                 ". Specifies one or more groups of equipment which are available to operate for s" +
                 "uccessive outdoor wet-bulb temperature ranges.")]
    [JsonObject("PlantEquipmentOperation:OutdoorWetBulb")]
    public class PlantEquipmentOperation_OutdoorWetBulb : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("wet_bulb_temperature_range_1_lower_limit")]
        public System.Nullable<float> WetBulbTemperatureRange1LowerLimit { get; set; } = null;
        

        [JsonProperty("wet_bulb_temperature_range_1_upper_limit")]
        public System.Nullable<float> WetBulbTemperatureRange1UpperLimit { get; set; } = null;
        

        [JsonProperty("range_1_equipment_list_name")]
        public string Range1EquipmentListName { get; set; } = "";
        

        [JsonProperty("wet_bulb_temperature_range_2_lower_limit")]
        public System.Nullable<float> WetBulbTemperatureRange2LowerLimit { get; set; } = null;
        

        [JsonProperty("wet_bulb_temperature_range_2_upper_limit")]
        public System.Nullable<float> WetBulbTemperatureRange2UpperLimit { get; set; } = null;
        

        [JsonProperty("range_2_equipment_list_name")]
        public string Range2EquipmentListName { get; set; } = "";
        

        [JsonProperty("wet_bulb_temperature_range_3_lower_limit")]
        public System.Nullable<float> WetBulbTemperatureRange3LowerLimit { get; set; } = null;
        

        [JsonProperty("wet_bulb_temperature_range_3_upper_limit")]
        public System.Nullable<float> WetBulbTemperatureRange3UpperLimit { get; set; } = null;
        

        [JsonProperty("range_3_equipment_list_name")]
        public string Range3EquipmentListName { get; set; } = "";
        

        [JsonProperty("wet_bulb_temperature_range_4_lower_limit")]
        public System.Nullable<float> WetBulbTemperatureRange4LowerLimit { get; set; } = null;
        

        [JsonProperty("wet_bulb_temperature_range_4_upper_limit")]
        public System.Nullable<float> WetBulbTemperatureRange4UpperLimit { get; set; } = null;
        

        [JsonProperty("range_4_equipment_list_name")]
        public string Range4EquipmentListName { get; set; } = "";
        

        [JsonProperty("wet_bulb_temperature_range_5_lower_limit")]
        public System.Nullable<float> WetBulbTemperatureRange5LowerLimit { get; set; } = null;
        

        [JsonProperty("wet_bulb_temperature_range_5_upper_limit")]
        public System.Nullable<float> WetBulbTemperatureRange5UpperLimit { get; set; } = null;
        

        [JsonProperty("range_5_equipment_list_name")]
        public string Range5EquipmentListName { get; set; } = "";
        

        [JsonProperty("wet_bulb_temperature_range_6_lower_limit")]
        public System.Nullable<float> WetBulbTemperatureRange6LowerLimit { get; set; } = null;
        

        [JsonProperty("wet_bulb_temperature_range_6_upper_limit")]
        public System.Nullable<float> WetBulbTemperatureRange6UpperLimit { get; set; } = null;
        

        [JsonProperty("range_6_equipment_list_name")]
        public string Range6EquipmentListName { get; set; } = "";
        

        [JsonProperty("wet_bulb_temperature_range_7_lower_limit")]
        public System.Nullable<float> WetBulbTemperatureRange7LowerLimit { get; set; } = null;
        

        [JsonProperty("wet_bulb_temperature_range_7_upper_limit")]
        public System.Nullable<float> WetBulbTemperatureRange7UpperLimit { get; set; } = null;
        

        [JsonProperty("range_7_equipment_list_name")]
        public string Range7EquipmentListName { get; set; } = "";
        

        [JsonProperty("wet_bulb_temperature_range_8_lower_limit")]
        public System.Nullable<float> WetBulbTemperatureRange8LowerLimit { get; set; } = null;
        

        [JsonProperty("wet_bulb_temperature_range_8_upper_limit")]
        public System.Nullable<float> WetBulbTemperatureRange8UpperLimit { get; set; } = null;
        

        [JsonProperty("range_8_equipment_list_name")]
        public string Range8EquipmentListName { get; set; } = "";
        

        [JsonProperty("wet_bulb_temperature_range_9_lower_limit")]
        public System.Nullable<float> WetBulbTemperatureRange9LowerLimit { get; set; } = null;
        

        [JsonProperty("wet_bulb_temperature_range_9_upper_limit")]
        public System.Nullable<float> WetBulbTemperatureRange9UpperLimit { get; set; } = null;
        

        [JsonProperty("range_9_equipment_list_name")]
        public string Range9EquipmentListName { get; set; } = "";
        

        [JsonProperty("wet_bulb_temperature_range_10_lower_limit")]
        public System.Nullable<float> WetBulbTemperatureRange10LowerLimit { get; set; } = null;
        

        [JsonProperty("wet_bulb_temperature_range_10_upper_limit")]
        public System.Nullable<float> WetBulbTemperatureRange10UpperLimit { get; set; } = null;
        

        [JsonProperty("range_10_equipment_list_name")]
        public string Range10EquipmentListName { get; set; } = "";
    }
}