using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Unit heater. Forced-convection heating-only unit with supply fan, heating coil (g" +
                 "as, electric, hot water, or steam) and fixed-position outdoor air mixer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_UnitHeater : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Allowable fan types are Fan:ConstantVolume, Fan:OnOff, Fan:VariableVolume and Fan" +
                     ":SystemModel")]
        [JsonProperty("supply_air_fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitHeater_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_UnitHeater_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_UnitHeater_SupplyAirFanObjectType), "FanConstantVolume");
        

        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty("maximum_supply_air_flow_rate")]
        public string MaximumSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("heating_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitHeater_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (ZoneHVAC_UnitHeater_HeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_UnitHeater_HeatingCoilObjectType), "CoilHeatingElectric");
        

        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [Description(@"Enter the name of a schedule that controls fan operation. Schedule name values of 0 denote cycling fan operation (fan cycles with the heating coil). Schedule values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation). The fan operating mode defaults to cycling fan operation if this input field is left blank.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description(@"This choice field allows the user to define how the unit heater will operate under ""no heating load"" or cooling conditions. If the ""No"" is selected, then the fan will not run unless there is a heating load. If the fan does not run, this effectively shuts the unit heater system off when there is no heating load. If the ""Yes"" is selected, the unit heater is available and has a ConstantVolume fan, or has an OnOff fan with ""Supply Air Fan Operating Mode Schedule"" value greater than zero, then the fan will always run regardless of the zone load.")]
        [JsonProperty("supply_air_fan_operation_during_no_heating")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitHeater_SupplyAirFanOperationDuringNoHeating SupplyAirFanOperationDuringNoHeating { get; set; } = (ZoneHVAC_UnitHeater_SupplyAirFanOperationDuringNoHeating)Enum.Parse(typeof(ZoneHVAC_UnitHeater_SupplyAirFanOperationDuringNoHeating), "No");
        

        [Description("Not used when heating coil is gas or electric")]
        [JsonProperty("maximum_hot_water_or_steam_flow_rate")]
        public string MaximumHotWaterOrSteamFlowRate { get; set; } = "";
        

        [Description("Not used when heating coil is gas or electric")]
        [JsonProperty("minimum_hot_water_or_steam_flow_rate")]
        public System.Nullable<float> MinimumHotWaterOrSteamFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_convergence_tolerance")]
        public System.Nullable<float> HeatingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty("availability_manager_list_name")]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty("design_specification_zonehvac_sizing_object_name")]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}