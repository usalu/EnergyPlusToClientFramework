using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    [Description("Defines a generic plant operation scheme for custom supervisory control using Ene" +
                 "rgy Management System or External Interface to dispatch loads")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperation_UserDefined : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("main_model_program_calling_manager_name")]
        public string MainModelProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("initialization_program_calling_manager_name")]
        public string InitializationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty("equipment_1_object_type")]
        public string Equipment1ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_1_name")]
        public string Equipment1Name { get; set; } = "";
        

        [JsonProperty("equipment_2_object_type")]
        public string Equipment2ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_2_name")]
        public string Equipment2Name { get; set; } = "";
        

        [JsonProperty("equipment_3_object_type")]
        public string Equipment3ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_3_name")]
        public string Equipment3Name { get; set; } = "";
        

        [JsonProperty("equipment_4_object_type")]
        public string Equipment4ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_4_name")]
        public string Equipment4Name { get; set; } = "";
        

        [JsonProperty("equipment_5_object_type")]
        public string Equipment5ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_5_name")]
        public string Equipment5Name { get; set; } = "";
        

        [JsonProperty("equipment_6_object_type")]
        public string Equipment6ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_6_name")]
        public string Equipment6Name { get; set; } = "";
        

        [JsonProperty("equipment_7_object_type")]
        public string Equipment7ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_7_name")]
        public string Equipment7Name { get; set; } = "";
        

        [JsonProperty("equipment_8_object_type")]
        public string Equipment8ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_8_name")]
        public string Equipment8Name { get; set; } = "";
        

        [JsonProperty("equipment_9_object_type")]
        public string Equipment9ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_9_name")]
        public string Equipment9Name { get; set; } = "";
        

        [JsonProperty("equipment_10_object_type")]
        public string Equipment10ObjectType { get; set; } = "";
        

        [JsonProperty("equipment_10_name")]
        public string Equipment10Name { get; set; } = "";
    }
}