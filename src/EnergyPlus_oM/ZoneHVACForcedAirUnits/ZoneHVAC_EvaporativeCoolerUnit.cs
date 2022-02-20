using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Zone evaporative cooler. Forced-convection cooling-only unit with supply fan, 100" +
                 "% outdoor air supply. Optional relief exhaust node")]
    [JsonObject("ZoneHVAC:EvaporativeCoolerUnit")]
    public class ZoneHVAC_EvaporativeCoolerUnit : BHoMObject
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
        public EmptyNoYes SupplyAirFanObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty("design_supply_air_flow_rate")]
        public string DesignSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("fan_placement")]
        public EmptyNoYes FanPlacement { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("cooler_unit_control_method")]
        public EmptyNoYes CoolerUnitControlMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("used for ZoneTemperatureDeadbandOnOffCycling hystersis range for thermostatic con" +
                     "trol")]
        [JsonProperty("throttling_range_temperature_difference")]
        public System.Nullable<float> ThrottlingRangeTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Sign convention is that positive values indicate a cooling load")]
        [JsonProperty("cooling_load_control_threshold_heat_transfer_rate")]
        public System.Nullable<float> CoolingLoadControlThresholdHeatTransferRate { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

        [JsonProperty("first_evaporative_cooler_object_type")]
        public EmptyNoYes FirstEvaporativeCoolerObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("first_evaporative_cooler_object_name")]
        public string FirstEvaporativeCoolerObjectName { get; set; } = "";
        

        [Description("optional, used for direct/indirect configurations second cooler must be immediate" +
                     "ly downstream of first cooler, if present")]
        [JsonProperty("second_evaporative_cooler_object_type")]
        public EmptyNoYes SecondEvaporativeCoolerObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("optional, used for direct/indirect configurations")]
        [JsonProperty("second_evaporative_cooler_name")]
        public string SecondEvaporativeCoolerName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty("design_specification_zonehvac_sizing_object_name")]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}