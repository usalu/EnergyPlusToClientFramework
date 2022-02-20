using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Unitary furnace with electric air-to-air heat pump")]
    [JsonObject("HVACTemplate:System:UnitaryHeatPump:AirToAir")]
    public class HVACTemplate_System_UnitaryHeatPump_AirToAir : BHoMObject
    {
        

        [Description("If blank, always on; Unitary System always on. Schedule is used in availability m" +
                     "anager and fan scheduling. Also see \"Night Cycle Control\" field.")]
        [JsonProperty("system_availability_schedule_name")]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

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
        public EmptyNoYes SupplyFanPlacement { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "BlowThrough");
        

        [JsonProperty("supply_fan_total_efficiency")]
        public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_delta_pressure")]
        public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("600", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_efficiency")]
        public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_fan_motor_in_air_stream_fraction")]
        public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("cooling_coil_type")]
        public EmptyNoYes CoolingCoilType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SingleSpeedDX");
        

        [Description("If blank, always on")]
        [JsonProperty("cooling_coil_availability_schedule_name")]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing.")]
        [JsonProperty("cooling_design_supply_air_temperature")]
        public System.Nullable<float> CoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat Ratin" +
                     "g point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and a" +
                     "ir entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty("cooling_coil_gross_rated_total_capacity")]
        public string CoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
                     " and total capacities do not include effect of supply fan heat")]
        [JsonProperty("cooling_coil_gross_rated_sensible_heat_ratio")]
        public string CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electric power input")]
        [JsonProperty("cooling_coil_gross_rated_cop")]
        public System.Nullable<float> CoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_heating_coil_type")]
        public EmptyNoYes HeatPumpHeatingCoilType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "SingleSpeedDXHeatPump");
        

        [Description("If blank, always on")]
        [JsonProperty("heat_pump_heating_coil_availability_schedule_name")]
        public string HeatPumpHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing.")]
        [JsonProperty("heating_design_supply_air_temperature")]
        public System.Nullable<float> HeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

        [Description("Rated heating capacity excluding the effect of supply air fan heat Rating point o" +
                     "utdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating c" +
                     "oil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty("heat_pump_heating_coil_gross_rated_capacity")]
        public string HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = (System.String)"Autosize";
        

        [Description(@"Heat Pump Heating Coil Rated Capacity divided by power input to the compressor and outdoor fan, does not include supply air fan heat or supply air fan electrical energy. Rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty("heat_pump_heating_coil_rated_cop")]
        public System.Nullable<float> HeatPumpHeatingCoilRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("2.75", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_heating_minimum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> HeatPumpHeatingMinimumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_defrost_maximum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> HeatPumpDefrostMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_pump_defrost_strategy")]
        public EmptyNoYes HeatPumpDefrostStrategy { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ReverseCycle");
        

        [JsonProperty("heat_pump_defrost_control")]
        public EmptyNoYes HeatPumpDefrostControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Timed");
        

        [Description("Fraction of time in defrost mode only applicable if Timed defrost control is spec" +
                     "ified")]
        [JsonProperty("heat_pump_defrost_time_period_fraction")]
        public System.Nullable<float> HeatPumpDefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [JsonProperty("supplemental_heating_coil_type")]
        public EmptyNoYes SupplementalHeatingCoilType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Electric");
        

        [Description("If blank, always on")]
        [JsonProperty("supplemental_heating_coil_availability_schedule_name")]
        public string SupplementalHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("supplemental_heating_coil_capacity")]
        public string SupplementalHeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

        [Description("Supplemental heater will not operate when outdoor temperature exceeds this value." +
                     "")]
        [JsonProperty("supplemental_heating_coil_maximum_outdoor_dry_bulb_temperature")]
        public System.Nullable<float> SupplementalHeatingCoilMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

        [Description("Applies only if Supplemental Heating Coil Type is Gas")]
        [JsonProperty("supplemental_gas_heating_coil_efficiency")]
        public System.Nullable<float> SupplementalGasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

        [Description("Applies only if Supplemental Heating Coil Type is Gas")]
        [JsonProperty("supplemental_gas_heating_coil_parasitic_electric_load")]
        public System.Nullable<float> SupplementalGasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_air_flow_rate")]
        public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("minimum_outdoor_air_flow_rate")]
        public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

        [Description("Schedule values multiply the minimum outdoor air flow rate If blank, multiplier i" +
                     "s always one")]
        [JsonProperty("minimum_outdoor_air_schedule_name")]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty("economizer_type")]
        public EmptyNoYes EconomizerType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "NoEconomizer");
        

        [JsonProperty("economizer_lockout")]
        public EmptyNoYes EconomizerLockout { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "NoLockout");
        

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
        

        [JsonProperty("night_cycle_control")]
        public EmptyNoYes NightCycleControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "StayOff");
        

        [Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
        [JsonProperty("night_cycle_control_zone_name")]
        public string NightCycleControlZoneName { get; set; } = "";
        

        [JsonProperty("heat_recovery_type")]
        public EmptyNoYes HeatRecoveryType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
        

        [JsonProperty("sensible_heat_recovery_effectiveness")]
        public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Heat Recovery Type is Enthalpy.")]
        [JsonProperty("latent_heat_recovery_effectiveness")]
        public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

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
        

        [Description("Zone relative humidity setpoint in percent (0 to 100)")]
        [JsonProperty("humidifier_setpoint")]
        public System.Nullable<float> HumidifierSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

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
    }
}