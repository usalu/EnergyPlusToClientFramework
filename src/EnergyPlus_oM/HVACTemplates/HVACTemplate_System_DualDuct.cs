using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Dual-duct constant volume or variable volume air loop")]
    [JsonObject("HVACTemplate:System:DualDuct")]
    public class HVACTemplate_System_DualDuct : BHoMObject
    {
        

        [Description("If blank, always on;  Schedule is used in availability manager and fan scheduling" +
                     ". Also see \"Night Cycle Control\" field.")]
        [JsonProperty("system_availability_schedule_name")]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("SingleFan - a single supply fan before the split to dual ducts DualFan - two supp" +
                     "ly fans, one each for the cold and hot ducts ConstantVolume - constant volume Va" +
                     "riableVolume - variable volume")]
        [JsonProperty("system_configuration_type")]
        public EmptyNoYes SystemConfigurationType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SingleFanConstantVolume");
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
                     "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
                     "value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty("main_supply_fan_maximum_flow_rate")]
        public string MainSupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("main_supply_fan_minimum_flow_fraction")]
        public System.Nullable<float> MainSupplyFanMinimumFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("main_supply_fan_total_efficiency")]
        public System.Nullable<float> MainSupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("main_supply_fan_delta_pressure")]
        public System.Nullable<float> MainSupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

        [JsonProperty("main_supply_fan_motor_efficiency")]
        public System.Nullable<float> MainSupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("main_supply_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> MainSupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
                     "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
                     " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
                     "lues table.")]
        [JsonProperty("main_supply_fan_part_load_power_coefficients")]
        public EmptyNoYes MainSupplyFanPartLoadPowerCoefficients { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "InletVaneDampers");
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
                     "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
                     "value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty("cold_duct_supply_fan_maximum_flow_rate")]
        public string ColdDuctSupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("cold_duct_supply_fan_minimum_flow_fraction")]
        public System.Nullable<float> ColdDuctSupplyFanMinimumFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("cold_duct_supply_fan_total_efficiency")]
        public System.Nullable<float> ColdDuctSupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("cold_duct_supply_fan_delta_pressure")]
        public System.Nullable<float> ColdDuctSupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

        [JsonProperty("cold_duct_supply_fan_motor_efficiency")]
        public System.Nullable<float> ColdDuctSupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("cold_duct_supply_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> ColdDuctSupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
                     "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
                     " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
                     "lues table.")]
        [JsonProperty("cold_duct_supply_fan_part_load_power_coefficients")]
        public EmptyNoYes ColdDuctSupplyFanPartLoadPowerCoefficients { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "InletVaneDampers");
        

        [JsonProperty("cold_duct_supply_fan_placement")]
        public EmptyNoYes ColdDuctSupplyFanPlacement { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "DrawThrough");
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
                     "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
                     "value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty("hot_duct_supply_fan_maximum_flow_rate")]
        public string HotDuctSupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("hot_duct_supply_fan_minimum_flow_fraction")]
        public System.Nullable<float> HotDuctSupplyFanMinimumFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("hot_duct_supply_fan_total_efficiency")]
        public System.Nullable<float> HotDuctSupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("hot_duct_supply_fan_delta_pressure")]
        public System.Nullable<float> HotDuctSupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

        [JsonProperty("hot_duct_supply_fan_motor_efficiency")]
        public System.Nullable<float> HotDuctSupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("hot_duct_supply_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> HotDuctSupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
                     "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
                     " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
                     "lues table.")]
        [JsonProperty("hot_duct_supply_fan_part_load_power_coefficients")]
        public EmptyNoYes HotDuctSupplyFanPartLoadPowerCoefficients { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "InletVaneDampers");
        

        [JsonProperty("hot_duct_supply_fan_placement")]
        public EmptyNoYes HotDuctSupplyFanPlacement { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "DrawThrough");
        

        [JsonProperty("cooling_coil_type")]
        public EmptyNoYes CoolingCoilType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ChilledWater");
        

        [Description("If blank, always on")]
        [JsonProperty("cooling_coil_availability_schedule_name")]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("cooling_coil_setpoint_control_type")]
        public EmptyNoYes CoolingCoilSetpointControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "FixedSetpoint");
        

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
        public EmptyNoYes HeatingCoilType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "HotWater");
        

        [Description("If blank, always on")]
        [JsonProperty("heating_coil_availability_schedule_name")]
        public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("heating_coil_setpoint_control_type")]
        public EmptyNoYes HeatingCoilSetpointControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "FixedSetpoint");
        

        [Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Nam" +
                     "e is specified.")]
        [JsonProperty("heating_coil_design_setpoint")]
        public System.Nullable<float> HeatingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("heating_coil_setpoint_schedule_name")]
        public string HeatingCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_low")]
        public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control. Defaults are 15.6C (60F) " +
                     "at 15.6C (60F) to 12.8C (55F) at 23.3C (74F)")]
        [JsonProperty("heating_coil_reset_outdoor_dry_bulb_low")]
        public System.Nullable<float> HeatingCoilResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("7.8", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_high")]
        public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

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
        public EmptyNoYes PreheatCoilType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

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
        

        [JsonProperty("minimum_outdoor_air_control_type")]
        public EmptyNoYes MinimumOutdoorAirControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ProportionalMinimum");
        

        [Description("Schedule values multiply the Minimum Outdoor Air Flow Rate If blank, multiplier i" +
                     "s always one")]
        [JsonProperty("minimum_outdoor_air_schedule_name")]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty("economizer_type")]
        public EmptyNoYes EconomizerType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "NoEconomizer");
        

        [JsonProperty("economizer_lockout")]
        public EmptyNoYes EconomizerLockout { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "NoLockout");
        

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
        

        [Description("Plenum zone name. Supply plenum serves the cold inlets of all zones on this syste" +
                     "m. Blank if none.")]
        [JsonProperty("cold_supply_plenum_name")]
        public string ColdSupplyPlenumName { get; set; } = "";
        

        [Description("Plenum zone name. Supply plenum serves the hot inlets of all zones on this system" +
                     ". Blank if none.")]
        [JsonProperty("hot_supply_plenum_name")]
        public string HotSupplyPlenumName { get; set; } = "";
        

        [Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
        [JsonProperty("return_plenum_name")]
        public string ReturnPlenumName { get; set; } = "";
        

        [JsonProperty("night_cycle_control")]
        public EmptyNoYes NightCycleControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "StayOff");
        

        [Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
        [JsonProperty("night_cycle_control_zone_name")]
        public string NightCycleControlZoneName { get; set; } = "";
        

        [JsonProperty("heat_recovery_type")]
        public EmptyNoYes HeatRecoveryType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

        [JsonProperty("sensible_heat_recovery_effectiveness")]
        public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("latent_heat_recovery_effectiveness")]
        public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_recovery_heat_exchanger_type")]
        public EmptyNoYes HeatRecoveryHeatExchangerType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Plate");
        

        [JsonProperty("heat_recovery_frost_control_type")]
        public EmptyNoYes HeatRecoveryFrostControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

        [Description("None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint as " +
                     "required to meet the humidity setpoint.")]
        [JsonProperty("dehumidification_control_type")]
        public EmptyNoYes DehumidificationControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

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
        public EmptyNoYes HumidifierType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

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
        

        [Description("Select whether autosized system supply flow rate is the sum of Coincident or NonC" +
                     "oincident zone air flow rates.")]
        [JsonProperty("sizing_option")]
        public EmptyNoYes SizingOption { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "NonCoincident");
        

        [Description("Specifies if the system has a return fan.")]
        [JsonProperty("return_fan")]
        public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("return_fan_total_efficiency")]
        public System.Nullable<float> ReturnFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("return_fan_delta_pressure")]
        public System.Nullable<float> ReturnFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

        [JsonProperty("return_fan_motor_efficiency")]
        public System.Nullable<float> ReturnFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("return_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> ReturnFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
                     "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
                     " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
                     "lues table.")]
        [JsonProperty("return_fan_part_load_power_coefficients")]
        public EmptyNoYes ReturnFanPartLoadPowerCoefficients { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "InletVaneDampers");
    }
}