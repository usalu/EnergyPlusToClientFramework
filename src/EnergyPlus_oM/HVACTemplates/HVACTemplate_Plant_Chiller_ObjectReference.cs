using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("This object references a detailed chiller object and adds it to an HVACTemplate:P" +
                 "lant:ChilledWaterLoop. The user must create a complete detailed chiller object w" +
                 "ith all required curve or performance objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Plant_Chiller_ObjectReference : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("chiller_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Chiller_ObjectReference_ChillerObjectType ChillerObjectType { get; set; } = (HVACTemplate_Plant_Chiller_ObjectReference_ChillerObjectType)Enum.Parse(typeof(HVACTemplate_Plant_Chiller_ObjectReference_ChillerObjectType), "Empty");
        

        [Description("The name of the detailed chiller object.")]
        [JsonProperty("chiller_name")]
        public string ChillerName { get; set; } = "";
        

        [Description("If Chiller Plant Operation Scheme Type=Default in HVACTemplate:Plant:ChilledWater" +
                     "Loop, then equipment operates in Priority order, 1, 2, 3, etc.")]
        [JsonProperty("priority")]
        public System.Nullable<float> Priority { get; set; } = null;
    }
}