using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description(@"Operation schemes are listed in ""priority"" order. Note that each scheme must address the entire load and/or condition ranges for the simulation. The actual one selected for use will be the first that is ""Scheduled"" on. That is, if control scheme 1 is not ""on"" and control scheme 2 is -- then control scheme 2 is selected. Only plant equipment should be listed on a Control Scheme for this item.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperationSchemes : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("control_scheme_1_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperationSchemes_ControlScheme1ObjectType ControlScheme1ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme1ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme1ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

        [JsonProperty("control_scheme_1_name")]
        public string ControlScheme1Name { get; set; } = "";
        

        [JsonProperty("control_scheme_1_schedule_name")]
        public string ControlScheme1ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_2_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperationSchemes_ControlScheme2ObjectType ControlScheme2ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme2ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme2ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

        [JsonProperty("control_scheme_2_name")]
        public string ControlScheme2Name { get; set; } = "";
        

        [JsonProperty("control_scheme_2_schedule_name")]
        public string ControlScheme2ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_3_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperationSchemes_ControlScheme3ObjectType ControlScheme3ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme3ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme3ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

        [JsonProperty("control_scheme_3_name")]
        public string ControlScheme3Name { get; set; } = "";
        

        [JsonProperty("control_scheme_3_schedule_name")]
        public string ControlScheme3ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_4_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperationSchemes_ControlScheme4ObjectType ControlScheme4ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme4ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme4ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

        [JsonProperty("control_scheme_4_name")]
        public string ControlScheme4Name { get; set; } = "";
        

        [JsonProperty("control_scheme_4_schedule_name")]
        public string ControlScheme4ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_5_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperationSchemes_ControlScheme5ObjectType ControlScheme5ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme5ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme5ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

        [JsonProperty("control_scheme_5_name")]
        public string ControlScheme5Name { get; set; } = "";
        

        [JsonProperty("control_scheme_5_schedule_name")]
        public string ControlScheme5ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_6_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperationSchemes_ControlScheme6ObjectType ControlScheme6ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme6ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme6ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

        [JsonProperty("control_scheme_6_name")]
        public string ControlScheme6Name { get; set; } = "";
        

        [JsonProperty("control_scheme_6_schedule_name")]
        public string ControlScheme6ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_7_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperationSchemes_ControlScheme7ObjectType ControlScheme7ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme7ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme7ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

        [JsonProperty("control_scheme_7_name")]
        public string ControlScheme7Name { get; set; } = "";
        

        [JsonProperty("control_scheme_7_schedule_name")]
        public string ControlScheme7ScheduleName { get; set; } = "";
        

        [JsonProperty("control_scheme_8_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperationSchemes_ControlScheme8ObjectType ControlScheme8ObjectType { get; set; } = (PlantEquipmentOperationSchemes_ControlScheme8ObjectType)Enum.Parse(typeof(PlantEquipmentOperationSchemes_ControlScheme8ObjectType), "PlantEquipmentOperationComponentSetpoint");
        

        [JsonProperty("control_scheme_8_name")]
        public string ControlScheme8Name { get; set; } = "";
        

        [JsonProperty("control_scheme_8_schedule_name")]
        public string ControlScheme8ScheduleName { get; set; } = "";
    }
}