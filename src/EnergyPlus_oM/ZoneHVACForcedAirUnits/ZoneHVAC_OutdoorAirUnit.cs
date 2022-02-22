using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("The zone outdoor air unit models a single-zone dedicated outdoor air system (DOAS" +
                 "). Forced-convection 100% outdoor air unit with supply fan and optional equipmen" +
                 "t including exhaust fan, heating coil, cooling coil, and heat recovery.")]
    [JsonObject("ZoneHVAC:OutdoorAirUnit")]
    public class ZoneHVAC_OutdoorAirUnit : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("(name of zone system is serving)")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("outdoor_air_flow_rate")]
        public string OutdoorAirFlowRate { get; set; } = "";
        

        [JsonProperty("outdoor_air_schedule_name")]
        public string OutdoorAirScheduleName { get; set; } = "";
        

        [Description("Allowable fan types are Fan:SystemModel and Fan:ConstantVolume and Fan:VariableVo" +
                     "lume")]
        [JsonProperty("supply_fan_name")]
        public string SupplyFanName { get; set; } = "";
        

        [JsonProperty("supply_fan_placement")]
        public ZoneHVAC_OutdoorAirUnit_SupplyFanPlacement SupplyFanPlacement { get; set; } = (ZoneHVAC_OutdoorAirUnit_SupplyFanPlacement)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_SupplyFanPlacement), "DrawThrough");
        

        [Description("Allowable fan types are Fan:SystemModel and Fan:ConstantVolume and Fan:VariableVo" +
                     "lume Fan:VariableVolume")]
        [JsonProperty("exhaust_fan_name")]
        public string ExhaustFanName { get; set; } = "";
        

        [JsonProperty("exhaust_air_flow_rate")]
        public string ExhaustAirFlowRate { get; set; } = "";
        

        [JsonProperty("exhaust_air_schedule_name")]
        public string ExhaustAirScheduleName { get; set; } = "";
        

        [JsonProperty("unit_control_type")]
        public ZoneHVAC_OutdoorAirUnit_UnitControlType UnitControlType { get; set; } = (ZoneHVAC_OutdoorAirUnit_UnitControlType)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_UnitControlType), "NeutralControl");
        

        [Description(@"Air and control temperatures for cooling. If outdoor air temperature is above the high air control temperature, then the zone inlet air temperature is set to the high air control temperature. If the outdoor air is between high and low air control temperature, then there is no cooling/heating requirements.")]
        [JsonProperty("high_air_control_temperature_schedule_name")]
        public string HighAirControlTemperatureScheduleName { get; set; } = "";
        

        [Description(@"Air and control temperatures for Heating. If outdoor air temperature is below the low air control temperature, then the zone inlet air temperature is set to the low air control temperature. If the outdoor air is between high and low air control temperature, then there is no cooling/heating requirements.")]
        [JsonProperty("low_air_control_temperature_schedule_name")]
        public string LowAirControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("outdoor_air_node_name")]
        public string OutdoorAirNodeName { get; set; } = "";
        

        [JsonProperty("airoutlet_node_name")]
        public string AiroutletNodeName { get; set; } = "";
        

        [Description("air leaves zone")]
        [JsonProperty("airinlet_node_name")]
        public string AirinletNodeName { get; set; } = "";
        

        [JsonProperty("supply_fanoutlet_node_name")]
        public string SupplyFanoutletNodeName { get; set; } = "";
        

        [Description("Enter the name of an ZoneHVAC:OutdoorAirUnit:EquipmentList object.")]
        [JsonProperty("outdoor_air_unit_list_name")]
        public string OutdoorAirUnitListName { get; set; } = "";
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty("availability_manager_list_name")]
        public string AvailabilityManagerListName { get; set; } = "";
    }
}