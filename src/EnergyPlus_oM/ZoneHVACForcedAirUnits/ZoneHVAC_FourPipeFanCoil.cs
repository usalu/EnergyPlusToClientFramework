using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Four pipe fan coil system. Forced-convection hydronic heating-cooling unit with s" +
                 "upply fan, hot water heating coil, chilled water cooling coil, and fixed-positio" +
                 "n outdoor air mixer.")]
    [JsonObject("ZoneHVAC:FourPipeFanCoil")]
    public class ZoneHVAC_FourPipeFanCoil : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("capacity_control_method")]
        public EmptyNoYes CapacityControlMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("maximum_supply_air_flow_rate")]
        public string MaximumSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("low_speed_supply_air_flow_ratio")]
        public System.Nullable<float> LowSpeedSupplyAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.33", CultureInfo.InvariantCulture);
        

        [Description("Medium Speed Supply Air Flow Ratio should be greater than Low Speed Supply Air Fl" +
                     "ow Ratio")]
        [JsonProperty("medium_speed_supply_air_flow_ratio")]
        public System.Nullable<float> MediumSpeedSupplyAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.66", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_air_flow_rate")]
        public string MaximumOutdoorAirFlowRate { get; set; } = "";
        

        [Description("Value of schedule multiplies maximum outdoor air flow rate")]
        [JsonProperty("outdoor_air_schedule_name")]
        public string OutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Currently only one type OutdoorAir:Mixer object is available. This field should b" +
                     "e left blank if the FanCoil is connected to central dedicated outdoor air throug" +
                     "h an AirTerminal:SingleDuct:Mixer object.")]
        [JsonProperty("outdoor_air_mixer_object_type")]
        public EmptyNoYes OutdoorAirMixerObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description(@"If this field is blank, the OutdoorAir:Mixer is not used. This optional field specifies the name of the OutdoorAir:Mixer object. When used, this name needs to match name of the OutdoorAir:Mixer object. This field should be left blank if the FanCoil is connected to central dedicated outdoor air through an AirTerminal:SingleDuct:Mixer object.")]
        [JsonProperty("outdoor_air_mixer_name")]
        public string OutdoorAirMixerName { get; set; } = "";
        

        [Description(@"Fan type must be according to capacity control method (see I/O) For ConstantFanVariableFlow a Fan:OnOff or Fan:ConstantVolume is valid. For CyclingFan a Fan:OnOff is valid. For VariableFanVariableFlow or VariableFanConstantFlow a Fan:VariableVolume is valid. For ASHRAE90.1 a Fan:OnOff or Fan:VariableVolume is valid. Fan:SystemModel is valid for all capacity control methods. The fan's inlet node should be the same as the outdoor air mixer's mixed air node.")]
        [JsonProperty("supply_air_fan_object_type")]
        public EmptyNoYes SupplyAirFanObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty("cooling_coil_object_type")]
        public EmptyNoYes CoolingCoilObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

        [JsonProperty("maximum_cold_water_flow_rate")]
        public string MaximumColdWaterFlowRate { get; set; } = "";
        

        [JsonProperty("minimum_cold_water_flow_rate")]
        public System.Nullable<float> MinimumColdWaterFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_convergence_tolerance")]
        public System.Nullable<float> CoolingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_coil_object_type")]
        public EmptyNoYes HeatingCoilObjectType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [JsonProperty("maximum_hot_water_flow_rate")]
        public string MaximumHotWaterFlowRate { get; set; } = "";
        

        [JsonProperty("minimum_hot_water_flow_rate")]
        public System.Nullable<float> MinimumHotWaterFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_convergence_tolerance")]
        public System.Nullable<float> HeatingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty("availability_manager_list_name")]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty("design_specification_zonehvac_sizing_object_name")]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
        

        [Description(@"Enter the name of a schedule that controls fan operation. Schedule Name values of 0 denote cycling fan operation (fan cycles with cooling coil). Schedule values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation). The fan operating mode defaults to cycling fan operation if this field is left blank. This input field is currently used with MultiStageFan capacity control method")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description("For Capacity Control Method = ASHRAE90VariableFan, enter the minimum air temperat" +
                     "ure in cooling mode. Leave this field blank or enter 0 to control to the zone lo" +
                     "ad per ASHRAE 90.1. In this case, a zone sizing simulation is required.")]
        [JsonProperty("minimum_supply_air_temperature_in_cooling_mode")]
        public string MinimumSupplyAirTemperatureInCoolingMode { get; set; } = (System.String)"Autosize";
        

        [Description("For Capacity Control Method = ASHRAE90VariableFan, enter the maximum air temperat" +
                     "ure in heating mode. Leave this field blank or enter 0 to control to the zone lo" +
                     "ad per ASHRAE 90.1. In this case, a zone sizing simulation is required.")]
        [JsonProperty("maximum_supply_air_temperature_in_heating_mode")]
        public string MaximumSupplyAirTemperatureInHeatingMode { get; set; } = (System.String)"Autosize";
    }
}