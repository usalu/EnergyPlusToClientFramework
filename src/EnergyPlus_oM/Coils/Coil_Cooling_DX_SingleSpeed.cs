using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Direct expansion (DX) cooling coil and condensing unit (includes electric compres" +
                 "sor and condenser fan), single-speed. Optional inputs for moisture evaporation f" +
                 "rom wet coil when compressor cycles off with continuous fan operation.")]
    [JsonObject("Coil:Cooling:DX:SingleSpeed")]
    public class Coil_Cooling_DX_SingleSpeed : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description(@"Total cooling capacity not accounting for the effect of supply air fan heat gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty("gross_rated_total_cooling_capacity")]
        public string GrossRatedTotalCoolingCapacity { get; set; } = "";
        

        [Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) sensible" +
                     " and total capacities do not include supply fan heat")]
        [JsonProperty("gross_rated_sensible_heat_ratio")]
        public string GrossRatedSensibleHeatRatio { get; set; } = "";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input")]
        [JsonProperty("gross_rated_cooling_cop")]
        public System.Nullable<float> GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP " +
                     "should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total coo" +
                     "ling capacity")]
        [JsonProperty("rated_air_flow_rate")]
        public string RatedAirFlowRate { get; set; } = "";
        

        [Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), Energy Efficiency Ratio (EER), Integrated Energy Efficiency Ratio (IEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
        [JsonProperty("rated_evaporator_fan_power_per_volume_flow_rate")]
        public System.Nullable<float> RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("total_cooling_capacity_function_of_temperature_curve_name")]
        public string TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = Fraction of the full load flow")]
        [JsonProperty("total_cooling_capacity_function_of_flow_fraction_curve_name")]
        public string TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("energy_input_ratio_function_of_temperature_curve_name")]
        public string EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = Fraction of the full load flow")]
        [JsonProperty("energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (cooling load/steady state capacity)")]
        [JsonProperty("part_load_fraction_correlation_curve_name")]
        public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
        public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

        [Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
        [JsonProperty("nominal_time_for_condensate_removal_to_begin")]
        public System.Nullable<float> NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
        [JsonProperty("ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capacity")]
        public System.Nullable<float> RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The maximum on-off cycling Rate for the compressor, which occurs at 50% run time " +
                     "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("maximum_cycling_rate")]
        public System.Nullable<float> MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
                     "startup. Suggested value is 45; zero value means latent degradation model is dis" +
                     "abled.")]
        [JsonProperty("latent_capacity_time_constant")]
        public System.Nullable<float> LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
                     "doorAir:Node or OutdoorAir:NodeList object.")]
        [JsonProperty("condenser_air_inlet_node_name")]
        public string CondenserAirInletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_type")]
        public Coil_Cooling_DX_SingleSpeed_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_SingleSpeed_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_CondenserType), "AirCooled");
        

        [JsonProperty("evaporative_condenser_effectiveness")]
        public System.Nullable<float> EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Used to calculate evaporative condenser water use")]
        [JsonProperty("evaporative_condenser_air_flow_rate")]
        public string EvaporativeCondenserAirFlowRate { get; set; } = "";
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump")]
        [JsonProperty("evaporative_condenser_pump_rated_power_consumption")]
        public string EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = (System.String)"0";
        

        [JsonProperty("crankcase_heater_capacity")]
        public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

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
        

        [Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temp" +
                     "erature seen by the DX cooling coil (C) db = entering dry-bulb temperature seen " +
                     "by the DX cooling coil (C) entering temperature can be outside air or pretreated" +
                     " air.")]
        [JsonProperty("sensible_heat_ratio_function_of_temperature_curve_name")]
        public string SensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("sensible_heat_ratio_function_of_flow_fraction_curve_name")]
        public string SensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("when this input field is specified as Yes then the program calculates the net coo" +
                     "ling capacity and total electric power input of DX cooling coils per ANSI/ASHRAE" +
                     " 127.")]
        [JsonProperty("report_ashrae_standard_127_performance_ratings")]
        public EmptyNoYes ReportAshraeStandard127PerformanceRatings { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (condenser) of DX system or a heat pump is to be placed. This is an optional input field specified only when user desires to reject the condenser heat into a zone. The heat rejected is modelled as internal sensible heat gain of the zone.")]
        [JsonProperty("zone_name_for_condenser_placement")]
        public string ZoneNameForCondenserPlacement { get; set; } = "";
    }
}