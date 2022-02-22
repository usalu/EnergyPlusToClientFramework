using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Unitary HVAC system with optional cooling and heating. Supports DX and chilled wa" +
                 "ter, cooling, gas, electric, and hot water heating, air-to-air and water-to-air " +
                 "heat pumps.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_System_UnitarySystem : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("If blank, always available. Also see Supply Fan Operating Mode Schedule Name fiel" +
                     "d.")]
        [JsonProperty("system_availability_schedule_name")]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("Load control requires a Controlling Zone name. SetPoint control requires set poin" +
                     "ts at coil outlet nodes. The user must add appropriate SetpointManager objects t" +
                     "o the idf file.")]
        [JsonProperty("control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_ControlType ControlType { get; set; } = (HVACTemplate_System_UnitarySystem_ControlType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_ControlType), "Load");
        

        [Description("This field is required if Control Type is Load.")]
        [JsonProperty("control_zone_or_thermostat_location_name")]
        public string ControlZoneOrThermostatLocationName { get; set; } = "";
        

        [Description(@"Supply air flow rate during cooling operation This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty("cooling_supply_air_flow_rate")]
        public string CoolingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description(@"Supply air flow rate during heating operation This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty("heating_supply_air_flow_rate")]
        public string HeatingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description(@"Supply air flow rate when no cooling or heating is needed Only used when heat pump fan operating mode is Continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used. This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty("no_load_supply_air_flow_rate")]
        public string NoLoadSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
                     "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
                     "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
                     "e used.")]
        [JsonProperty("supply_fan_operating_mode_schedule_name")]
        public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty("supply_fan_placement")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_UnitarySystem_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_SupplyFanPlacement), "BlowThrough");
        

        [JsonProperty("supply_fan_total_efficiency")]
        public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_delta_pressure")]
        public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("600", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_efficiency")]
        public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_UnitarySystem_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_CoolingCoilType), "SingleSpeedDX");
        

        [Description("Used only for Cooling Coil Type = MultiSpeedDX.")]
        [JsonProperty("number_of_speeds_for_cooling")]
        public System.Nullable<float> NumberOfSpeedsForCooling { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("If blank, always on")]
        [JsonProperty("cooling_coil_availability_schedule_name")]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing.")]
        [JsonProperty("cooling_design_supply_air_temperature")]
        public System.Nullable<float> CoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat Ratin" +
                     "g point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and a" +
                     "ir entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty("dx_cooling_coil_gross_rated_total_capacity")]
        public string DxCoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
                     " and total capacities do not include effect of supply fan heat")]
        [JsonProperty("dx_cooling_coil_gross_rated_sensible_heat_ratio")]
        public string DxCoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electric power input")]
        [JsonProperty("dx_cooling_coil_gross_rated_cop")]
        public System.Nullable<float> DxCoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty("heating_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatingCoilType), "Gas");
        

        [Description("Used only for Heating Coil Type = MultiSpeedDXHeatPumpAirSource), MultiStageElect" +
                     "ric, or MultiStageGas.")]
        [JsonProperty("number_of_speeds_or_stages_for_heating")]
        public System.Nullable<float> NumberOfSpeedsOrStagesForHeating { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("If blank, always on")]
        [JsonProperty("heating_coil_availability_schedule_name")]
        public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing.")]
        [JsonProperty("heating_design_supply_air_temperature")]
        public System.Nullable<float> HeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description("Rated heating capacity excluding the effect of supply air fan heat Rating point o" +
                     "utdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating c" +
                     "oil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty("heating_coil_gross_rated_capacity")]
        public string HeatingCoilGrossRatedCapacity { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("gas_heating_coil_efficiency")]
        public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty("gas_heating_coil_parasitic_electric_load")]
        public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Heating Coil Rated Capacity divided by power input to the compressor and outdoor fan, does not include supply air fan heat or supply air fan electrical energy. Rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C Applies only to DX coils")]
        [JsonProperty("heat_pump_heating_coil_gross_rated_cop")]
        public System.Nullable<float> HeatPumpHeatingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("2.75", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_heating_minimum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> HeatPumpHeatingMinimumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_defrost_maximum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> HeatPumpDefrostMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_defrost_strategy")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatPumpDefrostStrategy HeatPumpDefrostStrategy { get; set; } = (HVACTemplate_System_UnitarySystem_HeatPumpDefrostStrategy)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatPumpDefrostStrategy), "ReverseCycle");
        

        [JsonProperty("heat_pump_defrost_control")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatPumpDefrostControl HeatPumpDefrostControl { get; set; } = (HVACTemplate_System_UnitarySystem_HeatPumpDefrostControl)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatPumpDefrostControl), "Timed");
        

        [Description("Fraction of time in defrost mode only applicable if Timed defrost control is spec" +
                     "ified")]
        [JsonProperty("heat_pump_defrost_time_period_fraction")]
        public System.Nullable<float> HeatPumpDefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [JsonProperty("supplemental_heating_or_reheat_coil_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_SupplementalHeatingOrReheatCoilType SupplementalHeatingOrReheatCoilType { get; set; } = (HVACTemplate_System_UnitarySystem_SupplementalHeatingOrReheatCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_SupplementalHeatingOrReheatCoilType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty("supplemental_heating_or_reheat_coil_availability_schedule_name")]
        public string SupplementalHeatingOrReheatCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("supplemental_heating_or_reheat_coil_capacity")]
        public string SupplementalHeatingOrReheatCoilCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Supplemental heater will not operate when outdoor temperature exceeds this value." +
                     "")]
        [JsonProperty("supplemental_heating_or_reheat_coil_maximum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> SupplementalHeatingOrReheatCoilMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

        [Description("Applies only if Supplemental Heating Coil Type is Gas")]
        [JsonProperty("supplemental_gas_heating_or_reheat_coil_efficiency")]
        public System.Nullable<float> SupplementalGasHeatingOrReheatCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [Description("Applies only if Supplemental Heating Coil Type is Gas")]
        [JsonProperty("supplemental_gas_heating_or_reheat_coil_parasitic_electric_load")]
        public System.Nullable<float> SupplementalGasHeatingOrReheatCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_air_flow_rate")]
        public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("minimum_outdoor_air_flow_rate")]
        public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Schedule values multiply the minimum outdoor air flow rate If blank, multiplier i" +
                     "s always one")]
        [JsonProperty("minimum_outdoor_air_schedule_name")]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty("economizer_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_UnitarySystem_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_EconomizerType), "NoEconomizer");
        

        [JsonProperty("economizer_lockout")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_UnitarySystem_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_EconomizerLockout), "NoLockout");
        

        [Description("Enter the maximum outdoor dry-bulb temperature limit for FixedDryBulb economizer " +
                     "control type. No input or blank input means this limit is not operative. Limit i" +
                     "s applied regardless of economizer control type.")]
        [JsonProperty("economizer_maximum_limit_dry_bulb_temperature")]
        public System.Nullable<float> EconomizerMaximumLimitDryBulbTemperature { get; set; } = null;
        

        [Description("Enter the maximum outdoor enthalpy limit for FixedEnthalpy economizer control typ" +
                     "e. No input or blank input means this limit is not operative Limit is applied re" +
                     "gardless of economizer control type.")]
        [JsonProperty("economizer_maximum_limit_enthalpy")]
        public System.Nullable<float> EconomizerMaximumLimitEnthalpy { get; set; } = null;
        

        [Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
                     "economizer control type. No input or blank input means this limit is not operati" +
                     "ve. Limit is applied regardless of economizer control type.")]
        [JsonProperty("economizer_maximum_limit_dewpoint_temperature")]
        public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

        [Description("Enter the minimum outdoor dry-bulb temperature limit for economizer control. No i" +
                     "nput or blank input means this limit is not operative Limit is applied regardles" +
                     "s of economizer control type.")]
        [JsonProperty("economizer_minimum_limit_dry_bulb_temperature")]
        public System.Nullable<float> EconomizerMinimumLimitDryBulbTemperature { get; set; } = null;
        

        [Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
        [JsonProperty("supply_plenum_name")]
        public string SupplyPlenumName { get; set; } = "";
        

        [Description("Plenum zone name. Return plenum serves all zones on this system. Blank if none.")]
        [JsonProperty("return_plenum_name")]
        public string ReturnPlenumName { get; set; } = "";
        

        [JsonProperty("heat_recovery_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatRecoveryType), "None");
        

        [JsonProperty("sensible_heat_recovery_effectiveness")]
        public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Heat Recovery Type is Enthalpy.")]
        [JsonProperty("latent_heat_recovery_effectiveness")]
        public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_recovery_heat_exchanger_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatRecoveryHeatExchangerType HeatRecoveryHeatExchangerType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatRecoveryHeatExchangerType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatRecoveryHeatExchangerType), "Plate");
        

        [JsonProperty("heat_recovery_frost_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatRecoveryFrostControlType HeatRecoveryFrostControlType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatRecoveryFrostControlType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatRecoveryFrostControlType), "None");
        

        [Description(@"None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint, reheat with reheat coil If no reheat coil specified, cold supply temps may occur. Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only for Cooling Coil Type = TwoStageHumidityControlDX or HeatExchangerAssistedDX")]
        [JsonProperty("dehumidification_control_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_UnitarySystem_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_DehumidificationControlType), "None");
        

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
        public HVACTemplate_System_UnitarySystem_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_UnitarySystem_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HumidifierType), "None");
        

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_SizingOption SizingOption { get; set; } = (HVACTemplate_System_UnitarySystem_SizingOption)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_SizingOption), "NonCoincident");
        

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