using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"vairlable-speed Heat pump water heater (VSHPWH) heating coil, air-to-water direct-expansion (DX) system which includes a variable-speed water heating coil, evaporator air coil, evaporator fan, electric compressor, and water pump. Part of a WaterHeater:HeatPump system.")]
    public class Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("number_of_speeds")]
        public System.Nullable<float> NumberOfSpeeds { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("must be lower than or equal to the highest speed number")]
        [JsonProperty("nominal_speed_level")]
        public System.Nullable<float> NominalSpeedLevel { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Water Heating capacity at the rated inlet air temperatures, rated condenser inlet" +
                     " water temperature, rated air flow rate, and rated water flow rate. Can optional" +
                     "ly include condenser pump heat.")]
        [JsonProperty("rated_water_heating_capacity")]
        public System.Nullable<float> RatedWaterHeatingCapacity { get; set; } = null;
        

        [Description("Evaporator inlet air dry-bulb temperature corresponding to rated coil performance" +
                     " (heating capacity, COP and SHR).")]
        [JsonProperty("rated_evaporator_inlet_air_dry_bulb_temperature")]
        public System.Nullable<float> RatedEvaporatorInletAirDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("19.7", CultureInfo.InvariantCulture);
        

        [Description("Evaporator inlet air wet-bulb temperature corresponding to rated coil performance" +
                     " (heating capacity, COP and SHR).")]
        [JsonProperty("rated_evaporator_inlet_air_wet_bulb_temperature")]
        public System.Nullable<float> RatedEvaporatorInletAirWetBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13.5", CultureInfo.InvariantCulture);
        

        [Description("Condenser inlet water temperature corresponding to rated coil performance (heatin" +
                     "g capacity, COP and SHR).")]
        [JsonProperty("rated_condenser_inlet_water_temperature")]
        public System.Nullable<float> RatedCondenserInletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("57.5", CultureInfo.InvariantCulture);
        

        [Description("Evaporator air flow rate corresponding to rated coil performance (heating capacit" +
                     "y, COP and SHR). Default is 5.035E-5 m3/s/W (31.25 cfm/MBH) of rated heating cap" +
                     "acity when autocalculated.")]
        [JsonProperty("rated_evaporator_air_flow_rate")]
        public string RatedEvaporatorAirFlowRate { get; set; } = "";
        

        [Description(@"Condenser water flow rate corresponding to rated coil performance (heating capacity, COP and SHR). Default is 4.487E-8 m3/s/W (0.208 gpm/MBH) of rated heating capacity when autocalculated. A warning message will be issued if the ratio of Rated Condenser Water Flow Rate to Heating Capacity is less than 1.79405E-8 m3/s/W (0.083 gpm/MBH) or greater than 8.97024E-8 m3/s/W (0.417 gpm/MBH), but the simulation will continue.")]
        [JsonProperty("rated_condenser_water_flow_rate")]
        public string RatedCondenserWaterFlowRate { get; set; } = "";
        

        [Description("Select Yes if the evaporator fan power is included in the rated COP. This choice " +
                     "field impacts the calculation of compressor electric power.")]
        [JsonProperty("evaporator_fan_power_included_in_rated_cop")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes EvaporatorFanPowerIncludedInRatedCop { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("Select Yes if the condenser pump power is included in the rated COP. This choice " +
                     "field impacts the calculation of compressor electric power.")]
        [JsonProperty("condenser_pump_power_included_in_rated_cop")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes CondenserPumpPowerIncludedInRatedCop { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Select Yes if the condenser pump heat is included in the rated heating capacity a" +
                     "nd rated COP. This choice field impacts the calculation of water heating capacit" +
                     "y.")]
        [JsonProperty("condenser_pump_heat_included_in_rated_heating_capacity_and_rated_cop")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes CondenserPumpHeatIncludedInRatedHeatingCapacityAndRatedCop { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Fraction of pump heat transferred to the condenser water. The pump is assumed to " +
                     "be located downstream of the condenser.")]
        [JsonProperty("fraction_of_condenser_pump_heat_to_water")]
        public System.Nullable<float> FractionOfCondenserPumpHeatToWater { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("The node from which the DX coil draws its inlet air.")]
        [JsonProperty("evaporator_air_inlet_node_name")]
        public string EvaporatorAirInletNodeName { get; set; } = "";
        

        [Description("The node to which the DX coil sends its outlet air.")]
        [JsonProperty("evaporator_air_outlet_node_name")]
        public string EvaporatorAirOutletNodeName { get; set; } = "";
        

        [Description("The node from which the DX coil condenser draws its inlet water. This name should" +
                     " match the source side outlet node name in the associated water heater tank obje" +
                     "ct.")]
        [JsonProperty("condenser_water_inlet_node_name")]
        public string CondenserWaterInletNodeName { get; set; } = "";
        

        [Description("The node to which the DX coil condenser sends its outlet water. This name should " +
                     "match the source side inlet node name in the associated water heater tank object" +
                     ".")]
        [JsonProperty("condenser_water_outlet_node_name")]
        public string CondenserWaterOutletNodeName { get; set; } = "";
        

        [Description(@"The compressor crankcase heater only operates when the dry-bulb temperature of air surrounding the compressor is below the Maximum Ambient Temperature for Crankcase Heater Operation and the DX coil is off. The ambient temperature surrounding the compressor is set by the WaterHeater:HeatPump parent object (field Compressor Location).")]
        [JsonProperty("crankcase_heater_capacity")]
        public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"The compressor crankcase heater only operates when the dry-bulb temperature of air surrounding the compressor is below the Maximum Outdoor Temperature for Crankcase Heater Operation and the unit is off. The ambient temperature surrounding the compressor is set by the WaterHeater:HeatPump parent object (field Compressor Location).")]
        [JsonProperty("maximum_ambient_temperature_for_crankcase_heater_operation")]
        public System.Nullable<float> MaximumAmbientTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Determines temperature type for heating capacity curves and heating COP curves. T" +
                     "his input determines whether the inlet air dry-bulb or wet-bulb temperature is u" +
                     "sed to evaluate these curves.")]
        [JsonProperty("evaporator_air_temperature_type_for_curve_objects")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed_EvaporatorAirTemperatureTypeForCurveObjects EvaporatorAirTemperatureTypeForCurveObjects { get; set; } = (Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed_EvaporatorAirTemperatureTypeForCurveObjects)Enum.Parse(typeof(Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed_EvaporatorAirTemperatureTypeForCurveObjects), "WetBulbTemperature");
        

        [Description(@"Table:Lookup object can also be used Part Load Fraction Correlation (function of part load ratio) should be quadratic or cubic. Quadratic curve = a + b(PLR) + c(PLR)^2. Cubic curve = a + b(PLR) + c(PLR)^2 + d(PLR)^3. PLR = part load ratio (heating delivered/steady state heating capacity). Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in part load ratio.")]
        [JsonProperty("part_load_fraction_correlation_curve_name")]
        public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
                     " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
                     "lude condenser pump heat.")]
        [JsonProperty("rated_water_heating_capacity_at_speed_1")]
        public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed1 { get; set; } = null;
        

        [Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
        [JsonProperty("rated_water_heating_cop_at_speed_1")]
        public System.Nullable<float> RatedWaterHeatingCopAtSpeed1 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
        [JsonProperty("rated_sensible_heat_ratio_at_speed_1")]
        public System.Nullable<float> RatedSensibleHeatRatioAtSpeed1 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

        [JsonProperty("speed_1_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed1ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_1_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed1ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [JsonProperty("speed_1_reference_unit_water_pump_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed1ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_1_total_wh_capacity_function_of_temperature_curve_name")]
        public string Speed1TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_1_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed1TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_1_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed1TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_1_cop_function_of_temperature_curve_name")]
        public string Speed1CopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_1_cop_function_of_air_flow_fraction_curve_name")]
        public string Speed1CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_1_cop_function_of_water_flow_fraction_curve_name")]
        public string Speed1CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
                     " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
                     "lude condenser pump heat.")]
        [JsonProperty("rated_water_heating_capacity_at_speed_2")]
        public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed2 { get; set; } = null;
        

        [Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
        [JsonProperty("rated_water_heating_cop_at_speed_2")]
        public System.Nullable<float> RatedWaterHeatingCopAtSpeed2 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
        [JsonProperty("rated_sensible_heat_ratio_at_speed_2")]
        public System.Nullable<float> RatedSensibleHeatRatioAtSpeed2 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

        [JsonProperty("speed_2_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed2ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed2ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [JsonProperty("speed_2_reference_unit_water_pump_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed2ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_2_total_wh_capacity_function_of_temperature_curve_name")]
        public string Speed2TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_2_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed2TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_2_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed2TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_2_cop_function_of_temperature_curve_name")]
        public string Speed2CopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_2_cop_function_of_air_flow_fraction_curve_name")]
        public string Speed2CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_2_cop_function_of_water_flow_fraction_curve_name")]
        public string Speed2CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
                     " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
                     "lude condenser pump heat.")]
        [JsonProperty("rated_water_heating_capacity_at_speed_3")]
        public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed3 { get; set; } = null;
        

        [Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
        [JsonProperty("rated_water_heating_cop_at_speed_3")]
        public System.Nullable<float> RatedWaterHeatingCopAtSpeed3 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
        [JsonProperty("rated_sensible_heat_ratio_at_speed_3")]
        public System.Nullable<float> RatedSensibleHeatRatioAtSpeed3 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

        [JsonProperty("speed_3_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed3ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed3ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [JsonProperty("speed_3_reference_unit_water_pump_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed3ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_3_total_wh_capacity_function_of_temperature_curve_name")]
        public string Speed3TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_3_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed3TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_3_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed3TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_3_cop_function_of_temperature_curve_name")]
        public string Speed3CopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_3_cop_function_of_air_flow_fraction_curve_name")]
        public string Speed3CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_3_cop_function_of_water_flow_fraction_curve_name")]
        public string Speed3CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
                     " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
                     "lude condenser pump heat.")]
        [JsonProperty("rated_water_heating_capacity_at_speed_4")]
        public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed4 { get; set; } = null;
        

        [Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
        [JsonProperty("rated_water_heating_cop_at_speed_4")]
        public System.Nullable<float> RatedWaterHeatingCopAtSpeed4 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
        [JsonProperty("rated_sensible_heat_ratio_at_speed_4")]
        public System.Nullable<float> RatedSensibleHeatRatioAtSpeed4 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

        [JsonProperty("speed_4_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed4ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed4ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [JsonProperty("speed_4_reference_unit_water_pump_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed4ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_4_total_wh_capacity_function_of_temperature_curve_name")]
        public string Speed4TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_4_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed4TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_4_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed4TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_4_cop_function_of_temperature_curve_name")]
        public string Speed4CopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_4_cop_function_of_air_flow_fraction_curve_name")]
        public string Speed4CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_4_cop_function_of_water_flow_fraction_curve_name")]
        public string Speed4CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
                     " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
                     "lude condenser pump heat.")]
        [JsonProperty("rated_water_heating_capacity_at_speed_5")]
        public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed5 { get; set; } = null;
        

        [Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
        [JsonProperty("rated_water_heating_cop_at_speed_5")]
        public System.Nullable<float> RatedWaterHeatingCopAtSpeed5 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
        [JsonProperty("rated_sensible_heat_ratio_at_speed_5")]
        public System.Nullable<float> RatedSensibleHeatRatioAtSpeed5 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

        [JsonProperty("speed_5_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed5ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed5ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [JsonProperty("speed_5_reference_unit_water_pump_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed5ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_5_total_wh_capacity_function_of_temperature_curve_name")]
        public string Speed5TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_5_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed5TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_5_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed5TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_5_cop_function_of_temperature_curve_name")]
        public string Speed5CopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_5_cop_function_of_air_flow_fraction_curve_name")]
        public string Speed5CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_5_cop_function_of_water_flow_fraction_curve_name")]
        public string Speed5CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
                     " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
                     "lude condenser pump heat.")]
        [JsonProperty("rated_water_heating_capacity_at_speed_6")]
        public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed6 { get; set; } = null;
        

        [Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
        [JsonProperty("rated_water_heating_cop_at_speed_6")]
        public System.Nullable<float> RatedWaterHeatingCopAtSpeed6 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
        [JsonProperty("rated_sensible_heat_ratio_at_speed_6")]
        public System.Nullable<float> RatedSensibleHeatRatioAtSpeed6 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

        [JsonProperty("speed_6_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed6ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed6ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [JsonProperty("speed_6_reference_unit_water_pump_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed6ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_6_total_wh_capacity_function_of_temperature_curve_name")]
        public string Speed6TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_6_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed6TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_6_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed6TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_6_cop_function_of_temperature_curve_name")]
        public string Speed6CopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_6_cop_function_of_air_flow_fraction_curve_name")]
        public string Speed6CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_6_cop_function_of_water_flow_fraction_curve_name")]
        public string Speed6CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
                     " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
                     "lude condenser pump heat.")]
        [JsonProperty("rated_water_heating_capacity_at_speed_7")]
        public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed7 { get; set; } = null;
        

        [Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
        [JsonProperty("rated_water_heating_cop_at_speed_7")]
        public System.Nullable<float> RatedWaterHeatingCopAtSpeed7 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
        [JsonProperty("rated_sensible_heat_ratio_at_speed_7")]
        public System.Nullable<float> RatedSensibleHeatRatioAtSpeed7 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

        [JsonProperty("speed_7_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed7ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed7ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [JsonProperty("speed_7_reference_unit_water_pump_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed7ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_7_total_wh_capacity_function_of_temperature_curve_name")]
        public string Speed7TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_7_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed7TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_7_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed7TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_7_cop_function_of_temperature_curve_name")]
        public string Speed7CopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_7_cop_function_of_air_flow_fraction_curve_name")]
        public string Speed7CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_7_cop_function_of_water_flow_fraction_curve_name")]
        public string Speed7CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
                     " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
                     "lude condenser pump heat.")]
        [JsonProperty("rated_water_heating_capacity_at_speed_8")]
        public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed8 { get; set; } = null;
        

        [Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
        [JsonProperty("rated_water_heating_cop_at_speed_8")]
        public System.Nullable<float> RatedWaterHeatingCopAtSpeed8 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
        [JsonProperty("rated_sensible_heat_ratio_at_speed_8")]
        public System.Nullable<float> RatedSensibleHeatRatioAtSpeed8 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

        [JsonProperty("speed_8_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed8ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed8ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [JsonProperty("speed_8_reference_unit_water_pump_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed8ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_8_total_wh_capacity_function_of_temperature_curve_name")]
        public string Speed8TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_8_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed8TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_8_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed8TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_8_cop_function_of_temperature_curve_name")]
        public string Speed8CopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_8_cop_function_of_air_flow_fraction_curve_name")]
        public string Speed8CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_8_cop_function_of_water_flow_fraction_curve_name")]
        public string Speed8CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
                     " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
                     "lude condenser pump heat.")]
        [JsonProperty("rated_water_heating_capacity_at_speed_9")]
        public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed9 { get; set; } = null;
        

        [Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
        [JsonProperty("rated_water_heating_cop_at_speed_9")]
        public System.Nullable<float> RatedWaterHeatingCopAtSpeed9 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
        [JsonProperty("rated_sensible_heat_ratio_at_speed_9")]
        public System.Nullable<float> RatedSensibleHeatRatioAtSpeed9 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

        [JsonProperty("speed_9_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed9ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_9_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed9ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [JsonProperty("speed_9_reference_unit_water_pump_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed9ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_9_total_wh_capacity_function_of_temperature_curve_name")]
        public string Speed9TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_9_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed9TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_9_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed9TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_9_cop_function_of_temperature_curve_name")]
        public string Speed9CopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_9_cop_function_of_air_flow_fraction_curve_name")]
        public string Speed9CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_9_cop_function_of_water_flow_fraction_curve_name")]
        public string Speed9CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
                     " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
                     "lude condenser pump heat.")]
        [JsonProperty("rated_water_heating_capacity_at_speed_10")]
        public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed10 { get; set; } = null;
        

        [Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
        [JsonProperty("rated_water_heating_cop_at_speed_10")]
        public System.Nullable<float> RatedWaterHeatingCopAtSpeed10 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
        [JsonProperty("rated_sensible_heat_ratio_at_speed_10")]
        public System.Nullable<float> RatedSensibleHeatRatioAtSpeed10 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

        [JsonProperty("speed_10_reference_unit_rated_air_flow_rate")]
        public System.Nullable<float> Speed10ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty("speed_10_reference_unit_rated_water_flow_rate")]
        public System.Nullable<float> Speed10ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [JsonProperty("speed_10_reference_unit_water_pump_input_power_at_rated_conditions")]
        public System.Nullable<float> Speed10ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_10_total_wh_capacity_function_of_temperature_curve_name")]
        public string Speed10TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_10_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
        public string Speed10TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_10_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
        public string Speed10TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
                     "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
                     "ection (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty("speed_10_cop_function_of_temperature_curve_name")]
        public string Speed10CopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
                     " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
                     "w")]
        [JsonProperty("speed_10_cop_function_of_air_flow_fraction_curve_name")]
        public string Speed10CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
                     " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
                     "low")]
        [JsonProperty("speed_10_cop_function_of_water_flow_fraction_curve_name")]
        public string Speed10CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
    }
}