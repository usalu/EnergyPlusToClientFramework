using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Variable Air Volume (VAV) air loop with optional heating coil and optional prehea" +
                 "t.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_System_VAV : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("If blank, always on; VAV System always on. Schedule is used in availability manag" +
                     "er and fan scheduling. Also see \"Night Cycle Control\" field.")]
        [JsonProperty("system_availability_schedule_name")]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
                     "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
                     "value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty("supply_fan_maximum_flow_rate")]
        public string SupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("This field is only used to set a minimum part load on the VAV fan power curve. Au" +
                     "tosize or zero is recommended.")]
        [JsonProperty("supply_fan_minimum_flow_rate")]
        public string SupplyFanMinimumFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("supply_fan_total_efficiency")]
        public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_delta_pressure")]
        public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_efficiency")]
        public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_VAV_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_VAV_CoolingCoilType), "ChilledWater");
        

        [Description("If blank, always on")]
        [JsonProperty("cooling_coil_availability_schedule_name")]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("cooling_coil_setpoint_schedule_name")]
        public string CoolingCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Nam" +
                     "e is specified.")]
        [JsonProperty("cooling_coil_design_setpoint")]
        public System.Nullable<float> CoolingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_VAV_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_VAV_HeatingCoilType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty("heating_coil_availability_schedule_name")]
        public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("heating_coil_setpoint_schedule_name")]
        public string HeatingCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Nam" +
                     "e is specified.")]
        [JsonProperty("heating_coil_design_setpoint")]
        public System.Nullable<float> HeatingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [JsonProperty("gas_heating_coil_efficiency")]
        public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("gas_heating_coil_parasitic_electric_load")]
        public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("preheat_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_PreheatCoilType PreheatCoilType { get; set; } = (HVACTemplate_System_VAV_PreheatCoilType)Enum.Parse(typeof(HVACTemplate_System_VAV_PreheatCoilType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty("preheat_coil_availability_schedule_name")]
        public string PreheatCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty("preheat_coil_setpoint_schedule_name")]
        public string PreheatCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Preheat Coil Setpoint Schedule Nam" +
                     "e specified.")]
        [JsonProperty("preheat_coil_design_setpoint")]
        public System.Nullable<float> PreheatCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("7.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("gas_preheat_coil_efficiency")]
        public System.Nullable<float> GasPreheatCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("gas_preheat_coil_parasitic_electric_load")]
        public System.Nullable<float> GasPreheatCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_air_flow_rate")]
        public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("minimum_outdoor_air_flow_rate")]
        public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("minimum_outdoor_air_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_MinimumOutdoorAirControlType MinimumOutdoorAirControlType { get; set; } = (HVACTemplate_System_VAV_MinimumOutdoorAirControlType)Enum.Parse(typeof(HVACTemplate_System_VAV_MinimumOutdoorAirControlType), "ProportionalMinimum");
        

        [Description("Schedule values multiply the Minimum Outdoor Air Flow Rate If blank, multiplier i" +
                     "s always one")]
        [JsonProperty("minimum_outdoor_air_schedule_name")]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty("economizer_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_VAV_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_VAV_EconomizerType), "NoEconomizer");
        

        [JsonProperty("economizer_lockout")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_VAV_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_VAV_EconomizerLockout), "NoLockout");
        

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
        

        [JsonProperty("supply_fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_VAV_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_VAV_SupplyFanPlacement), "DrawThrough");
        

        [Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
                     "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
                     " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
                     "lues table.")]
        [JsonProperty("supply_fan_part_load_power_coefficients")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_SupplyFanPartLoadPowerCoefficients SupplyFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_VAV_SupplyFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_VAV_SupplyFanPartLoadPowerCoefficients), "InletVaneDampers");
        

        [JsonProperty("night_cycle_control")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_NightCycleControl NightCycleControl { get; set; } = (HVACTemplate_System_VAV_NightCycleControl)Enum.Parse(typeof(HVACTemplate_System_VAV_NightCycleControl), "StayOff");
        

        [Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
        [JsonProperty("night_cycle_control_zone_name")]
        public string NightCycleControlZoneName { get; set; } = "";
        

        [JsonProperty("heat_recovery_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_VAV_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_VAV_HeatRecoveryType), "None");
        

        [JsonProperty("sensible_heat_recovery_effectiveness")]
        public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("latent_heat_recovery_effectiveness")]
        public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description(@"Overrides Cooling Coil Setpoint Schedule Name None = no reset, control to Cooling Coil Design Setpoint Temperature or Schedule Warmest = reset as warm as possible yet meet all zone cooling loads at max supply air flow rate OutdoorAirTemperatureReset = reset based on outdoor air temperature (18.0C at 15.6C ODB, to the Cooling Design Setpoint at 26.7C) WarmestTemperatureFirst = reset as warm as possible yet meet all zone cooling loads at min supply air flow rate")]
        [JsonProperty("cooling_coil_setpoint_reset_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_CoolingCoilSetpointResetType CoolingCoilSetpointResetType { get; set; } = (HVACTemplate_System_VAV_CoolingCoilSetpointResetType)Enum.Parse(typeof(HVACTemplate_System_VAV_CoolingCoilSetpointResetType), "None");
        

        [Description(@"Overrides Heating Coil Setpoint Schedule Name None = no reset, control to Heating Coil Design Setpoint Temperature or Schedule OutdoorAirTemperatureReset = reset based on outdoor air temperature (Heating Design Setpoint at -6.7C ODB to Heating Design Setpoint minus 5.2C at 10C ODB) min supply air flow rate")]
        [JsonProperty("heating_coil_setpoint_reset_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_HeatingCoilSetpointResetType HeatingCoilSetpointResetType { get; set; } = (HVACTemplate_System_VAV_HeatingCoilSetpointResetType)Enum.Parse(typeof(HVACTemplate_System_VAV_HeatingCoilSetpointResetType), "None");
        

        [Description("None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint as " +
                     "required to meet the humidity setpoint.")]
        [JsonProperty("dehumidification_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_VAV_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_VAV_DehumidificationControlType), "None");
        

        [Description("Zone name where humidistat is located")]
        [JsonProperty("dehumidification_control_zone_name")]
        public string DehumidificationControlZoneName { get; set; } = "";
        

        [Description("Zone relative humidity setpoint in percent (0 to 100)")]
        [JsonProperty("dehumidification_setpoint")]
        public System.Nullable<float> DehumidificationSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

        [JsonProperty("humidifier_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_VAV_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_VAV_HumidifierType), "None");
        

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
        

        [Description("Zone relative humidity setpoint in percent (0 to 100)")]
        [JsonProperty("humidifier_setpoint")]
        public System.Nullable<float> HumidifierSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("Select whether autosized system supply flow rate is the sum of Coincident or NonC" +
                     "oincident zone air flow rates.")]
        [JsonProperty("sizing_option")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_SizingOption SizingOption { get; set; } = (HVACTemplate_System_VAV_SizingOption)Enum.Parse(typeof(HVACTemplate_System_VAV_SizingOption), "NonCoincident");
        

        [Description("Specifies if the system has a return fan.")]
        [JsonProperty("return_fan")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VAV_ReturnFanPartLoadPowerCoefficients ReturnFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_VAV_ReturnFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_VAV_ReturnFanPartLoadPowerCoefficients), "InletVaneDampers");
    }
}