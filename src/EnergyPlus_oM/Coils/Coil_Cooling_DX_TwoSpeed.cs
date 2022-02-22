using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) cooling coil and condensing unit (includes electric compressor and condenser fan), two-speed (or variable-speed). Requires two sets of performance data and will interpolate between speeds. Modeled as a single coil (multi-speed compressor or multiple compressors with row split or intertwined coil).")]
    [JsonObject("Coil:Cooling:DX:TwoSpeed")]
    public class Coil_Cooling_DX_TwoSpeed : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description(@"Total cooling capacity not accounting for the effect of supply air fan heat gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty("high_speed_gross_rated_total_cooling_capacity")]
        public string HighSpeedGrossRatedTotalCoolingCapacity { get; set; } = "";
        

        [Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) sensible" +
                     " and total capacities do not include supply fan heat")]
        [JsonProperty("high_speed_rated_sensible_heat_ratio")]
        public string HighSpeedRatedSensibleHeatRatio { get; set; } = "";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input")]
        [JsonProperty("high_speed_gross_rated_cooling_cop")]
        public System.Nullable<float> HighSpeedGrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP." +
                     " Should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total co" +
                     "oling capacity.")]
        [JsonProperty("high_speed_rated_air_flow_rate")]
        public string HighSpeedRatedAirFlowRate { get; set; } = "";
        

        [Description(@"Enter pressure drop for the unit containing the coil. This value is only used to calculate Energy Efficiency Ratio (EER), Integrated Energy Efficiency Ratio (IEER), and the Standard Rating (Net) Cooling Capacity. This value is not used for modeling the evaporator fan during simulations.")]
        [JsonProperty("unit_internal_static_air_pressure")]
        public System.Nullable<float> UnitInternalStaticAirPressure { get; set; } = null;
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

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
        

        [Description(@"Total cooling capacity not accounting for the effect of supply air fan heat gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty("low_speed_gross_rated_total_cooling_capacity")]
        public string LowSpeedGrossRatedTotalCoolingCapacity { get; set; } = "";
        

        [Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity) se" +
                     "nsible and total capacities do not include supply fan heat")]
        [JsonProperty("low_speed_gross_rated_sensible_heat_ratio")]
        public string LowSpeedGrossRatedSensibleHeatRatio { get; set; } = "";
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input")]
        [JsonProperty("low_speed_gross_rated_cooling_cop")]
        public System.Nullable<float> LowSpeedGrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP." +
                     " Should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total co" +
                     "oling capacity.")]
        [JsonProperty("low_speed_rated_air_flow_rate")]
        public string LowSpeedRatedAirFlowRate { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("low_speed_total_cooling_capacity_function_of_temperature_curve_name")]
        public string LowSpeedTotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("low_speed_energy_input_ratio_function_of_temperature_curve_name")]
        public string LowSpeedEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
                     "doorAir:Node or OutdoorAir:NodeList object.")]
        [JsonProperty("condenser_air_inlet_node_name")]
        public string CondenserAirInletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_type")]
        public Coil_Cooling_DX_TwoSpeed_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_TwoSpeed_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_TwoSpeed_CondenserType), "AirCooled");
        

        [JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
        public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

        [JsonProperty("high_speed_evaporative_condenser_effectiveness")]
        public System.Nullable<float> HighSpeedEvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Used to calculate evaporative condenser water use")]
        [JsonProperty("high_speed_evaporative_condenser_air_flow_rate")]
        public string HighSpeedEvaporativeCondenserAirFlowRate { get; set; } = "";
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump at high speed")]
        [JsonProperty("high_speed_evaporative_condenser_pump_rated_power_consumption")]
        public string HighSpeedEvaporativeCondenserPumpRatedPowerConsumption { get; set; } = "";
        

        [JsonProperty("low_speed_evaporative_condenser_effectiveness")]
        public System.Nullable<float> LowSpeedEvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Used to calculate evaporative condenser water use")]
        [JsonProperty("low_speed_evaporative_condenser_air_flow_rate")]
        public string LowSpeedEvaporativeCondenserAirFlowRate { get; set; } = "";
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump at low speed")]
        [JsonProperty("low_speed_evaporative_condenser_pump_rated_power_consumption")]
        public string LowSpeedEvaporativeCondenserPumpRatedPowerConsumption { get; set; } = "";
        

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
        

        [Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temp" +
                     "erature seen by the DX cooling coil (C) db = entering dry-bulb temperature seen " +
                     "by the DX cooling coil (C) entering temperature can be outside air or pretreated" +
                     " air.")]
        [JsonProperty("low_speed_sensible_heat_ratio_function_of_temperature_curve_name")]
        public string LowSpeedSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("low_speed_sensible_heat_ratio_function_of_flow_fraction_curve_name")]
        public string LowSpeedSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (condenser) of DX system or a heat pump is to be placed. This is an optional input field specified only when user desires to reject the condenser heat into a zone. The heat rejected is modelled as internal sensible heat gain of the zone.")]
        [JsonProperty("zone_name_for_condenser_placement")]
        public string ZoneNameForCondenserPlacement { get; set; } = "";
    }
}