using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("List equipment in simulation order")]
    public class AirLoopHVAC_OutdoorAirSystem_EquipmentList : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("component_1_object_type")]
        public string Component1ObjectType { get; set; } = "";
        

        [JsonProperty("component_1_name")]
        public string Component1Name { get; set; } = "";
        

        [JsonProperty("component_2_object_type")]
        public string Component2ObjectType { get; set; } = "";
        

        [JsonProperty("component_2_name")]
        public string Component2Name { get; set; } = "";
        

        [JsonProperty("component_3_object_type")]
        public string Component3ObjectType { get; set; } = "";
        

        [JsonProperty("component_3_name")]
        public string Component3Name { get; set; } = "";
        

        [JsonProperty("component_4_object_type")]
        public string Component4ObjectType { get; set; } = "";
        

        [JsonProperty("component_4_name")]
        public string Component4Name { get; set; } = "";
        

        [JsonProperty("component_5_object_type")]
        public string Component5ObjectType { get; set; } = "";
        

        [JsonProperty("component_5_name")]
        public string Component5Name { get; set; } = "";
        

        [JsonProperty("component_6_object_type")]
        public string Component6ObjectType { get; set; } = "";
        

        [JsonProperty("component_6_name")]
        public string Component6Name { get; set; } = "";
        

        [JsonProperty("component_7_object_type")]
        public string Component7ObjectType { get; set; } = "";
        

        [JsonProperty("component_7_name")]
        public string Component7Name { get; set; } = "";
        

        [JsonProperty("component_8_object_type")]
        public string Component8ObjectType { get; set; } = "";
        

        [JsonProperty("component_8_name")]
        public string Component8Name { get; set; } = "";
        

        [JsonProperty("component_9_object_type")]
        public string Component9ObjectType { get; set; } = "";
        

        [JsonProperty("component_9_name")]
        public string Component9Name { get; set; } = "";
    }
}