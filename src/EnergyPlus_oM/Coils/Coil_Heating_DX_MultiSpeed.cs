using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) heating coil (air-to-air heat pump) and compressor unit (includes electric or engine-driven compressor and outdoor fan), multi-speed (or variable-speed), with defrost controls. Requires two to four sets of performance data and will interpolate between speeds.")]
    [JsonObject("Coil:Heating:DX:MultiSpeed")]
    public class Coil_Heating_DX_MultiSpeed : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
        public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

        [Description(@"The outdoor temperature when the compressor is automatically turned back on following an automatic shut off because of low outdoor dry-bulb temperature. This field is only used for the calculation of HSPF. If this field is not provided, then outdoor bin temperature used in the HSPF calculation is always considered to be greater than this temperature and 'Minimum Outdoor Dry-Bulb Temperature for Compressor Operation' field described above. This assumption is based on AHRI standard 210/240 (2008) and can introduce significant error in the final value of HSPF.")]
        [JsonProperty("outdoor_dry_bulb_temperature_to_turn_on_compressor")]
        public System.Nullable<float> OutdoorDryBulbTemperatureToTurnOnCompressor { get; set; } = null;
        

        [JsonProperty("crankcase_heater_capacity")]
        public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("biquadratic curve = a + b*wb + c*wb**2 + d*oat + e*oat**2 + f*wb*oat wb = wet-bul" +
                     "b temperature (C) of air entering the indoor coil oat = outdoor air dry-bulb tem" +
                     "perature (C) only required if ReverseCycle defrost strategy is specified")]
        [JsonProperty("defrost_energy_input_ratio_function_of_temperature_curve_name")]
        public string DefrostEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_defrost_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForDefrostOperation { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("defrost_strategy")]
        public Coil_Heating_DX_MultiSpeed_DefrostStrategy DefrostStrategy { get; set; } = (Coil_Heating_DX_MultiSpeed_DefrostStrategy)Enum.Parse(typeof(Coil_Heating_DX_MultiSpeed_DefrostStrategy), "ReverseCycle");
        

        [JsonProperty("defrost_control")]
        public Coil_Heating_DX_MultiSpeed_DefrostControl DefrostControl { get; set; } = (Coil_Heating_DX_MultiSpeed_DefrostControl)Enum.Parse(typeof(Coil_Heating_DX_MultiSpeed_DefrostControl), "Timed");
        

        [Description("Fraction of time in defrost mode only applicable if timed defrost control is spec" +
                     "ified")]
        [JsonProperty("defrost_time_period_fraction")]
        public System.Nullable<float> DefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [Description("only applicable if resistive defrost strategy is specified")]
        [JsonProperty("resistive_defrost_heater_capacity")]
        public string ResistiveDefrostHeaterCapacity { get; set; } = (System.String)"0";
        

        [JsonProperty("apply_part_load_fraction_to_speeds_greater_than_1")]
        public EmptyNoYes ApplyPartLoadFractionToSpeedsGreaterThan1 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("fuel_type")]
        public Coil_Heating_DX_MultiSpeed_FuelType FuelType { get; set; } = (Coil_Heating_DX_MultiSpeed_FuelType)Enum.Parse(typeof(Coil_Heating_DX_MultiSpeed_FuelType), "Diesel");
        

        [Description("Standard Region number for which HSPF and other standard ratings are calculated")]
        [JsonProperty("region_number_for_calculating_hspf")]
        public System.Nullable<float> RegionNumberForCalculatingHspf { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

        [Description("Enter the number of the following sets of data for coil capacity, COP, flow rate," +
                     " and associated curves.")]
        [JsonProperty("number_of_speeds")]
        public System.Nullable<float> NumberOfSpeeds { get; set; } = null;
        

        [Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty("speed_1_gross_rated_heating_capacity")]
        public string Speed1GrossRatedHeatingCapacity { get; set; } = "";
        

        [Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply air fan heat or supply air fan electrical energy")]
        [JsonProperty("speed_1_gross_rated_heating_cop")]
        public System.Nullable<float> Speed1GrossRatedHeatingCop { get; set; } = null;
        

        [Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
                     " and .00006041 m3/s per watt of rated total heating capacity")]
        [JsonProperty("speed_1_rated_air_flow_rate")]
        public string Speed1RatedAirFlowRate { get; set; } = "";
        

        [Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 1 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
        [JsonProperty("speed_1_rated_supply_air_fan_power_per_volume_flow_rate")]
        public System.Nullable<float> Speed1RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
        [JsonProperty("speed_1_heating_capacity_function_of_temperature_curve_name")]
        public string Speed1HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_1_heating_capacity_function_of_flow_fraction_curve_name")]
        public string Speed1HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
        [JsonProperty("speed_1_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_1_energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string Speed1EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
        [JsonProperty("speed_1_part_load_fraction_correlation_curve_name")]
        public string Speed1PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("recoverable waste heat at full load and rated conditions")]
        [JsonProperty("speed_1_rated_waste_heat_fraction_of_power_input")]
        public System.Nullable<float> Speed1RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty("speed_1_waste_heat_function_of_temperature_curve_name")]
        public string Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty("speed_2_gross_rated_heating_capacity")]
        public string Speed2GrossRatedHeatingCapacity { get; set; } = "";
        

        [Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply air fan heat or supply air fan electrical energy")]
        [JsonProperty("speed_2_gross_rated_heating_cop")]
        public System.Nullable<float> Speed2GrossRatedHeatingCop { get; set; } = null;
        

        [Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
                     " and .00006041 m3/s per watt of rated total heating capacity")]
        [JsonProperty("speed_2_rated_air_flow_rate")]
        public string Speed2RatedAirFlowRate { get; set; } = "";
        

        [Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 2 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
        [JsonProperty("speed_2_rated_supply_air_fan_power_per_volume_flow_rate")]
        public System.Nullable<float> Speed2RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
        [JsonProperty("speed_2_heating_capacity_function_of_temperature_curve_name")]
        public string Speed2HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_2_heating_capacity_function_of_flow_fraction_curve_name")]
        public string Speed2HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
        [JsonProperty("speed_2_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_2_energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string Speed2EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
        [JsonProperty("speed_2_part_load_fraction_correlation_curve_name")]
        public string Speed2PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("recoverable waste heat at full load and rated conditions")]
        [JsonProperty("speed_2_rated_waste_heat_fraction_of_power_input")]
        public System.Nullable<float> Speed2RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty("speed_2_waste_heat_function_of_temperature_curve_name")]
        public string Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty("speed_3_gross_rated_heating_capacity")]
        public string Speed3GrossRatedHeatingCapacity { get; set; } = "";
        

        [Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply air fan heat or supply air fan electrical energy")]
        [JsonProperty("speed_3_gross_rated_heating_cop")]
        public System.Nullable<float> Speed3GrossRatedHeatingCop { get; set; } = null;
        

        [Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
                     " and .00006041 m3/s per watt of rated total heating capacity")]
        [JsonProperty("speed_3_rated_air_flow_rate")]
        public string Speed3RatedAirFlowRate { get; set; } = "";
        

        [Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 3 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
        [JsonProperty("speed_3_rated_supply_air_fan_power_per_volume_flow_rate")]
        public System.Nullable<float> Speed3RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
        [JsonProperty("speed_3_heating_capacity_function_of_temperature_curve_name")]
        public string Speed3HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_3_heating_capacity_function_of_flow_fraction_curve_name")]
        public string Speed3HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
        [JsonProperty("speed_3_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_3_energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string Speed3EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
        [JsonProperty("speed_3_part_load_fraction_correlation_curve_name")]
        public string Speed3PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("recoverable waste heat at full load and rated conditions")]
        [JsonProperty("speed_3_rated_waste_heat_fraction_of_power_input")]
        public System.Nullable<float> Speed3RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty("speed_3_waste_heat_function_of_temperature_curve_name")]
        public string Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty("speed_4_gross_rated_heating_capacity")]
        public string Speed4GrossRatedHeatingCapacity { get; set; } = "";
        

        [Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply air fan heat or supply air fan electrical energy")]
        [JsonProperty("speed_4_gross_rated_heating_cop")]
        public System.Nullable<float> Speed4GrossRatedHeatingCop { get; set; } = null;
        

        [Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
                     " and .00006041 m3/s per watt of rated total heating capacity")]
        [JsonProperty("speed_4_rated_air_flow_rate")]
        public string Speed4RatedAirFlowRate { get; set; } = "";
        

        [Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 4 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
        [JsonProperty("speed_4_rated_supply_air_fan_power_per_volume_flow_rate")]
        public System.Nullable<float> Speed4RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
        [JsonProperty("speed_4_heating_capacity_function_of_temperature_curve_name")]
        public string Speed4HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_4_heating_capacity_function_of_flow_fraction_curve_name")]
        public string Speed4HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
        [JsonProperty("speed_4_energy_input_ratio_function_of_temperature_curve_name")]
        public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("speed_4_energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string Speed4EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
        [JsonProperty("speed_4_part_load_fraction_correlation_curve_name")]
        public string Speed4PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("recoverable waste heat at full load and rated conditions")]
        [JsonProperty("speed_4_rated_waste_heat_fraction_of_power_input")]
        public System.Nullable<float> Speed4RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty("speed_4_waste_heat_function_of_temperature_curve_name")]
        public string Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (evaporator) of a heat pump is to be placed. This is an optional input field specified only when user desires to extract heat from the zone. The heat extracted is modeled as internal heat gain of the zone. If the primary DX system is a heat pump, then the zone name should be the same as the zone name specified for placing the secondary cooling DX coil.")]
        [JsonProperty("zone_name_for_evaporator_placement")]
        public string ZoneNameForEvaporatorPlacement { get; set; } = "";
        

        [Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
                     "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
                     "e when the heat pump is working in cooling mode.")]
        [JsonProperty("speed_1_secondary_coil_air_flow_rate")]
        public string Speed1SecondaryCoilAirFlowRate { get; set; } = "";
        

        [Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
        [JsonProperty("speed_1_secondary_coil_fan_flow_scaling_factor")]
        public System.Nullable<float> Speed1SecondaryCoilFanFlowScalingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
        [JsonProperty("speed_1_nominal_sensible_heat_ratio_of_secondary_coil")]
        public System.Nullable<float> Speed1NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

        [Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
        [JsonProperty("speed_1_sensible_heat_ratio_modifier_function_of_temperature_curve_name")]
        public string Speed1SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
        [JsonProperty("speed_1_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name")]
        public string Speed1SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
                     "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
                     "e when the heat pump is working in cooling mode.")]
        [JsonProperty("speed_2_secondary_coil_air_flow_rate")]
        public string Speed2SecondaryCoilAirFlowRate { get; set; } = "";
        

        [Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
        [JsonProperty("speed_2_secondary_coil_fan_flow_scaling_factor")]
        public System.Nullable<float> Speed2SecondaryCoilFanFlowScalingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
        [JsonProperty("speed_2_nominal_sensible_heat_ratio_of_secondary_coil")]
        public System.Nullable<float> Speed2NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

        [Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
        [JsonProperty("speed_2_sensible_heat_ratio_modifier_function_of_temperature_curve_name")]
        public string Speed2SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
        [JsonProperty("speed_2_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name")]
        public string Speed2SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
                     "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
                     "e when the heat pump is working in cooling mode.")]
        [JsonProperty("speed_3_secondary_coil_air_flow_rate")]
        public string Speed3SecondaryCoilAirFlowRate { get; set; } = "";
        

        [Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
        [JsonProperty("speed_3_secondary_coil_fan_flow_scaling_factor")]
        public System.Nullable<float> Speed3SecondaryCoilFanFlowScalingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
        [JsonProperty("speed_3_nominal_sensible_heat_ratio_of_secondary_coil")]
        public System.Nullable<float> Speed3NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

        [Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
        [JsonProperty("speed_3_sensible_heat_ratio_modifier_function_of_temperature_curve_name")]
        public string Speed3SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
        [JsonProperty("speed_3_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name")]
        public string Speed3SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
                     "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
                     "e when the heat pump is working in cooling mode.")]
        [JsonProperty("speed_4_secondary_coil_air_flow_rate")]
        public string Speed4SecondaryCoilAirFlowRate { get; set; } = "";
        

        [Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
        [JsonProperty("speed_4_secondary_coil_fan_flow_scaling_factor")]
        public System.Nullable<float> Speed4SecondaryCoilFanFlowScalingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
        [JsonProperty("speed_4_nominal_sensible_heat_ratio_of_secondary_coil")]
        public System.Nullable<float> Speed4NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

        [Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
        [JsonProperty("speed_4_sensible_heat_ratio_modifier_function_of_temperature_curve_name")]
        public string Speed4SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
        [JsonProperty("speed_4_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name")]
        public string Speed4SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
    }
}