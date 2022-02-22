using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    [Description(@"Unitary system, heating and cooling with constant volume supply fan (continuous or cycling), direct expansion (DX) cooling coil, heating coil (gas, electric, hot water, steam, or DX air-to-air heat pump) and bypass damper for variable volume flow to terminal units. Used with AirTerminal:SingleDuct:VAV:HeatAndCool:Reheat or AirTerminal:SingleDuct:VAV:HeatAndCool:NoReheat.")]
    public class AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. Enter the availability schedule name. Schedule values of zero denote system is Off. Non-zero schedule values denote system is available to operate.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter the system air flow rate during cooling operation or specify autosize.")]
        [JsonProperty("cooling_supply_air_flow_rate")]
        public string CoolingSupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the system air flow rate during heating operation or specify autosize.")]
        [JsonProperty("heating_supply_air_flow_rate")]
        public string HeatingSupplyAirFlowRate { get; set; } = "";
        

        [Description(@"Only used when the supply air fan operating mode is continuous (see field Supply air fan operating mode schedule name). This system air flow rate is used when no heating or cooling is required and the coils are off. If this field is left blank or zero, the system air flow rate from the previous on cycle (either cooling or heating) is used.")]
        [JsonProperty("no_load_supply_air_flow_rate")]
        public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

        [Description("Enter the outdoor air flow rate during cooling operation or specify autosize.")]
        [JsonProperty("cooling_outdoor_air_flow_rate")]
        public string CoolingOutdoorAirFlowRate { get; set; } = "";
        

        [Description("Enter the outdoor air flow rate during heating operation or specify autosize.")]
        [JsonProperty("heating_outdoor_air_flow_rate")]
        public string HeatingOutdoorAirFlowRate { get; set; } = "";
        

        [Description(@"Only used when the supply air fan operating mode is continuous (see field Supply air fan operating mode schedule name). This outdoor air flow rate is used when no heating or cooling is required and the coils are off. If this field is left blank or zero, the outdoor air flow rate from the previous on cycle (either cooling or heating) is used.")]
        [JsonProperty("no_load_outdoor_air_flow_rate")]
        public string NoLoadOutdoorAirFlowRate { get; set; } = "";
        

        [Description("Enter the name of a schedule that contains multipliers for the outdoor air flow r" +
                     "ates. Schedule values must be from 0 to 1. If field is left blank, model assumes" +
                     " multiplier is 1 for the entire simulation period.")]
        [JsonProperty("outdoor_air_flow_rate_multiplier_schedule_name")]
        public string OutdoorAirFlowRateMultiplierScheduleName { get; set; } = "";
        

        [Description("Enter the name of the unitary system\'s air inlet node.")]
        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Enter the name of the bypass duct mixer node. This name should be the name of the" +
                     " return air node for the outdoor air mixer associated with this system. This nod" +
                     "e name must be different from the air inlet node name.")]
        [JsonProperty("bypass_duct_mixer_node_name")]
        public string BypassDuctMixerNodeName { get; set; } = "";
        

        [Description(@"Enter the name of the bypass duct splitter node. This splitter air node is the outlet node of the last component in this unitary system. For blow through fan placement, the splitter air node is the outlet node of the heating coil. For draw through fan placement, the splitter node is the outlet node of the supply air fan.")]
        [JsonProperty("bypass_duct_splitter_node_name")]
        public string BypassDuctSplitterNodeName { get; set; } = "";
        

        [Description("Enter the name of the unitary system\'s air outlet node.")]
        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("currently only one type OutdoorAir:Mixer object is available.")]
        [JsonProperty("outdoor_air_mixer_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_OutdoorAirMixerObjectType OutdoorAirMixerObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_OutdoorAirMixerObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_OutdoorAirMixerObjectType), "OutdoorAirMixer");
        

        [Description("Enter the name of the outdoor air mixer used with this unitary system.")]
        [JsonProperty("outdoor_air_mixer_name")]
        public string OutdoorAirMixerName { get; set; } = "";
        

        [Description("Specify the type of supply air fan used in this unitary system.")]
        [JsonProperty("supply_air_fan_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanObjectType), "FanConstantVolume");
        

        [Description("Enter the name of the supply air fan used in this unitary system.")]
        [JsonProperty("supply_air_fan_name")]
        public string SupplyAirFanName { get; set; } = "";
        

        [Description("Specify supply air fan placement as either blow through or draw through. BlowThro" +
                     "ugh means the supply air fan is located before the cooling coil. DrawThrough mea" +
                     "ns the supply air fan is located after the heating coil.")]
        [JsonProperty("supply_air_fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanPlacement SupplyAirFanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanPlacement), "BlowThrough");
        

        [Description(@"Enter the name of a schedule to control the supply air fan. Schedule Name values of zero mean that the supply air fan will cycle off if there is no cooling or heating load in any of the zones being served by this system. Non-zero schedule values mean that the supply air fan will operate continuously even if there is no cooling or heating load in any of the zones being served. If this field is left blank, the supply air fan will operate continuously for the entire simulation period.")]
        [JsonProperty("supply_air_fan_operating_mode_schedule_name")]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description("Specify the type of cooling coil used in this unitary system.")]
        [JsonProperty("cooling_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [Description("Enter the name of the cooling coil used in this unitary system.")]
        [JsonProperty("cooling_coil_name")]
        public string CoolingCoilName { get; set; } = "";
        

        [Description("works with DX, gas, electric, hot water and steam heating coils Specify the type " +
                     "of heating coil used in this unitary system.")]
        [JsonProperty("heating_coil_object_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_HeatingCoilObjectType), "CoilHeatingDXSingleSpeed");
        

        [Description("Enter the name of the heating coil used in this unitary system.")]
        [JsonProperty("heating_coil_name")]
        public string HeatingCoilName { get; set; } = "";
        

        [Description(@"CoolingPriority = system provides cooling if any zone requires cooling. HeatingPriority = system provides heating if any zone requires heating. ZonePriority = system controlled based on the total number of zones requiring cooling or heating (highest number of zones in cooling or heating determines the system's operating mode). LoadPriority = system provides cooling or heating based on total zone loads.")]
        [JsonProperty("priority_control_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode PriorityControlMode { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode), "ZonePriority");
        

        [Description("Specify the minimum outlet air temperature allowed for this unitary system during" +
                     " cooling operation. This value should be less than the maximum outlet air temper" +
                     "ature during heating operation.")]
        [JsonProperty("minimum_outlet_air_temperature_during_cooling_operation")]
        public System.Nullable<float> MinimumOutletAirTemperatureDuringCoolingOperation { get; set; } = (System.Nullable<float>)Single.Parse("8", CultureInfo.InvariantCulture);
        

        [Description("Specify the maximum outlet air temperature allowed for this unitary system during" +
                     " heating operation. This value should be greater than the minimum outlet air tem" +
                     "perature during cooling operation.")]
        [JsonProperty("maximum_outlet_air_temperature_during_heating_operation")]
        public System.Nullable<float> MaximumOutletAirTemperatureDuringHeatingOperation { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"None = meet sensible load only. Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only with Coil:Cooling:DX:TwoStageWithHumidityControlMode. CoolReheat = cool beyond the Dry-Bulb temperature setpoint as required to meet the humidity setpoint. Valid only with Coil:Cooling:DX:TwoStageWithHumidityControlMode. For all dehumidification controls, the max humidity setpoint on this unitary system's air outlet node is used. This must be set using ZoneControl:Humidistat and SetpointManager:SingleZone:Humidity:Maximum, SetpointManager:MultiZone:Humidity:Maximum or SetpointManager:MultiZone:MaximumHumidity:Average objects.")]
        [JsonProperty("dehumidification_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_DehumidificationControlType), "None");
        

        [Description("Enter the name of the bypass duct node connected to a plenum or mixer. This field" +
                     " is required when this HVAC System is connected to a plenum or mixer. This is a " +
                     "different node name than that entered in the Bypass Duct Splitter Node Name fiel" +
                     "d.")]
        [JsonProperty("plenum_or_mixer_inlet_node_name")]
        public string PlenumOrMixerInletNodeName { get; set; } = "";
        

        [Description("This is the minimum amount of time the unit operates in cooling or heating mode b" +
                     "efore changing modes.")]
        [JsonProperty("minimum_runtime_before_operating_mode_change")]
        public System.Nullable<float> MinimumRuntimeBeforeOperatingModeChange { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
    }
}