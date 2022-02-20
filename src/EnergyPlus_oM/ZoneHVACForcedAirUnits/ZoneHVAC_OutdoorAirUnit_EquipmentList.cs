using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Equipment list for components in a ZoneHVAC:OutdoorAirUnit. Components are simula" +
                 "ted sequentially in the order given in the equipment list.")]
    [JsonObject("ZoneHVAC:OutdoorAirUnit:EquipmentList")]
    public class ZoneHVAC_OutdoorAirUnit_EquipmentList : BHoMObject
    {
        

        [JsonProperty("component_1_object_type")]
        public EmptyNoYes Component1ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("component_1_name")]
        public string Component1Name { get; set; } = "";
        

        [JsonProperty("component_2_object_type")]
        public EmptyNoYes Component2ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("component_2_name")]
        public string Component2Name { get; set; } = "";
        

        [JsonProperty("component_3_object_type")]
        public EmptyNoYes Component3ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("component_3_name")]
        public string Component3Name { get; set; } = "";
        

        [JsonProperty("component_4_object_type")]
        public EmptyNoYes Component4ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("component_4_name")]
        public string Component4Name { get; set; } = "";
        

        [JsonProperty("component_5_object_type")]
        public EmptyNoYes Component5ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("component_5_name")]
        public string Component5Name { get; set; } = "";
        

        [JsonProperty("component_6_object_type")]
        public EmptyNoYes Component6ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("component_6_name")]
        public string Component6Name { get; set; } = "";
        

        [JsonProperty("component_7_object_type")]
        public EmptyNoYes Component7ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("component_7_name")]
        public string Component7Name { get; set; } = "";
        

        [JsonProperty("component_8_object_type")]
        public EmptyNoYes Component8ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("component_8_name")]
        public string Component8Name { get; set; } = "";
    }
}