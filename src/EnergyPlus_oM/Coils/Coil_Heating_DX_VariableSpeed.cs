using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Direct expansion (DX) heating coil (air-to-air heat pump) and compressor unit (in" +
                 "cludes electric compressor and outdoor fan), variable-speed, with defrost contro" +
                 "ls. Requires two to ten sets of performance data and will interpolate between sp" +
                 "eeds.")]
    [JsonObject("Coil:Heating:DX:VariableSpeed")]
    public class Coil_Heating_DX_VariableSpeed : BHoMObject
    {
        

        [JsonProperty("indoor_air_inlet_node_name")]
        public string IndoorAirInletNodeName { get; set; } = "";
        

        [JsonProperty("indoor_air_outlet_node_name")]
        public string IndoorAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("number_of_speeds")]
        public System.Nullable<float> NumberOfSpeeds { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("must be lower than or equal to the highest speed number")]
        [JsonProperty("nominal_speed_level")]
        public System.Nullable<float> NominalSpeedLevel { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [JsonProperty("rated_heating_capacity_at_selected_nominal_speed_level")]
        public string RatedHeatingCapacityAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("rated_air_flow_rate_at_selected_nominal_speed_level")]
        public string RatedAirFlowRateAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (heating load/steady state capacity)")]
        [JsonProperty("energy_part_load_fraction_curve_name")]
        public string EnergyPartLoadFractionCurveName { get; set; } = "";
        

        [Description("biquadratic curve = a + b*wb + c*wb**2 + d*oat + e*oat**2 + f*wb*oat wb = wet-bul" +
                     "b temperature (C) of air entering the indoor coil oat = outdoor air dry-bulb tem" +
                     "perature (C) only required if ReverseCycle defrost strategy is specified")]
        [JsonProperty("defrost_energy_input_ratio_function_of_temperature_curve_name")]
        public string DefrostEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
        public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

        [Description(@"The outdoor temperature when the compressor is automatically turned back on following an automatic shut off because of low outdoor dry-bulb temperature. This field is only used for the calculation of HSPF. If this field is not provided, then outdoor bin temperature used in the HSPF calculation is always considered to be greater than this temperature and 'Minimum Outdoor Dry-Bulb Temperature for Compressor Operation' field described above. This assumption is based on AHRI standard 210/240 (2008) and can introduce significant error in the final value of HSPF.")]
        [JsonProperty("outdoor_dry_bulb_temperature_to_turn_on_compressor")]
        public System.Nullable<float> OutdoorDryBulbTemperatureToTurnOnCompressor { get; set; } = null;
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_defrost_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForDefrostOperation { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("crankcase_heater_capacity")]
        public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [JsonProperty("defrost_strategy")]
        public EmptyNoYes DefrostStrategy { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "ReverseCycle");
        

        [JsonProperty("defrost_control")]
        public EmptyNoYes DefrostControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Timed");
        

        [Description("Fraction of time in defrost mode only applicable if timed defrost control is spec" +
                     "ified")]
        [JsonProperty("defrost_time_period_fraction")]
        public System.Nullable<float> DefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [Description("only applicable if resistive defrost strategy is specified")]
        [JsonProperty("resistive_defrost_heater_capacity")]
        public string ResistiveDefrostHeaterCapacity { get; set; } = (System.String)"0";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_1_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed1ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_1_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed1ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_1_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed1ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_1_heating_capacity_function_of_temperature_curve_name")]
        public string Speed1HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_1_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed1TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_1_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_1_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_2_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed2ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed2ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed2ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_2_heating_capacity_function_of_temperature_curve_name")]
        public string Speed2HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_2_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed2TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_2_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_2_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_3_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed3ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed3ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed3ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_3_heating_capacity_function_of_temperature_curve_name")]
        public string Speed3HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_3_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed3TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_3_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_3_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed3EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_4_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed4ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed4ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed4ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_4_heating_capacity_function_of_temperature_curve_name")]
        public string Speed4HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_4_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed4HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_4_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_4_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed4EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_5_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed5ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed5ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed5ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_5_heating_capacity_function_of_temperature_curve_name")]
        public string Speed5HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_5_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed5HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_5_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed5EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_5_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed5EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_6_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed6ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed6ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed6ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_6_heating_capacity_function_of_temperature_curve_name")]
        public string Speed6HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_6_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed6HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_6_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed6EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_6_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed6EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_7_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed7ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed7ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed7ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_7_heating_capacity_function_of_temperature_curve_name")]
        public string Speed7HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_7_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed7HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_7_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed7EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_7_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed7EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_8_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed8ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed8ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed8ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_8_heating_capacity_function_of_temperature_curve_name")]
        public string Speed8HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_8_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed8HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_8_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed8EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_8_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed8EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_9_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed9ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_9_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed9ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_9_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed9ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_9_heating_capacity_function_of_temperature_curve_name")]
        public string Speed9HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_9_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed9HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_9_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed9EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_9_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed9EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_10_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed10ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_10_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed10ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_10_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed10ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_10_heating_capacity_function_of_temperature_curve_name")]
        public string Speed10HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_10_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed10HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
                     "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_10_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed10EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_10_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed10EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
    }
}