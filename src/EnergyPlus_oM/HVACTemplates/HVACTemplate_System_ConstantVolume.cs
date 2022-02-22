using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Constant Air Volume air loop with optional chilled water cooling coil, optional h" +
                 "eating coil and optional preheat.")]
    public class HVACTemplate_System_ConstantVolume : BHoMObject, IEnergyPlusClass
    {
        

        [Description("If blank, always on;  Schedule is used in availability manager and fan scheduling" +
                     ". Also see \"Night Cycle Control\" field.")]
        [JsonProperty("system_availability_schedule_name")]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
                     "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
                     "value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty("supply_fan_maximum_flow_rate")]
        public string SupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("supply_fan_total_efficiency")]
        public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_delta_pressure")]
        public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("600", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_efficiency")]
        public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_ConstantVolume_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_SupplyFanPlacement), "DrawThrough");
        

        [JsonProperty("cooling_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_ConstantVolume_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_CoolingCoilType), "ChilledWater");
        

        [Description("If blank, always on")]
        [JsonProperty("cooling_coil_availability_schedule_name")]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("cooling_coil_setpoint_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_CoolingCoilSetpointControlType CoolingCoilSetpointControlType { get; set; } = (HVACTemplate_System_ConstantVolume_CoolingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_CoolingCoilSetpointControlType), "FixedSetpoint");
        

        [Description("name of the HVACTemplate:ZoneConstantVolume object that contains the cooling ther" +
                     "mostat when Cooling Coil Setpoint Control Type = ControlZone")]
        [JsonProperty("cooling_coil_control_zone_name")]
        public string CoolingCoilControlZoneName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Nam" +
                     "e is specified.")]
        [JsonProperty("cooling_coil_design_setpoint_temperature")]
        public System.Nullable<float> CoolingCoilDesignSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("cooling_coil_setpoint_schedule_name")]
        public string CoolingCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("cooling_coil_setpoint_at_outdoor_dry_bulb_low")]
        public System.Nullable<float> CoolingCoilSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control. Defaults are 15.6C (60F) " +
                     "at 15.6C (60F) to 12.8C (55F) at 23.3C (74F)")]
        [JsonProperty("cooling_coil_reset_outdoor_dry_bulb_low")]
        public System.Nullable<float> CoolingCoilResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("cooling_coil_setpoint_at_outdoor_dry_bulb_high")]
        public System.Nullable<float> CoolingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("cooling_coil_reset_outdoor_dry_bulb_high")]
        public System.Nullable<float> CoolingCoilResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("23.3", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_ConstantVolume_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HeatingCoilType), "HotWater");
        

        [Description("If blank, always on")]
        [JsonProperty("heating_coil_availability_schedule_name")]
        public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("heating_coil_setpoint_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_HeatingCoilSetpointControlType HeatingCoilSetpointControlType { get; set; } = (HVACTemplate_System_ConstantVolume_HeatingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HeatingCoilSetpointControlType), "FixedSetpoint");
        

        [Description("name of the HVACTemplate:ZoneConstantVolume object that contains the heating ther" +
                     "mostat")]
        [JsonProperty("heating_coil_control_zone_name")]
        public string HeatingCoilControlZoneName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Nam" +
                     "e is specified.")]
        [JsonProperty("heating_coil_design_setpoint")]
        public System.Nullable<float> HeatingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("heating_coil_setpoint_schedule_name")]
        public string HeatingCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_low")]
        public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control. Defaults are 15.6C (60F) " +
                     "at 15.6C (60F) to 12.8C (55F) at 23.3C (74F)")]
        [JsonProperty("heating_coil_reset_outdoor_dry_bulb_low")]
        public System.Nullable<float> HeatingCoilResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("7.8", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_high")]
        public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("heating_coil_reset_outdoor_dry_bulb_high")]
        public System.Nullable<float> HeatingCoilResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_coil_capacity")]
        public string HeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("gas_heating_coil_efficiency")]
        public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("gas_heating_coil_parasitic_electric_load")]
        public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("preheat_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_PreheatCoilType PreheatCoilType { get; set; } = (HVACTemplate_System_ConstantVolume_PreheatCoilType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_PreheatCoilType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty("preheat_coil_availability_schedule_name")]
        public string PreheatCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Preheat Coil Setpoint Schedule Nam" +
                     "e specified.")]
        [JsonProperty("preheat_coil_design_setpoint")]
        public System.Nullable<float> PreheatCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("7.2", CultureInfo.InvariantCulture);
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("preheat_coil_setpoint_schedule_name")]
        public string PreheatCoilSetpointScheduleName { get; set; } = "";
        

        [JsonProperty("gas_preheat_coil_efficiency")]
        public System.Nullable<float> GasPreheatCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("gas_preheat_coil_parasitic_electric_load")]
        public System.Nullable<float> GasPreheatCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_air_flow_rate")]
        public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("minimum_outdoor_air_flow_rate")]
        public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Schedule values multiply the Minimum Outdoor Air Flow Rate If blank, multiplier i" +
                     "s always one")]
        [JsonProperty("minimum_outdoor_air_schedule_name")]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty("economizer_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_ConstantVolume_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_EconomizerType), "NoEconomizer");
        

        [Description("Outdoor temperature above which economizer is disabled and heat recovery is enabl" +
                     "ed (if available). Blank means no limit.")]
        [JsonProperty("economizer_upper_temperature_limit")]
        public System.Nullable<float> EconomizerUpperTemperatureLimit { get; set; } = null;
        

        [Description("Outdoor temperature below which economizer is disabled and heat recovery is enabl" +
                     "ed (if available). Blank means no limit.")]
        [JsonProperty("economizer_lower_temperature_limit")]
        public System.Nullable<float> EconomizerLowerTemperatureLimit { get; set; } = null;
        

        [Description("Outdoor enthalpy above which economizer is disabled and heat recovery is enabled " +
                     "(if available). Blank means no limit.")]
        [JsonProperty("economizer_upper_enthalpy_limit")]
        public System.Nullable<float> EconomizerUpperEnthalpyLimit { get; set; } = null;
        

        [Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
                     "economizer control type. No input or blank input means this limit is not operati" +
                     "ve. Limit is applied regardless of economizer control type.")]
        [JsonProperty("economizer_maximum_limit_dewpoint_temperature")]
        public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

        [Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
        [JsonProperty("supply_plenum_name")]
        public string SupplyPlenumName { get; set; } = "";
        

        [Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
        [JsonProperty("return_plenum_name")]
        public string ReturnPlenumName { get; set; } = "";
        

        [JsonProperty("night_cycle_control")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_NightCycleControl NightCycleControl { get; set; } = (HVACTemplate_System_ConstantVolume_NightCycleControl)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_NightCycleControl), "StayOff");
        

        [Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
        [JsonProperty("night_cycle_control_zone_name")]
        public string NightCycleControlZoneName { get; set; } = "";
        

        [JsonProperty("heat_recovery_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_ConstantVolume_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HeatRecoveryType), "None");
        

        [JsonProperty("sensible_heat_recovery_effectiveness")]
        public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("latent_heat_recovery_effectiveness")]
        public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_recovery_heat_exchanger_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_HeatRecoveryHeatExchangerType HeatRecoveryHeatExchangerType { get; set; } = (HVACTemplate_System_ConstantVolume_HeatRecoveryHeatExchangerType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HeatRecoveryHeatExchangerType), "Plate");
        

        [JsonProperty("heat_recovery_frost_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_HeatRecoveryFrostControlType HeatRecoveryFrostControlType { get; set; } = (HVACTemplate_System_ConstantVolume_HeatRecoveryFrostControlType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HeatRecoveryFrostControlType), "None");
        

        [Description("None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint as " +
                     "required to meet the humidity setpoint.")]
        [JsonProperty("dehumidification_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_ConstantVolume_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_DehumidificationControlType), "None");
        

        [Description("Zone name where humidistat is located")]
        [JsonProperty("dehumidification_control_zone_name")]
        public string DehumidificationControlZoneName { get; set; } = "";
        

        [Description("Zone relative humidity setpoint in percent (0 to 100) Ignored if Dehumidification" +
                     " Relative Humidity Setpoint Schedule specified below")]
        [JsonProperty("dehumidification_relative_humidity_setpoint")]
        public System.Nullable<float> DehumidificationRelativeHumiditySetpoint { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

        [Description("Leave blank to use constant setpoint specified in Dehumidification Relative Humid" +
                     "ity Setpoint above. Schedule values must be in percent relative humidity (0 to 1" +
                     "00).")]
        [JsonProperty("dehumidification_relative_humidity_setpoint_schedule_name")]
        public string DehumidificationRelativeHumiditySetpointScheduleName { get; set; } = "";
        

        [JsonProperty("humidifier_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_ConstantVolume_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_ConstantVolume_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HumidifierType), "None");
        

        [Description("If blank, always available")]
        [JsonProperty("humidifier_availability_schedule_name")]
        public string HumidifierAvailabilityScheduleName { get; set; } = "";
        

        [Description("Moisture output rate at full rated power input. The humidifier does not currently" +
                     " autosize, so the default is very large to allow for adequate capacity.")]
        [JsonProperty("humidifier_rated_capacity")]
        public System.Nullable<float> HumidifierRatedCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

        [Description("Electric power input at rated capacity moisture output. Power consumption is prop" +
                     "ortional to moisture output with no part-load penalty.")]
        [JsonProperty("humidifier_rated_electric_power")]
        public string HumidifierRatedElectricPower { get; set; } = (System.String)"Autosize";
        

        [Description("Zone name where humidistat is located")]
        [JsonProperty("humidifier_control_zone_name")]
        public string HumidifierControlZoneName { get; set; } = "";
        

        [Description("Zone relative humidity setpoint in percent (0 to 100). Ignored if Humidifier Rela" +
                     "tive Humidity Setpoint Schedule specified below")]
        [JsonProperty("humidifier_relative_humidity_setpoint")]
        public System.Nullable<float> HumidifierRelativeHumiditySetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("Leave blank to use constant setpoint specified in Humidifier Relative Humidity Se" +
                     "tpoint above. Schedule values must be in percent relative humidity (0 to 100).")]
        [JsonProperty("humidifier_relative_humidity_setpoint_schedule_name")]
        public string HumidifierRelativeHumiditySetpointScheduleName { get; set; } = "";
        

        [Description("Specifies if the system has a return fan.")]
        [JsonProperty("return_fan")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("return_fan_total_efficiency")]
        public System.Nullable<float> ReturnFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("return_fan_delta_pressure")]
        public System.Nullable<float> ReturnFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("300", CultureInfo.InvariantCulture);
        

        [JsonProperty("return_fan_motor_efficiency")]
        public System.Nullable<float> ReturnFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("return_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> ReturnFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}