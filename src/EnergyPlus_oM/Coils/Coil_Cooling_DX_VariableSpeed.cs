using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) cooling coil and condensing unit (includes electric compressor and condenser fan), variable-speed. Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Requires two to ten sets of performance data and will interpolate between speeds. Modeled as a single coil with variable-speed compressor.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Cooling_DX_VariableSpeed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("indoor_air_inlet_node_name")]
        public string IndoorAirInletNodeName { get; set; } = "";
        

        [JsonProperty("indoor_air_outlet_node_name")]
        public string IndoorAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("number_of_speeds")]
        public System.Nullable<float> NumberOfSpeeds { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("must be lower than or equal to the highest speed number")]
        [JsonProperty("nominal_speed_level")]
        public System.Nullable<float> NominalSpeedLevel { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("gross_rated_total_cooling_capacity_at_selected_nominal_speed_level")]
        public string GrossRatedTotalCoolingCapacityAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("rated_air_flow_rate_at_selected_nominal_speed_level")]
        public string RatedAirFlowRateAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

        [JsonProperty("nominal_time_for_condensate_to_begin_leaving_the_coil")]
        public System.Nullable<float> NominalTimeForCondensateToBeginLeavingTheCoil { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("initial_moisture_evaporation_rate_divided_by_steady_state_ac_latent_capacity")]
        public System.Nullable<float> InitialMoistureEvaporationRateDividedBySteadyStateAcLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (cooling load/steady state capacity)")]
        [JsonProperty("energy_part_load_fraction_curve_name")]
        public string EnergyPartLoadFractionCurveName { get; set; } = "";
        

        [Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
                     "doorAir:Node or OutdoorAir:NodeList object.")]
        [JsonProperty("condenser_air_inlet_node_name")]
        public string CondenserAirInletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_VariableSpeed_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_VariableSpeed_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_VariableSpeed_CondenserType), "AirCooled");
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump")]
        [JsonProperty("evaporative_condenser_pump_rated_power_consumption")]
        public string EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = (System.String)"0";
        

        [JsonProperty("crankcase_heater_capacity")]
        public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
        public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_water_storage_tank_name")]
        public string SupplyWaterStorageTankName { get; set; } = "";
        

        [JsonProperty("condensate_collection_water_storage_tank_name")]
        public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the DX coil is off.")]
        [JsonProperty("basin_heater_capacity")]
        public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty("basin_heater_setpoint_temperature")]
        public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty("basin_heater_operating_schedule_name")]
        public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_1_reference_unit_gross_rated_total_cooling_capacity")]
        public System.Nullable<float> Speed1ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("speed_1_reference_unit_gross_rated_sensible_heat_ratio")]
        public System.Nullable<float> Speed1ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty("speed_1_reference_unit_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed1ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty("speed_1_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed1ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled")]
        [JsonProperty("speed_1_reference_unit_rated_condenser_air_flow_rate")]
        public System.Nullable<float> Speed1ReferenceUnitRatedCondenserAirFlowRate { get; set; } = null;
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled")]
        [JsonProperty("speed_1_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
        public System.Nullable<float> Speed1ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_1_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed1TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_1_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed1TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_1_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_1_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_2_reference_unit_gross_rated_total_cooling_capacity")]
        public System.Nullable<float> Speed2ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_gross_rated_sensible_heat_ratio")]
        public System.Nullable<float> Speed2ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed2ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed2ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_rated_condenser_air_flow_rate")]
        public System.Nullable<float> Speed2ReferenceUnitRatedCondenserAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
        public System.Nullable<float> Speed2ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_2_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed2TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_2_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed2TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_2_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_2_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_3_reference_unit_gross_rated_total_cooling_capacity")]
        public System.Nullable<float> Speed3ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_gross_rated_sensible_heat_ratio")]
        public System.Nullable<float> Speed3ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed3ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed3ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_rated_condenser_air_flow_rate")]
        public System.Nullable<float> Speed3ReferenceUnitRatedCondenserAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
        public System.Nullable<float> Speed3ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_3_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed3TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_3_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed3TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_3_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_3_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed3EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_4_reference_unit_gross_rated_total_cooling_capacity")]
        public System.Nullable<float> Speed4ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_gross_rated_sensible_heat_ratio")]
        public System.Nullable<float> Speed4ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed4ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed4ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_rated_condenser_air_flow_rate")]
        public System.Nullable<float> Speed4ReferenceUnitRatedCondenserAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
        public System.Nullable<float> Speed4ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_4_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed4TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_4_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed4TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_4_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_4_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed4EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_5_reference_unit_gross_rated_total_cooling_capacity")]
        public System.Nullable<float> Speed5ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_gross_rated_sensible_heat_ratio")]
        public System.Nullable<float> Speed5ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed5ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed5ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_rated_condenser_air_flow_rate")]
        public System.Nullable<float> Speed5ReferenceUnitRatedCondenserAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
        public System.Nullable<float> Speed5ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_5_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed5TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_5_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed5TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_5_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed5EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_5_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed5EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_6_reference_unit_gross_rated_total_cooling_capacity")]
        public System.Nullable<float> Speed6ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_gross_rated_sensible_heat_ratio")]
        public System.Nullable<float> Speed6ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed6ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed6ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_condenser_air_flow_rate")]
        public System.Nullable<float> Speed6ReferenceUnitCondenserAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
        public System.Nullable<float> Speed6ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_6_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed6TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_6_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed6TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_6_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed6EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_6_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed6EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_7_reference_unit_gross_rated_total_cooling_capacity")]
        public System.Nullable<float> Speed7ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_gross_rated_sensible_heat_ratio")]
        public System.Nullable<float> Speed7ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed7ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed7ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_condenser_flow_rate")]
        public System.Nullable<float> Speed7ReferenceUnitCondenserFlowRate { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
        public System.Nullable<float> Speed7ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_7_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed7TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_7_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed7TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_7_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed7EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_7_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed7EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_8_reference_unit_gross_rated_total_cooling_capacity")]
        public System.Nullable<float> Speed8ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_gross_rated_sensible_heat_ratio")]
        public System.Nullable<float> Speed8ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed8ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed8ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_condenser_air_flow_rate")]
        public System.Nullable<float> Speed8ReferenceUnitCondenserAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
        public System.Nullable<float> Speed8ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_8_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed8TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_8_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed8TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_8_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed8EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_8_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed8EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_9_reference_unit_gross_rated_total_cooling_capacity")]
        public System.Nullable<float> Speed9ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("speed_9_reference_unit_gross_rated_sensible_heat_ratio")]
        public System.Nullable<float> Speed9ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty("speed_9_reference_unit_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed9ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty("speed_9_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed9ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("optional")]
        [JsonProperty("speed_9_reference_unit_condenser_air_flow_rate")]
        public System.Nullable<float> Speed9ReferenceUnitCondenserAirFlowRate { get; set; } = null;
        

        [Description("optional")]
        [JsonProperty("speed_9_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
        public System.Nullable<float> Speed9ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_9_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed9TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_9_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed9TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_9_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed9EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_9_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed9EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty("speed_10_reference_unit_gross_rated_total_cooling_capacity")]
        public System.Nullable<float> Speed10ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty("speed_10_reference_unit_gross_rated_sensible_heat_ratio")]
        public System.Nullable<float> Speed10ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty("speed_10_reference_unit_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed10ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty("speed_10_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed10ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [Description("optional")]
        [JsonProperty("speed_10_reference_unit_condenser_air_flow_rate")]
        public System.Nullable<float> Speed10ReferenceUnitCondenserAirFlowRate { get; set; } = null;
        

        [Description("optional")]
        [JsonProperty("speed_10_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
        public System.Nullable<float> Speed10ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_10_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed10TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_10_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed10TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
                     "emperature (C) odb = air entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_10_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed10EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty("speed_10_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
        public string Speed10EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
    }
}