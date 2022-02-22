using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Unit ventilator. Forced-convection ventilation unit with supply fan (constant-vol" +
                 "ume or variable-volume), optional chilled water cooling coil, optional heating c" +
                 "oil (gas, electric, hot water, or steam) and controllable outdoor air mixer.")]
    public class ZoneHVAC_UnitVentilator : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_supply_air_flow_rate")]
        public string MaximumSupplyAirFlowRate { get; set; } = "";
        

        [JsonProperty("outdoor_air_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitVentilator_OutdoorAirControlType OutdoorAirControlType { get; set; } = (ZoneHVAC_UnitVentilator_OutdoorAirControlType)Enum.Parse(typeof(ZoneHVAC_UnitVentilator_OutdoorAirControlType), "FixedAmount");
        

        [JsonProperty("minimum_outdoor_air_flow_rate")]
        public string MinimumOutdoorAirFlowRate { get; set; } = "";
        

        [Description("schedule values multiply the minimum outdoor air flow rate")]
        [JsonProperty("minimum_outdoor_air_schedule_name")]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty("maximum_outdoor_air_flow_rate")]
        public string MaximumOutdoorAirFlowRate { get; set; } = "";
        

        [Description("that this depends on the control type as to whether it is a fraction or temperatu" +
                     "re")]
        [JsonProperty("maximum_outdoor_air_fraction_or_temperature_schedule_name")]
        public string MaximumOutdoorAirFractionOrTemperatureScheduleName { get; set; } = "";
        

        [Description("Inlet node name must be zone exhaust node name if there is no DOA Mixer, or if th" +
                     "e unit ventilator is connected DOA, then the air inlet node name must be the mix" +
                     "er outlet air node name for InletSide mixer connection.")]
        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Outlet node name must be zone inlet node name if there is no DOA Mixer, or if the" +
                     " unit ventilator is connected DOA, then the air outlet node name must be the mix" +
                     "er secondary air inlet node name for SupplySide mixer connection.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("this field is left blank only if the Unit Ventilator is connected to a central de" +
                     "dicated outdoor air (DOA) via AirTerminal:SingleDuct:Mixer object")]
        [JsonProperty("outdoor_air_node_name")]
        public string OutdoorAirNodeName { get; set; } = "";
        

        [Description("this field is left blank only if the Unit Ventilator is connected to a central de" +
                     "dicated outdoor air (DOA) via AirTerminal:SingleDuct:Mixer object")]
        [JsonProperty("exhaust_air_node_name")]
        public string ExhaustAirNodeName { get; set; } = "";
        

        [Description("inlet to coils this field is left blank only if the Unit Ventilator is connected " +
                     "to a central dedicated outdoor air (DOA) via AirTerminal:SingleDuct:Mixer object" +
                     "")]
        [JsonProperty("mixed_air_node_name")]
        public string MixedAirNodeName { get; set; } = "";
        

        [Description("Allowable fan types are Fan:ConstantVolume, Fan:OnOff, Fan:VariableVolume, and Fa" +
                     "n:SystemModel")]
        [JsonProperty("supply_air_fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitVentilator_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_UnitVentilator_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_UnitVentilator_SupplyAirFanObjectType), "FanConstantVolume");
        

        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty("coil_option")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitVentilator_CoilOption CoilOption { get; set; } = (ZoneHVAC_UnitVentilator_CoilOption)Enum.Parse(typeof(ZoneHVAC_UnitVentilator_CoilOption), "Cooling");
        

        [Description(@"Enter the name of a schedule that controls fan operation. Schedule name values of 0 denote cycling fan operation (fan cycles with cooling/heating coil). Schedule values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation). The fan operating mode defaults to cycling fan operation if this input field is left blank.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty("heating_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitVentilator_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (ZoneHVAC_UnitVentilator_HeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_UnitVentilator_HeatingCoilObjectType), "CoilHeatingElectric");
        

        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [JsonProperty("heating_convergence_tolerance")]
        public System.Nullable<float> HeatingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitVentilator_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (ZoneHVAC_UnitVentilator_CoolingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_UnitVentilator_CoolingCoilObjectType), "CoilCoolingWater");
        

        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

        [JsonProperty("cooling_convergence_tolerance")]
        public System.Nullable<float> CoolingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty("availability_manager_list_name")]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty("design_specification_zonehvac_sizing_object_name")]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}