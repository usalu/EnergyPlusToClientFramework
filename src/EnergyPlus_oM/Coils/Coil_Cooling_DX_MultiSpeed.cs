using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) cooling coil and condensing unit (includes electric or engine-driven compressor and condenser fan), multi-speed (or variable-speed). Optional moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Requires two to four sets of performance data and will interpolate between speeds. Modeled as a single coil (multi-speed compressor or multiple compressors with row split or intertwined coil).")]
    public class Coil_Cooling_DX_MultiSpeed : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
                     "doorAir:Node or OutdoorAir:NodeList object.")]
        [JsonProperty("condenser_air_inlet_node_name")]
        public string CondenserAirInletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_MultiSpeed_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_MultiSpeed_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_MultiSpeed_CondenserType), "AirCooled");
        

        [JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
        public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

        [JsonProperty("supply_water_storage_tank_name")]
        public string SupplyWaterStorageTankName { get; set; } = "";
        

        [JsonProperty("condensate_collection_water_storage_tank_name")]
        public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

        [JsonProperty("apply_part_load_fraction_to_speeds_greater_than_1")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ApplyPartLoadFractionToSpeedsGreaterThan1 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("apply_latent_degradation_to_speeds_greater_than_1")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ApplyLatentDegradationToSpeedsGreaterThan1 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("crankcase_heater_capacity")]
        public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

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
        

        [JsonProperty("fuel_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_MultiSpeed_FuelType FuelType { get; set; } = (Coil_Cooling_DX_MultiSpeed_FuelType)Enum.Parse(typeof(Coil_Cooling_DX_MultiSpeed_FuelType), "Diesel");
        

        [Description("Enter the number of the following sets of data for coil capacity, SHR, COP, flow " +
                     "rate, and associated curves.")]
        [JsonProperty("number_of_speeds")]
        public System.Nullable<float> NumberOfSpeeds { get; set; } = null;
        

        [Description(@"Total cooling capacity not accounting for the effect of supply air fan heat Gross capacity excluding supply air fan heat Rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb Speed 1 is defined as low speed")]
        [JsonProperty("speed_1_gross_rated_total_cooling_capacity")]
        public string Speed1GrossRatedTotalCoolingCapacity { get; set; } = "";
        

        [Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity) Se" +
                     "nsible and total capacities do not include supply fan heat")]
        [JsonProperty("speed_1_gross_rated_sensible_heat_ratio")]
        public string Speed1GrossRatedSensibleHeatRatio { get; set; } = "";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input")]
        [JsonProperty("speed_1_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed1GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated COP " +
                     "should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total coo" +
                     "ling capacity")]
        [JsonProperty("speed_1_rated_air_flow_rate")]
        public string Speed1RatedAirFlowRate { get; set; } = "";
        

        [Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
        [JsonProperty("speed_1_rated_evaporator_fan_power_per_volume_flow_rate")]
        public System.Nullable<float> Speed1RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("speed_1_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed1TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = Fraction of the full load Flow")]
        [JsonProperty("speed_1_total_cooling_capacity_function_of_flow_fraction_curve_name")]
        public string Speed1TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("speed_1_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_1_energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string Speed1EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (cooling load/steady state capacity)")]
        [JsonProperty("speed_1_part_load_fraction_correlation_curve_name")]
        public string Speed1PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
        [JsonProperty("speed_1_nominal_time_for_condensate_removal_to_begin")]
        public System.Nullable<float> Speed1NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Ratio of the initial moisture evaporation Rate from the Cooling Coil (when the compressor first turns off) and the Coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
        [JsonProperty("speed_1_ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capaci" +
                      "ty")]
        public System.Nullable<float> Speed1RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time " +
                     "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("speed_1_maximum_cycling_rate")]
        public System.Nullable<float> Speed1MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
                     "startup. Suggested value is 45; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("speed_1_latent_capacity_time_constant")]
        public System.Nullable<float> Speed1LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Recoverable waste heat at full load and rated conditions")]
        [JsonProperty("speed_1_rated_waste_heat_fraction_of_power_input")]
        public System.Nullable<float> Speed1RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty("speed_1_waste_heat_function_of_temperature_curve_name")]
        public string Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [JsonProperty("speed_1_evaporative_condenser_effectiveness")]
        public System.Nullable<float> Speed1EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Used to calculate evaporative condenser water use")]
        [JsonProperty("speed_1_evaporative_condenser_air_flow_rate")]
        public string Speed1EvaporativeCondenserAirFlowRate { get; set; } = "";
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump at high speed")]
        [JsonProperty("speed_1_rated_evaporative_condenser_pump_power_consumption")]
        public string Speed1RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = "";
        

        [Description(@"Total cooling capacity not accounting for the effect of supply air fan heat Gross capacity excluding supply air fan heat Rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty("speed_2_gross_rated_total_cooling_capacity")]
        public string Speed2GrossRatedTotalCoolingCapacity { get; set; } = "";
        

        [Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity) Se" +
                     "nsible and total capacities do not include supply fan heat")]
        [JsonProperty("speed_2_gross_rated_sensible_heat_ratio")]
        public string Speed2GrossRatedSensibleHeatRatio { get; set; } = "";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input")]
        [JsonProperty("speed_2_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed2GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated COP " +
                     "should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total coo" +
                     "ling capacity for Speed 2.")]
        [JsonProperty("speed_2_rated_air_flow_rate")]
        public string Speed2RatedAirFlowRate { get; set; } = "";
        

        [Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
        [JsonProperty("speed_2_rated_evaporator_fan_power_per_volume_flow_rate")]
        public System.Nullable<float> Speed2RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("speed_2_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed2TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_2_total_cooling_capacity_function_of_flow_fraction_curve_name")]
        public string Speed2TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("speed_2_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = Fraction of the full load Flow")]
        [JsonProperty("speed_2_energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string Speed2EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (Cooling load/steady state capacity)")]
        [JsonProperty("speed_2_part_load_fraction_correlation_curve_name")]
        public string Speed2PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
        [JsonProperty("speed_2_nominal_time_for_condensate_removal_to_begin")]
        public System.Nullable<float> Speed2NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
        [JsonProperty("speed_2_ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capaci" +
                      "ty")]
        public System.Nullable<float> Speed2RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time " +
                     "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("speed_2_maximum_cycling_rate")]
        public System.Nullable<float> Speed2MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
                     "startup. Suggested value is 45; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("speed_2_latent_capacity_time_constant")]
        public System.Nullable<float> Speed2LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Recoverable waste heat at full load and rated conditions")]
        [JsonProperty("speed_2_rated_waste_heat_fraction_of_power_input")]
        public System.Nullable<float> Speed2RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty("speed_2_waste_heat_function_of_temperature_curve_name")]
        public string Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [JsonProperty("speed_2_evaporative_condenser_effectiveness")]
        public System.Nullable<float> Speed2EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Used to calculate evaporative condenser water use")]
        [JsonProperty("speed_2_evaporative_condenser_air_flow_rate")]
        public string Speed2EvaporativeCondenserAirFlowRate { get; set; } = "";
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump at low speed")]
        [JsonProperty("speed_2_rated_evaporative_condenser_pump_power_consumption")]
        public string Speed2RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = "";
        

        [Description(@"Total cooling capacity not accounting for the effect of supply air fan heat Gross capacity excluding supply air fan heat Rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty("speed_3_gross_rated_total_cooling_capacity")]
        public string Speed3GrossRatedTotalCoolingCapacity { get; set; } = "";
        

        [Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity) Se" +
                     "nsible and total capacities do not include supply fan heat")]
        [JsonProperty("speed_3_gross_rated_sensible_heat_ratio")]
        public string Speed3GrossRatedSensibleHeatRatio { get; set; } = "";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input")]
        [JsonProperty("speed_3_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed3GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated COP " +
                     "should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total coo" +
                     "ling capacity for Speed 3.")]
        [JsonProperty("speed_3_rated_air_flow_rate")]
        public string Speed3RatedAirFlowRate { get; set; } = "";
        

        [Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
        [JsonProperty("speed_3_rated_evaporator_fan_power_per_volume_flow_rate")]
        public System.Nullable<float> Speed3RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("speed_3_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed3TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_3_total_cooling_capacity_function_of_flow_fraction_curve_name")]
        public string Speed3TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("speed_3_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_3_energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string Speed3EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (Cooling load/steady state capacity)")]
        [JsonProperty("speed_3_part_load_fraction_correlation_curve_name")]
        public string Speed3PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
        [JsonProperty("speed_3_nominal_time_for_condensate_removal_to_begin")]
        public System.Nullable<float> Speed3NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
        [JsonProperty("speed_3_ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capaci" +
                      "ty")]
        public System.Nullable<float> Speed3RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time " +
                     "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("speed_3_maximum_cycling_rate")]
        public System.Nullable<float> Speed3MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
                     "startup. Suggested value is 45; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("speed_3_latent_capacity_time_constant")]
        public System.Nullable<float> Speed3LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Recoverable waste heat at full load and rated conditions")]
        [JsonProperty("speed_3_rated_waste_heat_fraction_of_power_input")]
        public System.Nullable<float> Speed3RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty("speed_3_waste_heat_function_of_temperature_curve_name")]
        public string Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [JsonProperty("speed_3_evaporative_condenser_effectiveness")]
        public System.Nullable<float> Speed3EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Used to calculate evaporative condenser water use")]
        [JsonProperty("speed_3_evaporative_condenser_air_flow_rate")]
        public string Speed3EvaporativeCondenserAirFlowRate { get; set; } = "";
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump at Low speed")]
        [JsonProperty("speed_3_rated_evaporative_condenser_pump_power_consumption")]
        public string Speed3RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = "";
        

        [Description(@"Total cooling capacity not accounting for the effect of supply air fan heat Gross capacity excluding supply air fan heat Rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty("speed_4_gross_rated_total_cooling_capacity")]
        public string Speed4GrossRatedTotalCoolingCapacity { get; set; } = "";
        

        [Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity) Se" +
                     "nsible and total capacities do not include supply fan heat")]
        [JsonProperty("speed_4_gross_rated_sensible_heat_ratio")]
        public string Speed4GrossRatedSensibleHeatRatio { get; set; } = "";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input")]
        [JsonProperty("speed_4_gross_rated_cooling_cop")]
        public System.Nullable<float> Speed4GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated COP " +
                     "should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total coo" +
                     "ling capacity for Speed 4")]
        [JsonProperty("speed_4_rated_air_flow_rate")]
        public string Speed4RatedAirFlowRate { get; set; } = "";
        

        [Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
        [JsonProperty("speed_4_rated_evaporator_fan_power_per_volume_flow_rate")]
        public System.Nullable<float> Speed4RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("speed_4_total_cooling_capacity_function_of_temperature_curve_name")]
        public string Speed4TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_4_total_cooling_capacity_function_of_flow_fraction_curve_name")]
        public string Speed4TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("speed_4_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_4_energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string Speed4EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (cooling load/steady state capacity)")]
        [JsonProperty("speed_4_part_load_fraction_correlation_curve_name")]
        public string Speed4PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
        [JsonProperty("speed_4_nominal_time_for_condensate_removal_to_begin")]
        public System.Nullable<float> Speed4NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
        [JsonProperty("speed_4_ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capaci" +
                      "ty")]
        public System.Nullable<float> Speed4RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time " +
                     "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("speed_4_maximum_cycling_rate")]
        public System.Nullable<float> Speed4MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
                     "startup. Suggested value is 45; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("speed_4_latent_capacity_time_constant")]
        public System.Nullable<float> Speed4LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Recoverable waste heat at full load and rated conditions")]
        [JsonProperty("speed_4_rated_waste_heat_fraction_of_power_input")]
        public System.Nullable<float> Speed4RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty("speed_4_waste_heat_function_of_temperature_curve_name")]
        public string Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [JsonProperty("speed_4_evaporative_condenser_effectiveness")]
        public System.Nullable<float> Speed4EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Used to calculate evaporative condenser water use")]
        [JsonProperty("speed_4_evaporative_condenser_air_flow_rate")]
        public string Speed4EvaporativeCondenserAirFlowRate { get; set; } = "";
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump at Speed 4")]
        [JsonProperty("speed_4_rated_evaporative_condenser_pump_power_consumption")]
        public string Speed4RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = "";
        

        [Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (condenser) of DX system or a heat pump is to be placed. This is an optional input field specified only when user desires to reject the condenser heat into a zone. The heat rejected is modelled as internal sensible heat gain of the zone.")]
        [JsonProperty("zone_name_for_condenser_placement")]
        public string ZoneNameForCondenserPlacement { get; set; } = "";
    }
}