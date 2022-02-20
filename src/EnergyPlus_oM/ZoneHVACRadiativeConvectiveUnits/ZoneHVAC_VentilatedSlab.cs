using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("Ventilated slab system where outdoor air flows through hollow cores in a building" +
                 " surface (wall, ceiling, or floor).")]
    [JsonObject("ZoneHVAC:VentilatedSlab")]
    public class ZoneHVAC_VentilatedSlab : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("(name of zone system is serving)")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("(name of surface system is embedded in) or list of surfaces")]
        [JsonProperty("surface_name_or_radiant_surface_group_name")]
        public string SurfaceNameOrRadiantSurfaceGroupName { get; set; } = "";
        

        [JsonProperty("maximum_air_flow_rate")]
        public string MaximumAirFlowRate { get; set; } = "";
        

        [JsonProperty("outdoor_air_control_type")]
        public EmptyNoYes OutdoorAirControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("minimum_outdoor_air_flow_rate")]
        public string MinimumOutdoorAirFlowRate { get; set; } = "";
        

        [JsonProperty("minimum_outdoor_air_schedule_name")]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [Description("schedule values multiply the minimum outdoor air flow rate")]
        [JsonProperty("maximum_outdoor_air_flow_rate")]
        public string MaximumOutdoorAirFlowRate { get; set; } = "";
        

        [Description("Note that this depends on the control type as to whether schedule values are a fr" +
                     "action or temperature")]
        [JsonProperty("maximum_outdoor_air_fraction_or_temperature_schedule_name")]
        public string MaximumOutdoorAirFractionOrTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("system_configuration_type")]
        public EmptyNoYes SystemConfigurationType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SlabOnly");
        

        [JsonProperty("hollow_core_inside_diameter")]
        public System.Nullable<float> HollowCoreInsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

        [Description("(length of core cavity embedded in surface)")]
        [JsonProperty("hollow_core_length")]
        public System.Nullable<float> HollowCoreLength { get; set; } = null;
        

        [Description("flow will be divided evenly among the cores")]
        [JsonProperty("number_of_cores")]
        public System.Nullable<float> NumberOfCores { get; set; } = null;
        

        [Description("(temperature on which unit is controlled)")]
        [JsonProperty("temperature_control_type")]
        public EmptyNoYes TemperatureControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "OutdoorDryBulbTemperature");
        

        [Description(@"Air and control temperatures for heating work together to provide a linear function that determines the air temperature sent to the radiant system. The current control temperature (see A14) is compared to the high and low control temperatures at the current time. If the control temperature is above the high temperature, then the inlet air temperature is set to the low air temperature. If the control temperature is below the low temperature, then the inlet air temperature is set to the high air temperature. If the control temperature is between the high and low value, then the inlet air temperature is linearly interpolated between the low and high air temperature values.")]
        [JsonProperty("heating_high_air_temperature_schedule_name")]
        public string HeatingHighAirTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("heating_low_air_temperature_schedule_name")]
        public string HeatingLowAirTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("heating_high_control_temperature_schedule_name")]
        public string HeatingHighControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("heating_low_control_temperature_schedule_name")]
        public string HeatingLowControlTemperatureScheduleName { get; set; } = "";
        

        [Description("See note for heating high air temperature schedule above for interpretation infor" +
                     "mation (or see the Input/Output Reference).")]
        [JsonProperty("cooling_high_air_temperature_schedule_name")]
        public string CoolingHighAirTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("cooling_low_air_temperature_schedule_name")]
        public string CoolingLowAirTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("cooling_high_control_temperature_schedule_name")]
        public string CoolingHighControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("cooling_low_control_temperature_schedule_name")]
        public string CoolingLowControlTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the zone return air inlet to the ventilated slab system outdoor air mixer" +
                     ". This node is typically a zone exhaust node (do not connect to \"Zone Return Air" +
                     " Node\").")]
        [JsonProperty("return_air_node_name")]
        public string ReturnAirNodeName { get; set; } = "";
        

        [Description("This is the node entering the slab or series of slabs after the fan and coil(s).")]
        [JsonProperty("slab_in_node_name")]
        public string SlabInNodeName { get; set; } = "";
        

        [Description("This is the node name exiting the slab. This node is typically a zone inlet node." +
                     " Leave blank when the system configuration is SlabOnly or SeriesSlabs.")]
        [JsonProperty("zone_supply_air_node_name")]
        public string ZoneSupplyAirNodeName { get; set; } = "";
        

        [Description("This node is the outdoor air inlet to the ventilated slab oa mixer. This node sho" +
                     "uld also be specified in an OutdoorAir:Node or OutdoorAir:NodeList object.")]
        [JsonProperty("outdoor_air_node_name")]
        public string OutdoorAirNodeName { get; set; } = "";
        

        [Description("This node is the relief air node from the ventilated slab outdoor air mixer.")]
        [JsonProperty("relief_air_node_name")]
        public string ReliefAirNodeName { get; set; } = "";
        

        [Description("This is the node name leaving the outdoor air mixer and entering the fan and coil" +
                     "(s).")]
        [JsonProperty("outdoor_air_mixer_outlet_node_name")]
        public string OutdoorAirMixerOutletNodeName { get; set; } = "";
        

        [Description("This is the node name of the fan outlet.")]
        [JsonProperty("fan_outlet_node_name")]
        public string FanOutletNodeName { get; set; } = "";
        

        [Description("Allowable fan types are Fan:SystemModel and Fan:ConstantVolume")]
        [JsonProperty("fan_name")]
        public string FanName { get; set; } = "";
        

        [JsonProperty("coil_option_type")]
        public EmptyNoYes CoilOptionType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("heating_coil_object_type")]
        public EmptyNoYes HeatingCoilObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [JsonProperty("hot_water_or_steam_inlet_node_name")]
        public string HotWaterOrSteamInletNodeName { get; set; } = "";
        

        [JsonProperty("cooling_coil_object_type")]
        public EmptyNoYes CoolingCoilObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

        [JsonProperty("cold_water_inlet_node_name")]
        public string ColdWaterInletNodeName { get; set; } = "";
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty("availability_manager_list_name")]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty("design_specification_zonehvac_sizing_object_name")]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}