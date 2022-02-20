using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    [Description("List controllers in order of control sequence")]
    [JsonObject("AirLoopHVAC:ControllerList")]
    public class AirLoopHVAC_ControllerList : BHoMObject
    {
        

        [JsonProperty("controller_1_object_type")]
        public EmptyNoYes Controller1ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("controller_1_name")]
        public string Controller1Name { get; set; } = "";
        

        [JsonProperty("controller_2_object_type")]
        public EmptyNoYes Controller2ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("controller_2_name")]
        public string Controller2Name { get; set; } = "";
        

        [JsonProperty("controller_3_object_type")]
        public EmptyNoYes Controller3ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("controller_3_name")]
        public string Controller3Name { get; set; } = "";
        

        [JsonProperty("controller_4_object_type")]
        public EmptyNoYes Controller4ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("controller_4_name")]
        public string Controller4Name { get; set; } = "";
        

        [JsonProperty("controller_5_object_type")]
        public EmptyNoYes Controller5ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("controller_5_name")]
        public string Controller5Name { get; set; } = "";
        

        [JsonProperty("controller_6_object_type")]
        public EmptyNoYes Controller6ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("controller_6_name")]
        public string Controller6Name { get; set; } = "";
        

        [JsonProperty("controller_7_object_type")]
        public EmptyNoYes Controller7ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("controller_7_name")]
        public string Controller7Name { get; set; } = "";
        

        [JsonProperty("controller_8_object_type")]
        public EmptyNoYes Controller8ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("controller_8_name")]
        public string Controller8Name { get; set; } = "";
    }
}