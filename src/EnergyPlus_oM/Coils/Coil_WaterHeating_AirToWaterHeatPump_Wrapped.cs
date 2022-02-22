using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Heat pump water heater (HPWH) heating coil, air-to-water direct-expansion (DX) sy" +
                 "stem which includes a water heating coil, evaporator air coil, evaporator fan, e" +
                 "lectric compressor, and water pump. Part of a WaterHeater:HeatPump:WrappedConden" +
                 "ser system.")]
    [JsonObject("Coil:WaterHeating:AirToWaterHeatPump:Wrapped")]
    public class Coil_WaterHeating_AirToWaterHeatPump_Wrapped : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
                     " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
                     "lude condenser pump heat.")]
        [JsonProperty("rated_heating_capacity")]
        public System.Nullable<float> RatedHeatingCapacity { get; set; } = null;
        

        [Description("Heating coefficient of performance at the rated inlet air temperatures, rated con" +
                     "denser inlet water temperature, rated air flow rate, and rated water flow rate. " +
                     "Can optionally include condenser pump power and evaporator fan power (see fields" +
                     " below).")]
        [JsonProperty("rated_cop")]
        public System.Nullable<float> RatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
        [JsonProperty("rated_sensible_heat_ratio")]
        public System.Nullable<float> RatedSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

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
        [JsonProperty("rated_condenser_water_temperature")]
        public System.Nullable<float> RatedCondenserWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("57.5", CultureInfo.InvariantCulture);
        

        [Description("Evaporator air flow rate corresponding to rated coil performance (heating capacit" +
                     "y, COP and SHR). Default is 5.035E-5 m3/s/W (31.25 cfm/MBH) of rated heating cap" +
                     "acity when autocalculated.")]
        [JsonProperty("rated_evaporator_air_flow_rate")]
        public string RatedEvaporatorAirFlowRate { get; set; } = "";
        

        [Description("Select Yes if the evaporator fan power is included in the rated COP. This choice " +
                     "field impacts the calculation of compressor electric power.")]
        [JsonProperty("evaporator_fan_power_included_in_rated_cop")]
        public EmptyNoYes EvaporatorFanPowerIncludedInRatedCop { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("The node from which the DX coil draws its inlet air.")]
        [JsonProperty("evaporator_air_inlet_node_name")]
        public string EvaporatorAirInletNodeName { get; set; } = "";
        

        [Description("The node to which the DX coil sends its outlet air.")]
        [JsonProperty("evaporator_air_outlet_node_name")]
        public string EvaporatorAirOutletNodeName { get; set; } = "";
        

        [Description(@"The compressor crankcase heater only operates when the dry-bulb temperature of air surrounding the compressor is below the Maximum Ambient Temperature for Crankcase Heater Operation and the DX coil is off. The ambient temperature surrounding the compressor is set by the WaterHeater:HeatPump:WrappedCondenser parent object (field Compressor Location).")]
        [JsonProperty("crankcase_heater_capacity")]
        public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"The compressor crankcase heater only operates when the dry-bulb temperature of air surrounding the compressor is below the Maximum Outdoor Temperature for Crankcase Heater Operation and the unit is off. The ambient temperature surrounding the compressor is set by the WaterHeater:HeatPump:WrappedCondenser parent object (field Compressor Location).")]
        [JsonProperty("maximum_ambient_temperature_for_crankcase_heater_operation")]
        public System.Nullable<float> MaximumAmbientTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Determines temperature type for heating capacity curves and heating COP curves. T" +
                     "his input determines whether the inlet air dry-bulb or wet-bulb temperature is u" +
                     "sed to evaluate these curves.")]
        [JsonProperty("evaporator_air_temperature_type_for_curve_objects")]
        public Coil_WaterHeating_AirToWaterHeatPump_Wrapped_EvaporatorAirTemperatureTypeForCurveObjects EvaporatorAirTemperatureTypeForCurveObjects { get; set; } = (Coil_WaterHeating_AirToWaterHeatPump_Wrapped_EvaporatorAirTemperatureTypeForCurveObjects)Enum.Parse(typeof(Coil_WaterHeating_AirToWaterHeatPump_Wrapped_EvaporatorAirTemperatureTypeForCurveObjects), "WetBulbTemperature");
        

        [Description(@"Heating capacity modifier curve (function of temperature) should be biquadratic or cubic. Biquadratic curve = a + b(ta) + c(ta)^2 + d(tw) + e(tw)^2 + f(ta)(tw). Cubic curve = a + b(ta) + c(ta)^2 + d(ta)^3. ta = evaporator inlet air [dry-bulb or wet-bulb] temperature (C). tw = condenser inlet water temperature (C). The field Evaporator Air Temperature Type for Curve Objects determines if dry-bulb or wet-bulb is used as the evaporator inlet air temperature (ta).")]
        [JsonProperty("heating_capacity_function_of_temperature_curve_name")]
        public string HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Heating capacity modifier curve (function of air flow fraction) should be quadratic or cubic. Quadratic curve = a + b(ff) + c(ff)^2. Cubic curve = a + b(ff) + c(ff)^2 + d(ff)^3. ff = fraction of the rated evaporator air flow rate. Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in air flow rate fraction.")]
        [JsonProperty("heating_capacity_function_of_air_flow_fraction_curve_name")]
        public string HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description(@"Heating COP modifier curve (function of temperature) should be biquadratic or cubic. Biquadratic curve = a + b(ta) + c(ta)^2 + d(tw) + e(tw)^2 + f(ta)(tw). Cubic curve = a + b(ta) + c(ta)^2 + d(ta)^3. ta = evaporator inlet air [dry-bulb or wet-bulb] temperature (C). tw = condenser inlet water temperature (C). The field Evaporator Air Temperature Type for Curve Objects determines if dry-bulb or wet-bulb is used as the evaporator inlet air temperature (ta).")]
        [JsonProperty("heating_cop_function_of_temperature_curve_name")]
        public string HeatingCopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Heating COP modifier curve (function of air flow fraction) should be quadratic or cubic. Quadratic curve = a + b(ff) + c(ff)^2. Cubic curve = a + b(ff) + c(ff)^2 + d(ff)^3. ff = fraction of the rated evaporator air flow rate. Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in air flow rate fraction.")]
        [JsonProperty("heating_cop_function_of_air_flow_fraction_curve_name")]
        public string HeatingCopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description(@"Part Load Fraction Correlation (function of part load ratio) should be quadratic or cubic. Quadratic curve = a + b(PLR) + c(PLR)^2. Cubic curve = a + b(PLR) + c(PLR)^2 + d(PLR)^3. PLR = part load ratio (heating delivered/steady state heating capacity). Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in part load ratio.")]
        [JsonProperty("part_load_fraction_correlation_curve_name")]
        public string PartLoadFractionCorrelationCurveName { get; set; } = "";
    }
}