using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Direct expansion (DX) cooling coil and condensing unit (includes electric compres" +
                 "sor and condenser fan), single-speed with packaged integrated thermal storage fo" +
                 "r cooling.")]
    [JsonObject("Coil:Cooling:DX:SingleSpeed:ThermalStorage")]
    public class Coil_Cooling_DX_SingleSpeed_ThermalStorage : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("operating_mode_control_method")]
        public EmptyNoYes OperatingModeControlMethod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("This field is used if the control method is set to ScheduledModes Schedule values" +
                     " control operating mode: 0=off, 1=cooling only, 2= cooling and charge, 3= coolin" +
                     "g and discharge, 4= charge only, and 5= discharge only")]
        [JsonProperty("operation_mode_control_schedule_name")]
        public string OperationModeControlScheduleName { get; set; } = "";
        

        [JsonProperty("storage_type")]
        public EmptyNoYes StorageType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("This field is required when Storage Type is UserDefinedFluidType")]
        [JsonProperty("user_defined_fluid_type")]
        public string UserDefinedFluidType { get; set; } = "";
        

        [Description("required field if Storage Type is Water or UserDefinedFluidType")]
        [JsonProperty("fluid_storage_volume")]
        public string FluidStorageVolume { get; set; } = "";
        

        [Description("required field if Storage Type is Ice")]
        [JsonProperty("ice_storage_capacity")]
        public string IceStorageCapacity { get; set; } = "";
        

        [Description("If one of the previous two fields is set to autocalculate, this determines the st" +
                     "orage capacity as a function of Cooling Only Mode Rated Total Evaporator Cooling" +
                     " Capacity")]
        [JsonProperty("storage_capacity_sizing_factor")]
        public System.Nullable<float> StorageCapacitySizingFactor { get; set; } = null;
        

        [JsonProperty("storage_tank_ambient_temperature_node_name")]
        public string StorageTankAmbientTemperatureNodeName { get; set; } = "";
        

        [JsonProperty("storage_tank_to_ambient_u_value_times_area_heat_transfer_coefficient")]
        public System.Nullable<float> StorageTankToAmbientUValueTimesAreaHeatTransferCoefficient { get; set; } = null;
        

        [Description("required field if Storage Type is Water or UserDefinedFluidType")]
        [JsonProperty("fluid_storage_tank_rating_temperature")]
        public System.Nullable<float> FluidStorageTankRatingTemperature { get; set; } = null;
        

        [Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP")]
        [JsonProperty("rated_evaporator_air_flow_rate")]
        public string RatedEvaporatorAirFlowRate { get; set; } = "";
        

        [JsonProperty("evaporator_air_inlet_node_name")]
        public string EvaporatorAirInletNodeName { get; set; } = "";
        

        [JsonProperty("evaporator_air_outlet_node_name")]
        public string EvaporatorAirOutletNodeName { get; set; } = "";
        

        [JsonProperty("cooling_only_mode_available")]
        public EmptyNoYes CoolingOnlyModeAvailable { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description(@"required field if Cooling Only Mode is available or if autocalculating sizes gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty("cooling_only_mode_rated_total_evaporator_cooling_capacity")]
        public string CoolingOnlyModeRatedTotalEvaporatorCoolingCapacity { get; set; } = "";
        

        [Description("required field if Cooling Only Mode is available Rated sensible heat ratio (gross" +
                     " sensible capacity/gross total capacity) sensible and total capacities do not in" +
                     "clude supply fan heat")]
        [JsonProperty("cooling_only_mode_rated_sensible_heat_ratio")]
        public System.Nullable<float> CoolingOnlyModeRatedSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input required " +
                     "field if Cooling Only Mode is available")]
        [JsonProperty("cooling_only_mode_rated_cop")]
        public System.Nullable<float> CoolingOnlyModeRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Cooling Only Mode is available Any curve or table with two independent variables can be used biquadratic curve = a + b*ewb + c*ewb**2 + d*db + e*db**2 + f*ewb*db x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("cooling_only_mode_total_evaporator_cooling_capacity_function_of_temperature_curve" +
                      "_name")]
        public string CoolingOnlyModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling Only Mode is available Any curve or table with one inde" +
                     "pendent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve = " +
                     "a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air f" +
                     "low rate")]
        [JsonProperty("cooling_only_mode_total_evaporator_cooling_capacity_function_of_flow_fraction_cur" +
                      "ve_name")]
        public string CoolingOnlyModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*db + e*db**2 + f*ewb*db x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty("cooling_only_mode_energy_input_ratio_function_of_temperature_curve_name")]
        public string CoolingOnlyModeEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling Only Mode is available Any curve or table with one inde" +
                     "pendent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve = " +
                     "a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air f" +
                     "low")]
        [JsonProperty("cooling_only_mode_energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string CoolingOnlyModeEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling Only Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty("cooling_only_mode_part_load_fraction_correlation_curve_name")]
        public string CoolingOnlyModePartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*edb + e*edb**2 + f*ewb*edb x = ewb = evaporator entering wet-bulb temperature seen by the cooling coil (C) y = edb = evaporator entering dry-bulb temperature seen by the cooling coil (C)")]
        [JsonProperty("cooling_only_mode_sensible_heat_ratio_function_of_temperature_curve_name")]
        public string CoolingOnlyModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling Only Mode is available Any curve or table with one inde" +
                     "pendent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve = " +
                     "a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air f" +
                     "low")]
        [JsonProperty("cooling_only_mode_sensible_heat_ratio_function_of_flow_fraction_curve_name")]
        public string CoolingOnlyModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("cooling_and_charge_mode_available")]
        public EmptyNoYes CoolingAndChargeModeAvailable { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description(@"required field if Cooling And Charge Mode is available gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at Fluid Storage Tank Rating Temperature (water or fluid) or storage faction of 0.5 (ice)")]
        [JsonProperty("cooling_and_charge_mode_rated_total_evaporator_cooling_capacity")]
        public string CoolingAndChargeModeRatedTotalEvaporatorCoolingCapacity { get; set; } = "";
        

        [Description("If previous field is autocalculate, this determines the evaporator capacity as a " +
                     "multiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
        [JsonProperty("cooling_and_charge_mode_capacity_sizing_factor")]
        public System.Nullable<float> CoolingAndChargeModeCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Cooling And Charge Mode is available net capacity including any internal devices rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at Fluid Storage Tank Rating Temperature (water or fluid) or storage faction of 0.5 (ice)")]
        [JsonProperty("cooling_and_charge_mode_rated_storage_charging_capacity")]
        public string CoolingAndChargeModeRatedStorageChargingCapacity { get; set; } = "";
        

        [Description("If previous field is autocalculate, this determines the storage cooling capacity " +
                     "as a multiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity" +
                     "")]
        [JsonProperty("cooling_and_charge_mode_storage_capacity_sizing_factor")]
        public System.Nullable<float> CoolingAndChargeModeStorageCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("required field if Cooling And Charge Mode is available Rated sensible heat ratio " +
                     "(gross sensible evaporator capacity/gross total evaporator capacity) sensible an" +
                     "d total capacities do not include supply fan heat")]
        [JsonProperty("cooling_and_charge_mode_rated_sensible_heat_ratio")]
        public System.Nullable<float> CoolingAndChargeModeRatedSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Gross evaporator cooling capacity divided by power input to the compressor (for c" +
                     "ooling) and outdoor fan, does not include supply fan heat or supply fan electric" +
                     "al energy input required field if Cooling And Charge Mode is available")]
        [JsonProperty("cooling_and_charge_mode_cooling_rated_cop")]
        public System.Nullable<float> CoolingAndChargeModeCoolingRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("net cooling capacity divided by power input to the compressor (for charging) and " +
                     "outdoor fan, includes any internal devices required field if Cooling And Charge " +
                     "Mode is available")]
        [JsonProperty("cooling_and_charge_mode_charging_rated_cop")]
        public System.Nullable<float> CoolingAndChargeModeChargingRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("cooling_and_charge_mode_total_evaporator_cooling_capacity_function_of_temperature" +
                      "_curve_name")]
        public string CoolingAndChargeModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
                     "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
                     "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
                     " air flow")]
        [JsonProperty("cooling_and_charge_mode_total_evaporator_cooling_capacity_function_of_flow_fracti" +
                      "on_curve_name")]
        public string CoolingAndChargeModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("cooling_and_charge_mode_evaporator_energy_input_ratio_function_of_temperature_cur" +
                      "ve_name")]
        public string CoolingAndChargeModeEvaporatorEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
                     "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
                     "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
                     " air flow")]
        [JsonProperty("cooling_and_charge_mode_evaporator_energy_input_ratio_function_of_flow_fraction_c" +
                      "urve_name")]
        public string CoolingAndChargeModeEvaporatorEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty("cooling_and_charge_mode_evaporator_part_load_fraction_correlation_curve_name")]
        public string CoolingAndChargeModeEvaporatorPartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("cooling_and_charge_mode_storage_charge_capacity_function_of_temperature_curve_nam" +
                      "e")]
        public string CoolingAndChargeModeStorageChargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty("cooling_and_charge_mode_storage_charge_capacity_function_of_total_evaporator_plr_" +
                      "curve_name")]
        public string CoolingAndChargeModeStorageChargeCapacityFunctionOfTotalEvaporatorPlrCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("cooling_and_charge_mode_storage_energy_input_ratio_function_of_temperature_curve_" +
                      "name")]
        public string CoolingAndChargeModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
                     "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
                     "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
                     " air flow")]
        [JsonProperty("cooling_and_charge_mode_storage_energy_input_ratio_function_of_flow_fraction_curv" +
                      "e_name")]
        public string CoolingAndChargeModeStorageEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty("cooling_and_charge_mode_storage_energy_part_load_fraction_correlation_curve_name")]
        public string CoolingAndChargeModeStorageEnergyPartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Curves or tables with either two or three independent variables can be used. Curve:Biquadratic, Table:Lookup, Curve:Bicubic and Curve:QuadraticLinear allowed curve = a + b*ewb + c*ewb**2 + d*edb + e*edb**2 + f*ewb*edb x = ewb = entering wet-bulb temperature seen by the cooling coil (C) y = edb = entering dry-bulb temperature seen by the cooling coil (C) Also allows Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = edb, z = stes) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("cooling_and_charge_mode_sensible_heat_ratio_function_of_temperature_curve_name")]
        public string CoolingAndChargeModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
                     "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
                     "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
                     " air flow")]
        [JsonProperty("cooling_and_charge_mode_sensible_heat_ratio_function_of_flow_fraction_curve_name")]
        public string CoolingAndChargeModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("cooling_and_discharge_mode_available")]
        public EmptyNoYes CoolingAndDischargeModeAvailable { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description(@"required field if Cooling And Discharge Mode is available gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at Fluid Storage Tank Rating Temperature (water or fluid) or storage faction of 0.5 (ice)")]
        [JsonProperty("cooling_and_discharge_mode_rated_total_evaporator_cooling_capacity")]
        public string CoolingAndDischargeModeRatedTotalEvaporatorCoolingCapacity { get; set; } = "";
        

        [Description("If previous field is autocalculate, this determines the charging capacity as a mu" +
                     "ltiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
        [JsonProperty("cooling_and_discharge_mode_evaporator_capacity_sizing_factor")]
        public System.Nullable<float> CoolingAndDischargeModeEvaporatorCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Cooling And Discharge Mode is available net capacity including any internal devices rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at 26.7 C (water) or storage faction of 0.5 (ice)")]
        [JsonProperty("cooling_and_discharge_mode_rated_storage_discharging_capacity")]
        public string CoolingAndDischargeModeRatedStorageDischargingCapacity { get; set; } = "";
        

        [Description("If previous field is autocalculate, this determines the charging capacity as a mu" +
                     "ltiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
        [JsonProperty("cooling_and_discharge_mode_storage_discharge_capacity_sizing_factor")]
        public System.Nullable<float> CoolingAndDischargeModeStorageDischargeCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("required field if Cooling And Discharge Mode is available Rated sensible heat rat" +
                     "io (gross sensible evaporator capacity/gross total evaporator capacity) sensible" +
                     " and total capacities do not include supply fan heat")]
        [JsonProperty("cooling_and_discharge_mode_rated_sensible_heat_ratio")]
        public System.Nullable<float> CoolingAndDischargeModeRatedSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Gross evaporator cooling capacity divided by power input to the compressor (for c" +
                     "ooling) and outdoor fan, does not include supply fan heat or supply fan electric" +
                     "al energy input required field if Cooling And Discharge Mode is available")]
        [JsonProperty("cooling_and_discharge_mode_cooling_rated_cop")]
        public System.Nullable<float> CoolingAndDischargeModeCoolingRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("gross cooling capacity divided by power input to the compressor (for discharging)" +
                     ", includes any internal devices for discharging storage but not supply fan requi" +
                     "red field if Cooling And Discharge Mode is available")]
        [JsonProperty("cooling_and_discharge_mode_discharging_rated_cop")]
        public System.Nullable<float> CoolingAndDischargeModeDischargingRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Cooling Only Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("cooling_and_discharge_mode_total_evaporator_cooling_capacity_function_of_temperat" +
                      "ure_curve_name")]
        public string CoolingAndDischargeModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
                     " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
                     " curve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evapora" +
                     "tor air flow")]
        [JsonProperty("cooling_and_discharge_mode_total_evaporator_cooling_capacity_function_of_flow_fra" +
                      "ction_curve_name")]
        public string CoolingAndDischargeModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("cooling_and_discharge_mode_evaporator_energy_input_ratio_function_of_temperature_" +
                      "curve_name")]
        public string CoolingAndDischargeModeEvaporatorEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
                     " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
                     " curve = a + b*ff + c*ff**2 + d*ff**3 ff = Fraction of the full load evaporator " +
                     "air flow")]
        [JsonProperty("cooling_and_discharge_mode_evaporator_energy_input_ratio_function_of_flow_fractio" +
                      "n_curve_name")]
        public string CoolingAndDischargeModeEvaporatorEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty("cooling_and_discharge_mode_evaporator_part_load_fraction_correlation_curve_name")]
        public string CoolingAndDischargeModeEvaporatorPartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("cooling_and_discharge_mode_storage_discharge_capacity_function_of_temperature_cur" +
                      "ve_name")]
        public string CoolingAndDischargeModeStorageDischargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
                     " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
                     " curve = a + b*ff + c*ff**2 + d*ff**3 ff = Fraction of the full load evaporator " +
                     "air flow")]
        [JsonProperty("cooling_and_discharge_mode_storage_discharge_capacity_function_of_flow_fraction_c" +
                      "urve_name")]
        public string CoolingAndDischargeModeStorageDischargeCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x =PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty("cooling_and_discharge_mode_storage_discharge_capacity_function_of_total_evaporato" +
                      "r_plr_curve_name")]
        public string CoolingAndDischargeModeStorageDischargeCapacityFunctionOfTotalEvaporatorPlrCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("cooling_and_discharge_mode_storage_energy_input_ratio_function_of_temperature_cur" +
                      "ve_name")]
        public string CoolingAndDischargeModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
                     " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
                     " curve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evapora" +
                     "tor air flow")]
        [JsonProperty("cooling_and_discharge_mode_storage_energy_input_ratio_function_of_flow_fraction_c" +
                      "urve_name")]
        public string CoolingAndDischargeModeStorageEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty("cooling_and_discharge_mode_storage_energy_part_load_fraction_correlation_curve_na" +
                      "me")]
        public string CoolingAndDischargeModeStorageEnergyPartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Curves or tables with either two or three independent variables can be used. curve = a + b*ewb + c*ewb**2 + d*edb + e*edb**2 + f*ewb*edb x = ewb = entering wet-bulb temperature seen by the cooling coil (C) y = edb = entering dry-bulb temperature seen by the cooling coil (C) Also allows Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = edb, z = stes) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("cooling_and_discharge_mode_sensible_heat_ratio_function_of_temperature_curve_name" +
                      "")]
        public string CoolingAndDischargeModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
                     " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
                     " curve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evapora" +
                     "tor air flow")]
        [JsonProperty("cooling_and_discharge_mode_sensible_heat_ratio_function_of_flow_fraction_curve_na" +
                      "me")]
        public string CoolingAndDischargeModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty("charge_only_mode_available")]
        public EmptyNoYes ChargeOnlyModeAvailable { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("required field if Charge Only  Mode is available net capacity including any inter" +
                     "nal devices air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-" +
                     "bulb thermal storage tank at 26.7 C (water) or storage faction of 0.5 (ice)")]
        [JsonProperty("charge_only_mode_rated_storage_charging_capacity")]
        public string ChargeOnlyModeRatedStorageChargingCapacity { get; set; } = "";
        

        [Description("If previous field is autocalculate, this determines the charging capacity as a mu" +
                     "ltiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
        [JsonProperty("charge_only_mode_capacity_sizing_factor")]
        public System.Nullable<float> ChargeOnlyModeCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("net cooling capacity divided by power input to the compressor (for charging) and " +
                     "outdoor fan, includes any internal devices required field if Charge Only Mode is" +
                     " available")]
        [JsonProperty("charge_only_mode_charging_rated_cop")]
        public System.Nullable<float> ChargeOnlyModeChargingRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Charge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*db + c*db**2 + d*stes + e*stes**2 + f*db*stes x = db = dry-bulb temperature seen by the condenser (C) y = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("charge_only_mode_storage_charge_capacity_function_of_temperature_curve_name")]
        public string ChargeOnlyModeStorageChargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"required field if Charge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*db + c*db**2 + d*stes + e*stes**2 + f*db*stes x = db = dry-bulb temperature seen by the condenser (C) y = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("charge_only_mode_storage_energy_input_ratio_function_of_temperature_curve_name")]
        public string ChargeOnlyModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [JsonProperty("discharge_only_mode_available")]
        public EmptyNoYes DischargeOnlyModeAvailable { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("required field if Discharge Only Mode is available net capacity including any int" +
                     "ernal devices rating point: air entering the cooling coil at 26.7 C dry-bulb/19." +
                     "4 C wet-bulb, and thermal storage tank at 26.7 C (water) or storage faction of 0" +
                     ".5 (ice)")]
        [JsonProperty("discharge_only_mode_rated_storage_discharging_capacity")]
        public string DischargeOnlyModeRatedStorageDischargingCapacity { get; set; } = "";
        

        [Description("If previous field is autocalculate, this determines the discharging capacity as a" +
                     " multiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
        [JsonProperty("discharge_only_mode_capacity_sizing_factor")]
        public System.Nullable<float> DischargeOnlyModeCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("required field if Discharge Only Mode is available Rated sensible heat ratio (gro" +
                     "ss sensible evaporator capacity/gross total evaporator capacity) sensible and to" +
                     "tal capacities do not include supply fan heat")]
        [JsonProperty("discharge_only_mode_rated_sensible_heat_ratio")]
        public System.Nullable<float> DischargeOnlyModeRatedSensibleHeatRatio { get; set; } = null;
        

        [Description("required field if Discharge Only Mode is available gross cooling capacity divided" +
                     " by power input to the compressor (for discharging), includes any internal devic" +
                     "es for discharging storage but not supply fan")]
        [JsonProperty("discharge_only_mode_rated_cop")]
        public System.Nullable<float> DischargeOnlyModeRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Discharge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*stes + e*stes**2 + f*ewb*stes x = ewb = evaporator entering wet-bulb temperature (C) y = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("discharge_only_mode_storage_discharge_capacity_function_of_temperature_curve_name" +
                      "")]
        public string DischargeOnlyModeStorageDischargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Discharge Only Mode is available Any curve or table with one in" +
                     "dependent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve " +
                     "= a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air" +
                     " flow")]
        [JsonProperty("discharge_only_mode_storage_discharge_capacity_function_of_flow_fraction_curve_na" +
                      "me")]
        public string DischargeOnlyModeStorageDischargeCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Discharge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*stes + e*stes**2 + f*ewb*stes x = ewb = evaporator entering wet-bulb temperature (C) y = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("discharge_only_mode_energy_input_ratio_function_of_temperature_curve_name")]
        public string DischargeOnlyModeEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Discharge Only Mode is available Any curve or table with one in" +
                     "dependent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve " +
                     "= a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air" +
                     " flow")]
        [JsonProperty("discharge_only_mode_energy_input_ratio_function_of_flow_fraction_curve_name")]
        public string DischargeOnlyModeEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("required field if Discharge Only Mode is available Any curve or table with one in" +
                     "dependent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curv" +
                     "e = a + b*PLR + c*PLR**2 + d*PLR**3")]
        [JsonProperty("discharge_only_mode_part_load_fraction_correlation_curve_name")]
        public string DischargeOnlyModePartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Discharge Only Mode is available Curves or tables with either two or three independent variables can be used. For two independent variables: x = ewb = entering wet-bulb temperature seen by the cooling coil (C) y = edb = entering dry-bulb temperature seen by the cooling coil (C) For three independent variables: curve or table = func(x = ewb, y = edb, z = stes) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty("discharge_only_mode_sensible_heat_ratio_function_of_temperature_curve_name")]
        public string DischargeOnlyModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Discharge Only Mode is available Any curve or table with one in" +
                     "dependent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve " +
                     "= a + b*ff + c*ff**2 + d*ff**3 ff = Fraction of the full load evaporator air flo" +
                     "w")]
        [JsonProperty("discharge_only_mode_sensible_heat_ratio_function_of_flow_fraction_curve_name")]
        public string DischargeOnlyModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("controls and miscellaneous standby ancillary electric power draw, when available")]
        [JsonProperty("ancillary_electric_power")]
        public System.Nullable<float> AncillaryElectricPower { get; set; } = null;
        

        [JsonProperty("cold_weather_operation_minimum_outdoor_air_temperature")]
        public System.Nullable<float> ColdWeatherOperationMinimumOutdoorAirTemperature { get; set; } = null;
        

        [JsonProperty("cold_weather_operation_ancillary_power")]
        public System.Nullable<float> ColdWeatherOperationAncillaryPower { get; set; } = null;
        

        [Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
                     "doorAir:Node or OutdoorAir:NodeList object.")]
        [JsonProperty("condenser_air_inlet_node_name")]
        public string CondenserAirInletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_air_outlet_node_name")]
        public string CondenserAirOutletNodeName { get; set; } = "";
        

        [Description("Used to calculate condenser leaving conditions and water use if evaporatively coo" +
                     "led.")]
        [JsonProperty("condenser_design_air_flow_rate")]
        public string CondenserDesignAirFlowRate { get; set; } = "";
        

        [Description("If previous field is autocalculate, this determines the condenser air flow size a" +
                     "s a multiplier on the Rated Evaporator Air Flow Rate.")]
        [JsonProperty("condenser_air_flow_sizing_factor")]
        public System.Nullable<float> CondenserAirFlowSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("condenser_type")]
        public EmptyNoYes CondenserType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "AirCooled");
        

        [Description("required field if condenser type is evaporatively cooled")]
        [JsonProperty("evaporative_condenser_effectiveness")]
        public System.Nullable<float> EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump")]
        [JsonProperty("evaporative_condenser_pump_rated_power_consumption")]
        public string EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = (System.String)"0";
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the DX coil is off. If this field is blank, the basin heater is always available.")]
        [JsonProperty("basin_heater_capacity")]
        public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty("basin_heater_setpoint_temperature")]
        public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty("basin_heater_availability_schedule_name")]
        public string BasinHeaterAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("supply_water_storage_tank_name")]
        public string SupplyWaterStorageTankName { get; set; } = "";
        

        [JsonProperty("condensate_collection_water_storage_tank_name")]
        public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

        [JsonProperty("storage_tank_plant_connection_inlet_node_name")]
        public string StorageTankPlantConnectionInletNodeName { get; set; } = "";
        

        [JsonProperty("storage_tank_plant_connection_outlet_node_name")]
        public string StorageTankPlantConnectionOutletNodeName { get; set; } = "";
        

        [JsonProperty("storage_tank_plant_connection_design_flow_rate")]
        public System.Nullable<float> StorageTankPlantConnectionDesignFlowRate { get; set; } = null;
        

        [JsonProperty("storage_tank_plant_connection_heat_transfer_effectiveness")]
        public System.Nullable<float> StorageTankPlantConnectionHeatTransferEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("For fluid storage tanks only, minimum limit for storage tank If omitted,then the " +
                     "minimum temperature limit is that used for fluid property data.")]
        [JsonProperty("storage_tank_minimum_operating_limit_fluid_temperature")]
        public System.Nullable<float> StorageTankMinimumOperatingLimitFluidTemperature { get; set; } = null;
        

        [Description("For fluid storage tanks only, maximum limit for storage tank If omitted,then the " +
                     "maximum temperature limit is that used for fluid property data.")]
        [JsonProperty("storage_tank_maximum_operating_limit_fluid_temperature")]
        public System.Nullable<float> StorageTankMaximumOperatingLimitFluidTemperature { get; set; } = null;
    }
}