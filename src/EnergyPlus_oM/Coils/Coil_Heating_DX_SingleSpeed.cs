using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Direct expansion (DX) heating coil (air-to-air heat pump) and compressor unit (in" +
                 "cludes electric compressor and outdoor fan), single-speed, with defrost controls" +
                 ".")]
    public class Coil_Heating_DX_SingleSpeed : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty("gross_rated_heating_capacity")]
        public string GrossRatedHeatingCapacity { get; set; } = "";
        

        [Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply air fan heat or supply air fan electrical energy does no" +
                     "t include supply air fan heat or supply air fan electrical energy")]
        [JsonProperty("gross_rated_heating_cop")]
        public System.Nullable<float> GrossRatedHeatingCop { get; set; } = null;
        

        [Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
                     " and .00006041 m3/s per watt of rated heating capacity")]
        [JsonProperty("rated_air_flow_rate")]
        public string RatedAirFlowRate { get; set; } = "";
        

        [Description(@"Enter the supply fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply (condenser) fan during simulations.")]
        [JsonProperty("rated_supply_fan_power_per_volume_flow_rate")]
        public System.Nullable<float> RatedSupplyFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) Biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
        [JsonProperty("heating_capacity_function_of_temperature_curve_name")]
        public string HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("heating_capacity_function_of_flow_fraction_curve_name")]
        public string HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
        [JsonProperty("energy_input_ratio_function_of_temperature_curve_name")]
        public string EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty("energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
        [JsonProperty("part_load_fraction_correlation_curve_name")]
        public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Heating_DX_SingleSpeed_DefrostStrategy DefrostStrategy { get; set; } = (Coil_Heating_DX_SingleSpeed_DefrostStrategy)Enum.Parse(typeof(Coil_Heating_DX_SingleSpeed_DefrostStrategy), "ReverseCycle");
        

        [JsonProperty("defrost_control")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Heating_DX_SingleSpeed_DefrostControl DefrostControl { get; set; } = (Coil_Heating_DX_SingleSpeed_DefrostControl)Enum.Parse(typeof(Coil_Heating_DX_SingleSpeed_DefrostControl), "Timed");
        

        [Description("Fraction of time in defrost mode only applicable if timed defrost control is spec" +
                     "ified")]
        [JsonProperty("defrost_time_period_fraction")]
        public System.Nullable<float> DefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [Description("only applicable if resistive defrost strategy is specified")]
        [JsonProperty("resistive_defrost_heater_capacity")]
        public string ResistiveDefrostHeaterCapacity { get; set; } = (System.String)"0";
        

        [Description("Standard Region number for which HSPF and other standard ratings are calculated")]
        [JsonProperty("region_number_for_calculating_hspf")]
        public System.Nullable<float> RegionNumberForCalculatingHspf { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
                     "doorAir:Node or OutdoorAir:NodeList object.")]
        [JsonProperty("evaporator_air_inlet_node_name")]
        public string EvaporatorAirInletNodeName { get; set; } = "";
        

        [Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (evaporator) of a heat pump is to be placed. This is an optional input field specified only when user desires to extract heat from the zone. The heat extracted is modelled as internal gain of the zone. If the primary DX system is a heat pump, then the zone name should be the same as the zone name specified for placing the secondary cooling DX coil.")]
        [JsonProperty("zone_name_for_evaporator_placement")]
        public string ZoneNameForEvaporatorPlacement { get; set; } = "";
        

        [Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
                     "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
                     "e when the heat pump is working in cooling mode.")]
        [JsonProperty("secondary_coil_air_flow_rate")]
        public string SecondaryCoilAirFlowRate { get; set; } = "";
        

        [Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
        [JsonProperty("secondary_coil_fan_flow_scaling_factor")]
        public System.Nullable<float> SecondaryCoilFanFlowScalingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
        [JsonProperty("nominal_sensible_heat_ratio_of_secondary_coil")]
        public System.Nullable<float> NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

        [Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
        [JsonProperty("sensible_heat_ratio_modifier_function_of_temperature_curve_name")]
        public string SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
        [JsonProperty("sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name")]
        public string SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
    }
}