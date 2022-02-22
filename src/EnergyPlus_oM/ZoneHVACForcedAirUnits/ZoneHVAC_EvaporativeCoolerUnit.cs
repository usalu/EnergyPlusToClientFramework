using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Zone evaporative cooler. Forced-convection cooling-only unit with supply fan, 100" +
                 "% outdoor air supply. Optional relief exhaust node")]
    public class ZoneHVAC_EvaporativeCoolerUnit : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty("availability_manager_list_name")]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("this is an outdoor air node")]
        [JsonProperty("outdoor_air_inlet_node_name")]
        public string OutdoorAirInletNodeName { get; set; } = "";
        

        [Description("this is a zone inlet node")]
        [JsonProperty("cooler_outlet_node_name")]
        public string CoolerOutletNodeName { get; set; } = "";
        

        [Description("this is a zone exhaust node, optional if flow is being balanced elsewhere")]
        [JsonProperty("zone_relief_air_node_name")]
        public string ZoneReliefAirNodeName { get; set; } = "";
        

        [JsonProperty("supply_air_fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EvaporativeCoolerUnit_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_EvaporativeCoolerUnit_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_EvaporativeCoolerUnit_SupplyAirFanObjectType), "FanComponentModel");
        

        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty("design_supply_air_flow_rate")]
        public string DesignSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EvaporativeCoolerUnit_FanPlacement FanPlacement { get; set; } = (ZoneHVAC_EvaporativeCoolerUnit_FanPlacement)Enum.Parse(typeof(ZoneHVAC_EvaporativeCoolerUnit_FanPlacement), "BlowThrough");
        

        [JsonProperty("cooler_unit_control_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EvaporativeCoolerUnit_CoolerUnitControlMethod CoolerUnitControlMethod { get; set; } = (ZoneHVAC_EvaporativeCoolerUnit_CoolerUnitControlMethod)Enum.Parse(typeof(ZoneHVAC_EvaporativeCoolerUnit_CoolerUnitControlMethod), "ZoneCoolingLoadOnOffCycling");
        

        [Description("used for ZoneTemperatureDeadbandOnOffCycling hystersis range for thermostatic con" +
                     "trol")]
        [JsonProperty("throttling_range_temperature_difference")]
        public System.Nullable<float> ThrottlingRangeTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Sign convention is that positive values indicate a cooling load")]
        [JsonProperty("cooling_load_control_threshold_heat_transfer_rate")]
        public System.Nullable<float> CoolingLoadControlThresholdHeatTransferRate { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

        [JsonProperty("first_evaporative_cooler_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EvaporativeCoolerUnit_FirstEvaporativeCoolerObjectType FirstEvaporativeCoolerObjectType { get; set; } = (ZoneHVAC_EvaporativeCoolerUnit_FirstEvaporativeCoolerObjectType)Enum.Parse(typeof(ZoneHVAC_EvaporativeCoolerUnit_FirstEvaporativeCoolerObjectType), "EvaporativeCoolerDirectCelDekPad");
        

        [JsonProperty("first_evaporative_cooler_object_name")]
        public string FirstEvaporativeCoolerObjectName { get; set; } = "";
        

        [Description("optional, used for direct/indirect configurations second cooler must be immediate" +
                     "ly downstream of first cooler, if present")]
        [JsonProperty("second_evaporative_cooler_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EvaporativeCoolerUnit_SecondEvaporativeCoolerObjectType SecondEvaporativeCoolerObjectType { get; set; } = (ZoneHVAC_EvaporativeCoolerUnit_SecondEvaporativeCoolerObjectType)Enum.Parse(typeof(ZoneHVAC_EvaporativeCoolerUnit_SecondEvaporativeCoolerObjectType), "EvaporativeCoolerDirectCelDekPad");
        

        [Description("optional, used for direct/indirect configurations")]
        [JsonProperty("second_evaporative_cooler_name")]
        public string SecondEvaporativeCoolerName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty("design_specification_zonehvac_sizing_object_name")]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}