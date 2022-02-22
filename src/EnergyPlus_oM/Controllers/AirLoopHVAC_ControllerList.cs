using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    [Description("List controllers in order of control sequence")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_ControllerList : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("controller_1_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_ControllerList_Controller1ObjectType Controller1ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller1ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller1ObjectType), "ControllerOutdoorAir");
        

        [JsonProperty("controller_1_name")]
        public string Controller1Name { get; set; } = "";
        

        [JsonProperty("controller_2_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_ControllerList_Controller2ObjectType Controller2ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller2ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller2ObjectType), "ControllerOutdoorAir");
        

        [JsonProperty("controller_2_name")]
        public string Controller2Name { get; set; } = "";
        

        [JsonProperty("controller_3_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_ControllerList_Controller3ObjectType Controller3ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller3ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller3ObjectType), "ControllerOutdoorAir");
        

        [JsonProperty("controller_3_name")]
        public string Controller3Name { get; set; } = "";
        

        [JsonProperty("controller_4_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_ControllerList_Controller4ObjectType Controller4ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller4ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller4ObjectType), "ControllerOutdoorAir");
        

        [JsonProperty("controller_4_name")]
        public string Controller4Name { get; set; } = "";
        

        [JsonProperty("controller_5_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_ControllerList_Controller5ObjectType Controller5ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller5ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller5ObjectType), "ControllerOutdoorAir");
        

        [JsonProperty("controller_5_name")]
        public string Controller5Name { get; set; } = "";
        

        [JsonProperty("controller_6_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_ControllerList_Controller6ObjectType Controller6ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller6ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller6ObjectType), "ControllerOutdoorAir");
        

        [JsonProperty("controller_6_name")]
        public string Controller6Name { get; set; } = "";
        

        [JsonProperty("controller_7_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_ControllerList_Controller7ObjectType Controller7ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller7ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller7ObjectType), "ControllerOutdoorAir");
        

        [JsonProperty("controller_7_name")]
        public string Controller7Name { get; set; } = "";
        

        [JsonProperty("controller_8_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_ControllerList_Controller8ObjectType Controller8ObjectType { get; set; } = (AirLoopHVAC_ControllerList_Controller8ObjectType)Enum.Parse(typeof(AirLoopHVAC_ControllerList_Controller8ObjectType), "ControllerOutdoorAir");
        

        [JsonProperty("controller_8_name")]
        public string Controller8Name { get; set; } = "";
    }
}