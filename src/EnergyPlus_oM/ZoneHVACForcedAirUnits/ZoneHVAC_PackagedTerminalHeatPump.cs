using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description(@"Packaged terminal heat pump (PTHP). Forced-convection heating-cooling unit with supply fan, direct expansion (DX) cooling coil, DX heating coil (air-to-air heat pump), supplemental heating coil (gas, electric, hot water, or steam), and fixed-position outdoor air mixer.")]
    [JsonObject("ZoneHVAC:PackagedTerminalHeatPump")]
    public class ZoneHVAC_PackagedTerminalHeatPump : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available. Schedule va" +
                     "lues of 0 denote the unit is off.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Air inlet node for the PTHP must be a zone air exhaust node.")]
        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Air outlet node for the PTHP must be a zone air inlet node.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Currently only one OutdoorAir:Mixer object type is available. This field should b" +
                     "e left blank if the PTHP is connected to central dedicated outdoor air through a" +
                     "n AirTerminal:SingleDuct:Mixer object.")]
        [JsonProperty("outdoor_air_mixer_object_type")]
        public ZoneHVAC_PackagedTerminalHeatPump_OutdoorAirMixerObjectType OutdoorAirMixerObjectType { get; set; } = (ZoneHVAC_PackagedTerminalHeatPump_OutdoorAirMixerObjectType)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalHeatPump_OutdoorAirMixerObjectType), "OutdoorAirMixer");
        

        [Description(@"If this field is blank, the OutdoorAir:Mixer is not used. This optional field specifies the name of the OutdoorAir:Mixer object. When used, this name needs to match name of the OutdoorAir:Mixer object. This field should be left blank if the PTHP is connected to central dedicated outdoor air through an AirTerminal:SingleDuct:Mixer object.")]
        [JsonProperty("outdoor_air_mixer_name")]
        public string OutdoorAirMixerName { get; set; } = "";
        

        [Description("Must be less than or equal to fan size.")]
        [JsonProperty("cooling_supply_air_flow_rate")]
        public string CoolingSupplyAirFlowRate { get; set; } = "";
        

        [Description("Must be less than or equal to fan size.")]
        [JsonProperty("heating_supply_air_flow_rate")]
        public string HeatingSupplyAirFlowRate { get; set; } = "";
        

        [Description(@"Must be less than or equal to fan size. Only used when heat pump fan operating mode is continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used.")]
        [JsonProperty("no_load_supply_air_flow_rate")]
        public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

        [Description("Must be less than or equal to supply air flow rate during cooling operation. This" +
                     " field is set to zero flow when the PTHP is connected to central dedicated outdo" +
                     "or air through air terminal single duct mixer object.")]
        [JsonProperty("cooling_outdoor_air_flow_rate")]
        public string CoolingOutdoorAirFlowRate { get; set; } = "";
        

        [Description("Must be less than or equal to supply air flow rate during heating operation. This" +
                     " field is set to zero flow when the PTHP is connected to central dedicated outdo" +
                     "or air through air terminal single duct mixer object.")]
        [JsonProperty("heating_outdoor_air_flow_rate")]
        public string HeatingOutdoorAirFlowRate { get; set; } = "";
        

        [Description(@"Only used when heat pump Fan operating mode is continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the outdoor air flow rate from the previous on cycle (either cooling or heating) is used. This field is set to zero flow when the PTHP is connected to central dedicated outdoor air through air terminal single duct mixer object.")]
        [JsonProperty("no_load_outdoor_air_flow_rate")]
        public string NoLoadOutdoorAirFlowRate { get; set; } = "";
        

        [Description("Fan:ConstantVolume only works with fan operating mode is continuous.")]
        [JsonProperty("supply_air_fan_object_type")]
        public ZoneHVAC_PackagedTerminalHeatPump_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_PackagedTerminalHeatPump_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalHeatPump_SupplyAirFanObjectType), "FanConstantVolume");
        

        [Description("Needs to match a fan object.")]
        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [Description("Only works with Coil:Heating:DX:SingleSpeed or Coil:Heating:DX:VariableSpeed.")]
        [JsonProperty("heating_coil_object_type")]
        public ZoneHVAC_PackagedTerminalHeatPump_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (ZoneHVAC_PackagedTerminalHeatPump_HeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalHeatPump_HeatingCoilObjectType), "CoilHeatingDXSingleSpeed");
        

        [Description("Needs to match in the DX Heating Coil object.")]
        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [Description("Defines Heating convergence tolerance as a fraction of Heating load to be met.")]
        [JsonProperty("heating_convergence_tolerance")]
        public System.Nullable<float> HeatingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("Only works with Coil:Cooling:DX:SingleSpeed or CoilSystem:Cooling:DX:HeatExchange" +
                     "rAssisted or Coil:Cooling:DX:VariableSpeed.")]
        [JsonProperty("cooling_coil_object_type")]
        public ZoneHVAC_PackagedTerminalHeatPump_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (ZoneHVAC_PackagedTerminalHeatPump_CoolingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalHeatPump_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [Description("Needs to match in the DX Cooling Coil object.")]
        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

        [Description("Defines Cooling convergence tolerance as a fraction of the Cooling load to be met" +
                     ".")]
        [JsonProperty("cooling_convergence_tolerance")]
        public System.Nullable<float> CoolingConvergenceTolerance { get; set; } = (System.Nullable<float>)Single.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("works with gas, electric, hot water and steam heating coil.")]
        [JsonProperty("supplemental_heating_coil_object_type")]
        public ZoneHVAC_PackagedTerminalHeatPump_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (ZoneHVAC_PackagedTerminalHeatPump_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalHeatPump_SupplementalHeatingCoilObjectType), "CoilHeatingElectric");
        

        [Description("Needs to match in the supplemental heating coil object.")]
        [JsonProperty("supplemental_heating_coil_name")]
        public string SupplementalHeatingCoilName { get; set; } = "";
        

        [Description("Supply air temperature from the supplemental heater will not exceed this value.")]
        [JsonProperty("maximum_supply_air_temperature_from_supplemental_heater")]
        public string MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = "";
        

        [Description("Supplemental heater will not operate when outdoor temperature exceeds this value." +
                     "")]
        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

        [Description("Select fan placement as either blow through or draw through.")]
        [JsonProperty("fan_placement")]
        public ZoneHVAC_PackagedTerminalHeatPump_FanPlacement FanPlacement { get; set; } = (ZoneHVAC_PackagedTerminalHeatPump_FanPlacement)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalHeatPump_FanPlacement), "DrawThrough");
        

        [Description(@"Enter the name of a schedule that controls fan operation. Schedule values of 0 denote cycling fan operation (fan cycles with cooling or heating coil). Schedule Name values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation). The fan operating mode defaults to cycling fan operation if this field is left blank.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty("availability_manager_list_name")]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty("design_specification_zonehvac_sizing_object_name")]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
        

        [JsonProperty("capacity_control_method")]
        public ZoneHVAC_PackagedTerminalHeatPump_CapacityControlMethod CapacityControlMethod { get; set; } = (ZoneHVAC_PackagedTerminalHeatPump_CapacityControlMethod)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalHeatPump_CapacityControlMethod), "None");
        

        [Description("For Capacity Control Method = SingleZoneVAV, enter the minimum air temperature li" +
                     "mit for reduced fan speed.")]
        [JsonProperty("minimum_supply_air_temperature_in_cooling_mode")]
        public string MinimumSupplyAirTemperatureInCoolingMode { get; set; } = (System.String)"Autosize";
        

        [Description("For Capacity Control Method = SingleZoneVAV, enter the maximum air temperature li" +
                     "mit for reduced fan speed.")]
        [JsonProperty("maximum_supply_air_temperature_in_heating_mode")]
        public string MaximumSupplyAirTemperatureInHeatingMode { get; set; } = (System.String)"Autosize";
    }
}