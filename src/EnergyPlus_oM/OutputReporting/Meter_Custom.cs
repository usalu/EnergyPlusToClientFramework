using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"Used to allow users to combine specific variables and/or meters into ""custom"" meter configurations. To access these meters by name, one must first run a simulation to generate the RDD/MDD files and names. A Meter:Custom cannot reference another Meter:Custom.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Meter_Custom : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("resource_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Meter_Custom_ResourceType ResourceType { get; set; } = (Meter_Custom_ResourceType)Enum.Parse(typeof(Meter_Custom_ResourceType), "Coal");
        

        [JsonProperty("variable_details")]
        public string VariableDetails { get; set; } = "";
    }
}