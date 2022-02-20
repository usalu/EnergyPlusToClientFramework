using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("This object references a detailed chiller object and adds it to an HVACTemplate:P" +
                 "lant:ChilledWaterLoop. The user must create a complete detailed chiller object w" +
                 "ith all required curve or performance objects.")]
    [JsonObject("HVACTemplate:Plant:Chiller:ObjectReference")]
    public class HVACTemplate_Plant_Chiller_ObjectReference : BHoMObject
    {
        

        [JsonProperty("chiller_object_type")]
        public EmptyNoYes ChillerObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Chiller:Electric:EIR");
        

        [Description("The name of the detailed chiller object.")]
        [JsonProperty("chiller_name")]
        public string ChillerName { get; set; } = "";
        

        [Description("If Chiller Plant Operation Scheme Type=Default in HVACTemplate:Plant:ChilledWater" +
                     "Loop, then equipment operates in Priority order, 1, 2, 3, etc.")]
        [JsonProperty("priority")]
        public System.Nullable<float> Priority { get; set; } = null;
    }
}