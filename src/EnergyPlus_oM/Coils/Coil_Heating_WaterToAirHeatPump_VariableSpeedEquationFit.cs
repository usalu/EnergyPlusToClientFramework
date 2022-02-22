using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) heating coil for water-to-air heat pump (includes electric compressor), variable-speed, equation-fit model. Equation-fit model uses normalized curves to describe the heat pump performance. Requires two to ten sets of performance data and will interpolate between speeds.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Heating_WaterToAirHeatPump_VariableSpeedEquationFit : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("water_to_refrigerant_hx_water_inlet_node_name")]
        public string WaterToRefrigerantHxWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("water_to_refrigerant_hx_water_outlet_node_name")]
        public string WaterToRefrigerantHxWaterOutletNodeName { get; set; } = "";
        

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
        

        [JsonProperty("rated_water_flow_rate_at_selected_nominal_speed_level")]
        public string RatedWaterFlowRateAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (heating load/steady state capacity)")]
        [JsonProperty("energy_part_load_fraction_curve_name")]
        public string EnergyPartLoadFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_1_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed1ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_1_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed1ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_1_reference_unit_rated_air_flow")]
        public System.Nullable<float> Speed1ReferenceUnitRatedAirFlow { get; set; } = null;
        

        [JsonProperty("speed_1_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed1ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
                     "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_1_heating_capacity_function_of_temperature_curve_name")]
        public string Speed1HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_1_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed1TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
                     "**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_1_heating_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed1HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
                     "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_1_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_1_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
                     "**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_1_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
        public string Speed1EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("speed_1_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed1ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
                     "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_1_waste_heat_function_of_temperature_curve_name")]
        public string Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_2_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed2ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed2ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed2ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed2ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
                     "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_2_heating_capacity_function_of_temperature_curve_name")]
        public string Speed2HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_2_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed2TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
                     "**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_2_heating_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed2HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
                     "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_2_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_2_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_2_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
        public string Speed2EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("speed_2_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed2ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
                     "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
        [JsonProperty("speed_2_waste_heat_function_of_temperature_curve_name")]
        public string Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_3_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed3ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed3ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed3ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed3ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_3_heating_capacity_function_of_temperature_curve_name")]
        public string Speed3HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_3_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed3TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_3_heating_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed3HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_3_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_3_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed3EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_3_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
        public string Speed3EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("speed_3_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed3ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_3_waste_heat_function_of_temperature_curve_name")]
        public string Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_4_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed4ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed4ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed4ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed4ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_4_heating_capacity_function_of_temperature_curve_name")]
        public string Speed4HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_4_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed4TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_4_heating_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed4HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_4_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_4_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed4EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_4_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
        public string Speed4EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("speed_4_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed4ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_4_waste_heat_function_of_temperature_curve_name")]
        public string Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_5_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed5ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed5ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed5ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed5ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_5_heating_capacity_function_of_temperature_curve_name")]
        public string Speed5HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_5_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed5TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_5_heating_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed5HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_5_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed5EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_5_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed5EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_5_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
        public string Speed5EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("speed_5_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed5ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_5_waste_heat_function_of_temperature_curve_name")]
        public string Speed5WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_6_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed6ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed6ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed6ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed6ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_6_heating_capacity_function_of_temperature_curve_name")]
        public string Speed6HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_6_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed6TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_6_heating_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed6HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_6_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed6EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_6_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed6EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_6_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
        public string Speed6EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("speed_6_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed6ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_6_waste_heat_function_of_temperature_curve_name")]
        public string Speed6WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_7_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed7ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed7ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed7ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed7ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_7_heating_capacity_function_of_temperature_curve_name")]
        public string Speed7HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_7_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed7TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_7_heating_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed7HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_7_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed7EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_7_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed7EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_7_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
        public string Speed7EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("speed_7_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed7ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_7_waste_heat_function_of_temperature_curve_name")]
        public string Speed7WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_8_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed8ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed8ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed8ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed8ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_8_heating_capacity_function_of_temperature_curve_name")]
        public string Speed8HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_8_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed8TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_8_heating_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed8HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_8_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed8EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_8_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed8EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_8_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
        public string Speed8EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("speed_8_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed8ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_8_waste_heat_function_of_temperature_curve_name")]
        public string Speed8WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_9_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed9ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_9_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed9ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_9_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed9ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_9_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed9ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_9_heating_capacity_function_of_temperature_curve_name")]
        public string Speed9HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_9_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed9TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_9_heating_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed9HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_9_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed9EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_9_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed9EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_9_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
        public string Speed9EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("speed_9_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed9ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_9_waste_heat_function_of_temperature_curve_name")]
        public string Speed9WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Heating capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_10_reference_unit_gross_rated_heating_capacity")]
        public System.Nullable<float> Speed10ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

        [JsonProperty("speed_10_reference_unit_gross_rated_heating_cop")]
        public System.Nullable<float> Speed10ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

        [JsonProperty("speed_10_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed10ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_10_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed10ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_10_heating_capacity_function_of_temperature_curve_name")]
        public string Speed10HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_10_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed10TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_10_heating_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed10HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_10_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed10EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_10_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed10EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty("speed_10_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
        public string Speed10EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("speed_10_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed10ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
                     "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
                     "tor (C)")]
        [JsonProperty("speed_10_waste_heat_function_of_temperature_curve_name")]
        public string Speed10WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
    }
}