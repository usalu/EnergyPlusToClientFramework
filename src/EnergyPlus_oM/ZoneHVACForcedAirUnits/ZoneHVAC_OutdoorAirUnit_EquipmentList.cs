using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Equipment list for components in a ZoneHVAC:OutdoorAirUnit. Components are simula" +
                 "ted sequentially in the order given in the equipment list.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_OutdoorAirUnit_EquipmentList : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("component_1_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_OutdoorAirUnit_EquipmentList_Component1ObjectType Component1ObjectType { get; set; } = (ZoneHVAC_OutdoorAirUnit_EquipmentList_Component1ObjectType)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_EquipmentList_Component1ObjectType), "AirLoopHVACUnitarySystem");
        

        [JsonProperty("component_1_name")]
        public string Component1Name { get; set; } = "";
        

        [JsonProperty("component_2_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_OutdoorAirUnit_EquipmentList_Component2ObjectType Component2ObjectType { get; set; } = (ZoneHVAC_OutdoorAirUnit_EquipmentList_Component2ObjectType)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_EquipmentList_Component2ObjectType), "AirLoopHVACUnitarySystem");
        

        [JsonProperty("component_2_name")]
        public string Component2Name { get; set; } = "";
        

        [JsonProperty("component_3_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_OutdoorAirUnit_EquipmentList_Component3ObjectType Component3ObjectType { get; set; } = (ZoneHVAC_OutdoorAirUnit_EquipmentList_Component3ObjectType)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_EquipmentList_Component3ObjectType), "AirLoopHVACUnitarySystem");
        

        [JsonProperty("component_3_name")]
        public string Component3Name { get; set; } = "";
        

        [JsonProperty("component_4_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_OutdoorAirUnit_EquipmentList_Component4ObjectType Component4ObjectType { get; set; } = (ZoneHVAC_OutdoorAirUnit_EquipmentList_Component4ObjectType)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_EquipmentList_Component4ObjectType), "AirLoopHVACUnitarySystem");
        

        [JsonProperty("component_4_name")]
        public string Component4Name { get; set; } = "";
        

        [JsonProperty("component_5_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_OutdoorAirUnit_EquipmentList_Component5ObjectType Component5ObjectType { get; set; } = (ZoneHVAC_OutdoorAirUnit_EquipmentList_Component5ObjectType)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_EquipmentList_Component5ObjectType), "AirLoopHVACUnitarySystem");
        

        [JsonProperty("component_5_name")]
        public string Component5Name { get; set; } = "";
        

        [JsonProperty("component_6_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_OutdoorAirUnit_EquipmentList_Component6ObjectType Component6ObjectType { get; set; } = (ZoneHVAC_OutdoorAirUnit_EquipmentList_Component6ObjectType)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_EquipmentList_Component6ObjectType), "AirLoopHVACUnitarySystem");
        

        [JsonProperty("component_6_name")]
        public string Component6Name { get; set; } = "";
        

        [JsonProperty("component_7_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_OutdoorAirUnit_EquipmentList_Component7ObjectType Component7ObjectType { get; set; } = (ZoneHVAC_OutdoorAirUnit_EquipmentList_Component7ObjectType)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_EquipmentList_Component7ObjectType), "AirLoopHVACUnitarySystem");
        

        [JsonProperty("component_7_name")]
        public string Component7Name { get; set; } = "";
        

        [JsonProperty("component_8_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_OutdoorAirUnit_EquipmentList_Component8ObjectType Component8ObjectType { get; set; } = (ZoneHVAC_OutdoorAirUnit_EquipmentList_Component8ObjectType)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_EquipmentList_Component8ObjectType), "AirLoopHVACUnitarySystem");
        

        [JsonProperty("component_8_name")]
        public string Component8Name { get; set; } = "";
    }
}