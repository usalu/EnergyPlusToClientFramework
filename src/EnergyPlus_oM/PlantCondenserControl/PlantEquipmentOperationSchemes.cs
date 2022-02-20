using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description(@"Operation schemes are listed in ""priority"" order. Note that each scheme must address the entire load and/or condition ranges for the simulation. The actual one selected for use will be the first that is ""Scheduled"" on. That is, if control scheme 1 is not ""on"" and control scheme 2 is -- then control scheme 2 is selected. Only plant equipment should be listed on a Control Scheme for this item.")]
    [JsonObject("PlantEquipmentOperationSchemes")]
    public class PlantEquipmentOperationSchemes : BHoMObject
    {
        

        [JsonProperty("control_scheme_1_object_type")]
        public EmptyNoYes ControlScheme1ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("control_scheme_1_name")]
        public string ControlScheme1Name { get; set; } = "";
        

        [JsonProperty("control_scheme_1_schedule_name")]
        public string ControlScheme1ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_2_object_type")]
        public EmptyNoYes ControlScheme2ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("control_scheme_2_name")]
        public string ControlScheme2Name { get; set; } = "";
        

        [JsonProperty("control_scheme_2_schedule_name")]
        public string ControlScheme2ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_3_object_type")]
        public EmptyNoYes ControlScheme3ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("control_scheme_3_name")]
        public string ControlScheme3Name { get; set; } = "";
        

        [JsonProperty("control_scheme_3_schedule_name")]
        public string ControlScheme3ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_4_object_type")]
        public EmptyNoYes ControlScheme4ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("control_scheme_4_name")]
        public string ControlScheme4Name { get; set; } = "";
        

        [JsonProperty("control_scheme_4_schedule_name")]
        public string ControlScheme4ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_5_object_type")]
        public EmptyNoYes ControlScheme5ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("control_scheme_5_name")]
        public string ControlScheme5Name { get; set; } = "";
        

        [JsonProperty("control_scheme_5_schedule_name")]
        public string ControlScheme5ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_6_object_type")]
        public EmptyNoYes ControlScheme6ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("control_scheme_6_name")]
        public string ControlScheme6Name { get; set; } = "";
        

        [JsonProperty("control_scheme_6_schedule_name")]
        public string ControlScheme6ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_7_object_type")]
        public EmptyNoYes ControlScheme7ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("control_scheme_7_name")]
        public string ControlScheme7Name { get; set; } = "";
        

        [JsonProperty("control_scheme_7_schedule_name")]
        public string ControlScheme7ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_8_object_type")]
        public EmptyNoYes ControlScheme8ObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("control_scheme_8_name")]
        public string ControlScheme8Name { get; set; } = "";
        

        [JsonProperty("control_scheme_8_schedule_name")]
        public string ControlScheme8ScheduleName { get; set; } = "";
    }
}