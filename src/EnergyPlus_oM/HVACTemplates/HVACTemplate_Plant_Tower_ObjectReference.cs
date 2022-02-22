using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("This object references a detailed cooling tower object and adds it to an HVACTemp" +
                 "late:Plant:ChilledWaterLoop or MixedWaterLoop. The user must create a complete d" +
                 "etailed cooling tower object with all required curve or performance objects.")]
    public class HVACTemplate_Plant_Tower_ObjectReference : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("cooling_tower_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Tower_ObjectReference_CoolingTowerObjectType CoolingTowerObjectType { get; set; } = (HVACTemplate_Plant_Tower_ObjectReference_CoolingTowerObjectType)Enum.Parse(typeof(HVACTemplate_Plant_Tower_ObjectReference_CoolingTowerObjectType), "Empty");
        

        [Description("The name of the detailed cooling tower object.")]
        [JsonProperty("cooling_tower_name")]
        public string CoolingTowerName { get; set; } = "";
        

        [Description("If Condenser Plant Operation Scheme Type=Default in HVACTemplate:Plant:ChilledWat" +
                     "erLoop or MixedWaterLoop, then equipment operates in Priority order, 1, 2, 3, et" +
                     "c.")]
        [JsonProperty("priority")]
        public System.Nullable<float> Priority { get; set; } = null;
        

        [Description("Specifies if this tower serves a template chilled water loop or mixed water loop " +
                     "If left blank, will serve a chilled water loop if present, or a mixed water loop" +
                     " (if no chilled water loop is present).")]
        [JsonProperty("template_plant_loop_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Tower_ObjectReference_TemplatePlantLoopType TemplatePlantLoopType { get; set; } = (HVACTemplate_Plant_Tower_ObjectReference_TemplatePlantLoopType)Enum.Parse(typeof(HVACTemplate_Plant_Tower_ObjectReference_TemplatePlantLoopType), "ChilledWater");
    }
}