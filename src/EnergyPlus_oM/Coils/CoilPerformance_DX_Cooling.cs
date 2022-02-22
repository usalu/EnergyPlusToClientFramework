using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Used to specify DX cooling coil performance for one mode of operation for a Coil:Cooling:DX:TwoStageWithHumidityControlMode object which may reference one to four CoilPerformance:DX:Cooling objects depending on the specified number of stages and dehumidification modes. In nearly all cases, the Rated Air Flow Rate will be the same for all performance objects associated with a given coil. If bypass is specified, the Rated Air Flow Rate includes both the bypassed flow and the flow through the active part of the coil.")]
    public class CoilPerformance_DX_Cooling : BHoMObject, IEnergyPlusClass
    {
        

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
        

        [Description("Flow rate corresponding to Rated total Cooling capacity, Rated SHR and Rated COP")]
        [JsonProperty("rated_air_flow_rate")]
        public string RatedAirFlowRate { get; set; } = "";
        

        [Description(@"Fraction of Rated Air Flow Rate which bypasses the cooling coil in this performance mode. The remaining portion of the flow should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total cooling capacity. This is used to model face-split coils on multi-stage units or bypass dampers. If total flow rate varies during simulation, the same fraction is bypassed.")]
        [JsonProperty("fraction_of_air_flow_bypassed_around_coil")]
        public System.Nullable<float> FractionOfAirFlowBypassedAroundCoil { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("total_cooling_capacity_function_of_temperature_curve_name")]
        public string TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("total_cooling_capacity_function_of_flow_fraction_curve_name")]
        public string TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("energy_input_ratio_function_of_temperature_curve_name")]
        public string EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (cooling load/steady state capacity)")]
        [JsonProperty("part_load_fraction_correlation_curve_name")]
        public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
        [JsonProperty("nominal_time_for_condensate_removal_to_begin")]
        public System.Nullable<float> NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
        [JsonProperty("ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capacity")]
        public System.Nullable<float> RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time " +
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CoilPerformance_DX_Cooling_CondenserType CondenserType { get; set; } = (CoilPerformance_DX_Cooling_CondenserType)Enum.Parse(typeof(CoilPerformance_DX_Cooling_CondenserType), "AirCooled");
        

        [JsonProperty("evaporative_condenser_effectiveness")]
        public System.Nullable<float> EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Used to calculate evaporative condenser water use")]
        [JsonProperty("evaporative_condenser_air_flow_rate")]
        public string EvaporativeCondenserAirFlowRate { get; set; } = "";
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump")]
        [JsonProperty("evaporative_condenser_pump_rated_power_consumption")]
        public string EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = (System.String)"0";
        

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
    }
}