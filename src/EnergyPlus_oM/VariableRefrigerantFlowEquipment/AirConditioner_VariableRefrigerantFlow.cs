namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
    using BH.oM.Adapters.EnergyPlus.AirDistribution;
    using BH.oM.Adapters.EnergyPlus.AirflowNetwork;
    using BH.oM.Adapters.EnergyPlus.Coils;
    using BH.oM.Adapters.EnergyPlus.ComplianceObjects;
    using BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers;
    using BH.oM.Adapters.EnergyPlus.Controllers;
    using BH.oM.Adapters.EnergyPlus.Daylighting;
    using BH.oM.Adapters.EnergyPlus.DemandLimitingControls;
    using BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer;
    using BH.oM.Adapters.EnergyPlus.Economics;
    using BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications;
    using BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS;
    using BH.oM.Adapters.EnergyPlus.EvaporativeCoolers;
    using BH.oM.Adapters.EnergyPlus.ExteriorEquipment;
    using BH.oM.Adapters.EnergyPlus.ExternalInterface;
    using BH.oM.Adapters.EnergyPlus.Fans;
    using BH.oM.Adapters.EnergyPlus.FluidProperties;
    using BH.oM.Adapters.EnergyPlus.GeneralDataEntry;
    using BH.oM.Adapters.EnergyPlus.HeatRecovery;
    using BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers;
    using BH.oM.Adapters.EnergyPlus.HVACDesignObjects;
    using BH.oM.Adapters.EnergyPlus.HVACTemplates;
    using BH.oM.Adapters.EnergyPlus.HybridModel;
    using BH.oM.Adapters.EnergyPlus.InternalGains;
    using BH.oM.Adapters.EnergyPlus.LocationandClimate;
    using BH.oM.Adapters.EnergyPlus.NodeBranchManagement;
    using BH.oM.Adapters.EnergyPlus.NonZoneEquipment;
    using BH.oM.Adapters.EnergyPlus.OperationalFaults;
    using BH.oM.Adapters.EnergyPlus.OutputReporting;
    using BH.oM.Adapters.EnergyPlus.Parametrics;
    using BH.oM.Adapters.EnergyPlus.PerformanceCurves;
    using BH.oM.Adapters.EnergyPlus.PerformanceTables;
    using BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserFlowControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserLoops;
    using BH.oM.Adapters.EnergyPlus.Pumps;
    using BH.oM.Adapters.EnergyPlus.PythonPluginSystem;
    using BH.oM.Adapters.EnergyPlus.Refrigeration;
    using BH.oM.Adapters.EnergyPlus.RoomAirModels;
    using BH.oM.Adapters.EnergyPlus.Schedules;
    using BH.oM.Adapters.EnergyPlus.SetpointManagers;
    using BH.oM.Adapters.EnergyPlus.SimulationParameters;
    using BH.oM.Adapters.EnergyPlus.SolarCollectors;
    using BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements;
    using BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers;
    using BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces;
    using BH.oM.Adapters.EnergyPlus.UnitaryEquipment;
    using BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels;
    using BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage;
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Variable refrigerant flow (VRF) air-to-air heat pump condensing unit (includes on" +
        "e or more electric compressors and outdoor fan). Serves one or more VRF zone ter" +
        "minal units. See ZoneHVAC:TerminalUnit:VariableRefrigerantFlow and ZoneTerminalU" +
        "nitList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirConditioner_VariableRefrigerantFlow : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance.")]
public string NodeName { get; set; } = "";
        

[Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. Enter the name of a schedule that defines the availability of the unit. Schedule values of 0 denote the unit is off. All other values denote the unit is available. If this field is left blank, the unit is available the entire simulation.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Enter the total cooling capacity in watts at rated conditions or set to autosize." +
    " Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("gross_rated_total_cooling_capacity")]
public string GrossRatedTotalCoolingCapacity { get; set; } = "";
        

[Description("Enter the coefficient of performance at rated conditions or leave blank to use de" +
    "fault. COP includes compressor and condenser fan electrical energy input COP doe" +
    "s not include supply fan heat or supply fan electric power input")]
[JsonProperty("gross_rated_cooling_cop")]
public System.Nullable<float> GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3.3", CultureInfo.InvariantCulture);
        

[Description("Enter the minimum outdoor temperature allowed for cooling operation. Cooling is d" +
    "isabled below this temperature.")]
[JsonProperty("minimum_outdoor_temperature_in_cooling_mode")]
public System.Nullable<float> MinimumOutdoorTemperatureInCoolingMode { get; set; } = (System.Nullable<float>)Single.Parse("-6", CultureInfo.InvariantCulture);
        

[Description("Enter the maximum outdoor temperature allowed for cooling operation. Cooling is d" +
    "isabled above this temperature.")]
[JsonProperty("maximum_outdoor_temperature_in_cooling_mode")]
public System.Nullable<float> MaximumOutdoorTemperatureInCoolingMode { get; set; } = (System.Nullable<float>)Single.Parse("43", CultureInfo.InvariantCulture);
        

[Description(@"Enter a curve name that represents full load cooling capacity ratio as a function of outdoor dry-bulb temperature and indoor wet-bulb temperature. Up to two curves are allowed if the performance cannot be represented by a single curve. The following two fields are used if two curves are required.")]
[JsonProperty("cooling_capacity_ratio_modifier_function_of_low_temperature_curve_name")]
public string CoolingCapacityRatioModifierFunctionOfLowTemperatureCurveName { get; set; } = "";
        

[Description(@"This curve object is used to allow separate low and high cooling capacity ratio performance curves. This curve represents a line passing through the points where performance changes. The curve calculates outdoor dry-bulb temperature given weighted average indoor wet-bulb temperature. If a single performance curve is used, leave this field blank.")]
[JsonProperty("cooling_capacity_ratio_boundary_curve_name")]
public string CoolingCapacityRatioBoundaryCurveName { get; set; } = "";
        

[Description(@"This curve object is used to describe the high outdoor temperature performance curve used to describe cooling capacity ratio. This curve is used when a single performance curve does not accurately describe cooling capacity ratio as a function of temperature. If a single performance curve is used, leave this field blank.")]
[JsonProperty("cooling_capacity_ratio_modifier_function_of_high_temperature_curve_name")]
public string CoolingCapacityRatioModifierFunctionOfHighTemperatureCurveName { get; set; } = "";
        

[Description("Enter a curve name that represents cooling energy ratio as a function of outdoor " +
    "dry-bulb temperature and indoor wet-bulb temperature")]
[JsonProperty("cooling_energy_input_ratio_modifier_function_of_low_temperature_curve_name")]
public string CoolingEnergyInputRatioModifierFunctionOfLowTemperatureCurveName { get; set; } = "";
        

[Description(@"This curve object is used to allow separate low and high cooling energy input ratio performance curves. This curve represents a line passing through the points where performance changes. The curve calculates outdoor dry-bulb temperature given weighted average indoor wet-bulb temperature. If a single performance curve is used, leave this field blank.")]
[JsonProperty("cooling_energy_input_ratio_boundary_curve_name")]
public string CoolingEnergyInputRatioBoundaryCurveName { get; set; } = "";
        

[Description("This curve object is used to describe the high outdoor temperature performance cu" +
    "rve used to describe cooling energy ratio. This curve is used when a single perf" +
    "ormance curve does not accurately describe cooling energy ratio as a function of" +
    " temperature")]
[JsonProperty("cooling_energy_input_ratio_modifier_function_of_high_temperature_curve_name")]
public string CoolingEnergyInputRatioModifierFunctionOfHighTemperatureCurveName { get; set; } = "";
        

[Description("Enter a curve name that represents cooling energy ratio as a function of part-loa" +
    "d ratio for part-load ratios less than or equal to 1. If this field is left blan" +
    "k, the model assumes energy is proportional to part-load ratio.")]
[JsonProperty("cooling_energy_input_ratio_modifier_function_of_low_part_load_ratio_curve_name")]
public string CoolingEnergyInputRatioModifierFunctionOfLowPartLoadRatioCurveName { get; set; } = "";
        

[Description(@"Enter a curve name that represents cooling energy ratio as a function of part-load ratio for part-load ratios greater than 1. Part-load ratios can exceed 1 in variable speed compression systems. If this field is left blank, the model assumes energy is proportional to part-load ratio.")]
[JsonProperty("cooling_energy_input_ratio_modifier_function_of_high_part_load_ratio_curve_name")]
public string CoolingEnergyInputRatioModifierFunctionOfHighPartLoadRatioCurveName { get; set; } = "";
        

[Description(@"This curve defines how rated capacity changes when the total indoor terminal unit cooling capacity is greater than the Gross Rated Total Cooling Capacity defined in this object. If this field is left blank, the model assumes total indoor terminal unit cooling capacity is equal to the Gross Rated Total Cooling Capacity defined above.")]
[JsonProperty("cooling_combination_ratio_correction_factor_curve_name")]
public string CoolingCombinationRatioCorrectionFactorCurveName { get; set; } = "";
        

[Description("This curve defines the cycling losses when the heat pump compressor cycles on and" +
    " off below the Minimum Heat Pump Part-Load Ratio specified in the field below.")]
[JsonProperty("cooling_part_load_fraction_correlation_curve_name")]
public string CoolingPartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description("Enter the heating capacity in watts at rated conditions or set to autosize. Heati" +
    "ng capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("gross_rated_heating_capacity")]
public string GrossRatedHeatingCapacity { get; set; } = "";
        

[Description(@"If the Gross Rated Heating Capacity is autosized, the heating capacity is sized to be equal to the cooling capacity multiplied by this sizing ratio. The zone terminal unit heating coils are also sized using this ratio unless the sizing ratio input in the ZoneHVAC:TerminalUnit:VariableRefrigerantFlow object is entered.")]
[JsonProperty("rated_heating_capacity_sizing_ratio")]
public System.Nullable<float> RatedHeatingCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("COP includes compressor and condenser fan electrical energy input COP does not in" +
    "clude supply fan heat or supply fan electrical energy input")]
[JsonProperty("gross_rated_heating_cop")]
public System.Nullable<float> GrossRatedHeatingCop { get; set; } = (System.Nullable<float>)Single.Parse("3.4", CultureInfo.InvariantCulture);
        

[Description("Enter the minimum outdoor temperature allowed for heating operation.")]
[JsonProperty("minimum_outdoor_temperature_in_heating_mode")]
public System.Nullable<float> MinimumOutdoorTemperatureInHeatingMode { get; set; } = (System.Nullable<float>)Single.Parse("-20", CultureInfo.InvariantCulture);
        

[Description("Enter the maximum outdoor temperature allowed for heating operation.")]
[JsonProperty("maximum_outdoor_temperature_in_heating_mode")]
public System.Nullable<float> MaximumOutdoorTemperatureInHeatingMode { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[Description(@"Enter a curve name that represents full load heating capacity ratio as a function of outdoor wet-bulb temperature and indoor dry-bulb temperature. Outdoor dry-bulb temperature may be used if wet-bulb temperature data is unavailable. See Heating Performance Curve Outdoor Temperature Type input below to determine which outdoor temperature type to use. Up to two curves are allowed if the performance cannot be represented by a single curve. The following two fields are used if two curves are required.")]
[JsonProperty("heating_capacity_ratio_modifier_function_of_low_temperature_curve_name")]
public string HeatingCapacityRatioModifierFunctionOfLowTemperatureCurveName { get; set; } = "";
        

[Description(@"This curve object is used to allow separate low and high heating capacity ratio performance curves. This curve represents a line passing through the points where performance changes. The curve calculates outdoor dry-bulb or wet-bulb temperature given weighted average indoor dry-bulb temperature. See Heating Performance Curve Outdoor Temperature Type input below to determine which outdoor temperature type to use. If a single performance curve is used, leave this field blank.")]
[JsonProperty("heating_capacity_ratio_boundary_curve_name")]
public string HeatingCapacityRatioBoundaryCurveName { get; set; } = "";
        

[Description(@"This curve object is used to describe the high outdoor temperature performance curve used to describe heating capacity ratio. This curve is used when a single performance curve does not accurately describe heating capacity ratio as a function of temperature. If a single performance curve is used, leave this field blank.")]
[JsonProperty("heating_capacity_ratio_modifier_function_of_high_temperature_curve_name")]
public string HeatingCapacityRatioModifierFunctionOfHighTemperatureCurveName { get; set; } = "";
        

[Description(@"Enter a curve name that represents heating energy ratio as a function of outdoor wet-bulb temperature and indoor dry-bulb temperature Outdoor dry-bulb temperature may be used if wet-bulb temperature data is unavailable. See Heating Performance Curve Outdoor Temperature Type input below to determine which outdoor temperature type to use.")]
[JsonProperty("heating_energy_input_ratio_modifier_function_of_low_temperature_curve_name")]
public string HeatingEnergyInputRatioModifierFunctionOfLowTemperatureCurveName { get; set; } = "";
        

[Description(@"This curve object is used to allow separate low and high heating energy input ratio performance curves. This curve represents a line passing through the points where performance changes. The curve calculates outdoor dry-bulb or wet-bulb temperature given weighted average indoor dry-bulb temperature. See Heating Performance Curve Outdoor Temperature Type input below to determine which outdoor temperature type to use. If a single performance curve is used, leave this field blank.")]
[JsonProperty("heating_energy_input_ratio_boundary_curve_name")]
public string HeatingEnergyInputRatioBoundaryCurveName { get; set; } = "";
        

[Description("This curve object is used to allow separate performance curves for heating energy" +
    ". If a single performance curve is used, leave this field blank.")]
[JsonProperty("heating_energy_input_ratio_modifier_function_of_high_temperature_curve_name")]
public string HeatingEnergyInputRatioModifierFunctionOfHighTemperatureCurveName { get; set; } = "";
        

[Description("Determines temperature type for heating capacity curves and heating energy curves" +
    ". This input determines whether the outdoor air dry-bulb or wet-bulb temperature" +
    " is used to evaluate these curves.")]
[JsonProperty("heating_performance_curve_outdoor_temperature_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirConditioner_VariableRefrigerantFlow_HeatingPerformanceCurveOutdoorTemperatureType HeatingPerformanceCurveOutdoorTemperatureType { get; set; } = (AirConditioner_VariableRefrigerantFlow_HeatingPerformanceCurveOutdoorTemperatureType)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_HeatingPerformanceCurveOutdoorTemperatureType), "WetBulbTemperature");
        

[Description("This curve represents the heating energy input ratio for part-load ratios less th" +
    "an 1.")]
[JsonProperty("heating_energy_input_ratio_modifier_function_of_low_part_load_ratio_curve_name")]
public string HeatingEnergyInputRatioModifierFunctionOfLowPartLoadRatioCurveName { get; set; } = "";
        

[Description("This curve represents the heating energy input ratio for part-load ratios greater" +
    " than 1.")]
[JsonProperty("heating_energy_input_ratio_modifier_function_of_high_part_load_ratio_curve_name")]
public string HeatingEnergyInputRatioModifierFunctionOfHighPartLoadRatioCurveName { get; set; } = "";
        

[Description(@"This curve defines how rated capacity changes when the total indoor terminal unit heating capacity is greater than the Gross Rated Heating Capacity defined in this object. If this field is left blank, the model assumes total indoor terminal unit heating capacity is equal to the Gross Rated Heating Capacity defined above.")]
[JsonProperty("heating_combination_ratio_correction_factor_curve_name")]
public string HeatingCombinationRatioCorrectionFactorCurveName { get; set; } = "";
        

[Description("This curve defines the cycling losses when the heat pump compressor cycles on and" +
    " off below the Minimum Heat Pump Part-Load Ratio specified in the following fiel" +
    "d.")]
[JsonProperty("heating_part_load_fraction_correlation_curve_name")]
public string HeatingPartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description("Enter the minimum heat pump part-load ratio (PLR). When the cooling or heating PL" +
    "R is below this value, the heat pump compressor will cycle to meet the cooling o" +
    "r heating demand.")]
[JsonProperty("minimum_heat_pump_part_load_ratio")]
public System.Nullable<float> MinimumHeatPumpPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.15", CultureInfo.InvariantCulture);
        

[Description("Enter the name of the zone where the master thermostat is located.")]
[JsonProperty("zone_name_for_master_thermostat_location")]
public string ZoneNameForMasterThermostatLocation { get; set; } = "";
        

[Description("Choose a thermostat control logic scheme. If these control types fail to control " +
    "zone temperature within a reasonable limit, consider using multiple VRF systems." +
    " This field is not used when all terminal units are set point controlled.")]
[JsonProperty("master_thermostat_priority_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirConditioner_VariableRefrigerantFlow_MasterThermostatPriorityControlType MasterThermostatPriorityControlType { get; set; } = (AirConditioner_VariableRefrigerantFlow_MasterThermostatPriorityControlType)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_MasterThermostatPriorityControlType), "MasterThermostatPriority");
        

[Description("this field is required if Master Thermostat Priority Control Type is Scheduled. S" +
    "chedule values of 0 denote cooling, 1 for heating, and all other values disable " +
    "the system.")]
[JsonProperty("thermostat_priority_schedule_name")]
public string ThermostatPriorityScheduleName { get; set; } = "";
        

[Description("Enter the name of a ZoneTerminalUnitList. This list connects zone terminal units " +
    "to this heat pump.")]
[JsonProperty("zone_terminal_unit_list_name")]
public string ZoneTerminalUnitListName { get; set; } = "";
        

[Description("This field enables heat recovery operation within this VRF outdoor unit.")]
[JsonProperty("heat_pump_waste_heat_recovery")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes HeatPumpWasteHeatRecovery { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Enter the equivalent length of the farthest terminal unit from the condenser")]
[JsonProperty("equivalent_piping_length_used_for_piping_correction_factor_in_cooling_mode")]
public System.Nullable<float> EquivalentPipingLengthUsedForPipingCorrectionFactorInCoolingMode { get; set; } = null;
        

[Description("Enter the height difference between the highest and lowest terminal unit")]
[JsonProperty("vertical_height_used_for_piping_correction_factor")]
public System.Nullable<float> VerticalHeightUsedForPipingCorrectionFactor { get; set; } = null;
        

[Description("PCF = a0 + a1*L + a2*L^2 + a3*L^3 + a4*H PCF = a0 + a1*L + a2*L^2 + a3*CR + a4*CR" +
    "^2 + a5*(L)(CR) where L = length and CR = combination ratio specifies coefficien" +
    "ts for a0, a1, a2, and a3 in the PCF equation")]
[JsonProperty("piping_correction_factor_for_length_in_cooling_mode_curve_name")]
public string PipingCorrectionFactorForLengthInCoolingModeCurveName { get; set; } = "";
        

[Description("PCF = a0 + a1*L + a2*L^2 + a3*L^3 + a4*H PCF = a0 + a1*L + a2*L^2 + a3*CR + a4*CR" +
    "^2 + a5*(L)(CR) + a6*H where L = length, H = height, and CR = combination ratio " +
    "specifies coefficient a4 (or a6 for biquadratic) in the PCF equation")]
[JsonProperty("piping_correction_factor_for_height_in_cooling_mode_coefficient")]
public System.Nullable<float> PipingCorrectionFactorForHeightInCoolingModeCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the equivalent length of the farthest terminal unit from the condenser")]
[JsonProperty("equivalent_piping_length_used_for_piping_correction_factor_in_heating_mode")]
public System.Nullable<float> EquivalentPipingLengthUsedForPipingCorrectionFactorInHeatingMode { get; set; } = null;
        

[Description("PCF = a0 + a1*L + a2*L^2 + a3*L^3 + a4*H PCF = a0 + a1*L + a2*L^2 + a3*CR + a4*CR" +
    "^2 + a5*(L)(CR) + a6*H where L = length and CR = combination ratio specifies coe" +
    "fficients for a0, a1, a2, and a3 (or a0-a5 for biquadratic) in the PCF equation")]
[JsonProperty("piping_correction_factor_for_length_in_heating_mode_curve_name")]
public string PipingCorrectionFactorForLengthInHeatingModeCurveName { get; set; } = "";
        

[Description("PCF = a0 + a1*L + a2*L^2 + a3*L^3 + a4*H PCF = a0 + a1*L + a2*L^2 + a3*CR + a4*CR" +
    "^2 + a5*(L)(CR) + a6*H where L = length, H = height, and CR = combination ratio " +
    "specifies coefficient a4 (or a6 for biquadratic) in the PCF equation")]
[JsonProperty("piping_correction_factor_for_height_in_heating_mode_coefficient")]
public System.Nullable<float> PipingCorrectionFactorForHeightInHeatingModeCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the value of the resistive heater located in the compressor(s). This heater" +
    " is used to warm the refrigerant and oil when the compressor is off.")]
[JsonProperty("crankcase_heater_power_per_compressor")]
public System.Nullable<float> CrankcaseHeaterPowerPerCompressor { get; set; } = (System.Nullable<float>)Single.Parse("33", CultureInfo.InvariantCulture);
        

[Description("Enter the total number of compressor. This input is used only for crankcase heate" +
    "r calculations.")]
[JsonProperty("number_of_compressors")]
public System.Nullable<float> NumberOfCompressors { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("Enter the ratio of the first stage compressor to total compressor capacity. All o" +
    "ther compressors are assumed to be equally sized. This inputs is used only for c" +
    "rankcase heater calculations.")]
[JsonProperty("ratio_of_compressor_size_to_total_compressor_capacity")]
public System.Nullable<float> RatioOfCompressorSizeToTotalCompressorCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("Enter the maximum outdoor temperature above which the crankcase heaters are disab" +
    "led.")]
[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeater { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[Description("Select a defrost strategy. Reverse cycle reverses the operating mode from heating" +
    " to cooling to melt frost formation on the condenser coil. The resistive strateg" +
    "y uses a resistive heater to melt the frost.")]
[JsonProperty("defrost_strategy")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirConditioner_VariableRefrigerantFlow_DefrostStrategy DefrostStrategy { get; set; } = (AirConditioner_VariableRefrigerantFlow_DefrostStrategy)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_DefrostStrategy), "Resistive");
        

[Description("Choose a defrost control type. Either use a fixed Timed defrost period or select " +
    "OnDemand to defrost only when necessary.")]
[JsonProperty("defrost_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirConditioner_VariableRefrigerantFlow_DefrostControl DefrostControl { get; set; } = (AirConditioner_VariableRefrigerantFlow_DefrostControl)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_DefrostControl), "Timed");
        

[Description("A valid performance curve must be used if reversecycle defrost strategy is select" +
    "ed.")]
[JsonProperty("defrost_energy_input_ratio_modifier_function_of_temperature_curve_name")]
public string DefrostEnergyInputRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Fraction of time in defrost mode. Only applicable if timed defrost control is spe" +
    "cified.")]
[JsonProperty("defrost_time_period_fraction")]
public System.Nullable<float> DefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

[Description("Enter the size of the resistive defrost heating element. Only applicable if resis" +
    "tive defrost strategy is specified")]
[JsonProperty("resistive_defrost_heater_capacity")]
public string ResistiveDefrostHeaterCapacity { get; set; } = (System.String)"0";
        

[Description("Enter the maximum outdoor temperature above which defrost operation is disabled.")]
[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_defrost_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForDefrostOperation { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[Description("Select either an air-cooled, evaporatively-cooled or water-cooled condenser.")]
[JsonProperty("condenser_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirConditioner_VariableRefrigerantFlow_CondenserType CondenserType { get; set; } = (AirConditioner_VariableRefrigerantFlow_CondenserType)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_CondenserType), "AirCooled");
        

[Description("Choose an outside air node name or leave this field blank to use weather data. If" +
    " this field is blank, the Condenser Type is assumed to be AirCooled. This input " +
    "must be specified if Condenser Type = WaterCooled.")]
[JsonProperty("condenser_inlet_node_name")]
public string CondenserInletNodeName { get; set; } = "";
        

[Description("Enter a water outlet node name if Condenser Type = WaterCooled. Leave this field " +
    "blank if Condenser Type = Air or EvaporativelyCooled.")]
[JsonProperty("condenser_outlet_node_name")]
public string CondenserOutletNodeName { get; set; } = "";
        

[Description("Only used when Condenser Type = WaterCooled.")]
[JsonProperty("water_condenser_volume_flow_rate")]
public string WaterCondenserVolumeFlowRate { get; set; } = "";
        

[Description("Enter the effectiveness of the evaporatively cooled condenser. This field is only" +
    " used when the Condenser Type = EvaporativelyCooled.")]
[JsonProperty("evaporative_condenser_effectiveness")]
public System.Nullable<float> EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Used to calculate evaporative condenser water use. This field is only used when t" +
    "he Condenser Type = EvaporativelyCooled.")]
[JsonProperty("evaporative_condenser_air_flow_rate")]
public string EvaporativeCondenserAirFlowRate { get; set; } = "";
        

[Description("Rated power consumed by the evaporative condenser\'s water pump. This field is onl" +
    "y used when the Condenser Type = EvaporativelyCooled.")]
[JsonProperty("evaporative_condenser_pump_rated_power_consumption")]
public string EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = (System.String)"0";
        

[Description("A separate storage tank may be used to supply an evaporatively cooled condenser.")]
[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

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
public AirConditioner_VariableRefrigerantFlow_FuelType FuelType { get; set; } = (AirConditioner_VariableRefrigerantFlow_FuelType)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_FuelType), "Electricity");
        

[Description("The minimum outdoor temperature below which heat recovery mode will not operate.")]
[JsonProperty("minimum_outdoor_temperature_in_heat_recovery_mode")]
public System.Nullable<float> MinimumOutdoorTemperatureInHeatRecoveryMode { get; set; } = null;
        

[Description("The maximum outdoor temperature above which heat recovery mode will not operate.")]
[JsonProperty("maximum_outdoor_temperature_in_heat_recovery_mode")]
public System.Nullable<float> MaximumOutdoorTemperatureInHeatRecoveryMode { get; set; } = null;
        

[Description("Enter the name of a performance curve which represents the change in cooling capa" +
    "city when heat recovery is active A default constant of 0.9 is used if this inpu" +
    "t is blank")]
[JsonProperty("heat_recovery_cooling_capacity_modifier_curve_name")]
public string HeatRecoveryCoolingCapacityModifierCurveName { get; set; } = "";
        

[Description("Enter the fractional capacity available at the start of heat recovery mode. The c" +
    "apacity exponentially approaches the steady-state value according to the inputs " +
    "for Heat Recovery Cooling Capacity Modifier and Heat Recovery Cooling Capacity T" +
    "ime Constant")]
[JsonProperty("initial_heat_recovery_cooling_capacity_fraction")]
public System.Nullable<float> InitialHeatRecoveryCoolingCapacityFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("Enter the time constant used to model the transition from cooling only mode to he" +
    "at recovery mode")]
[JsonProperty("heat_recovery_cooling_capacity_time_constant")]
public System.Nullable<float> HeatRecoveryCoolingCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0.15", CultureInfo.InvariantCulture);
        

[Description("Enter the name of a performance curve which represents the change in cooling ener" +
    "gy when heat recovery is active A default constant of 1.1 is used if this input " +
    "is blank")]
[JsonProperty("heat_recovery_cooling_energy_modifier_curve_name")]
public string HeatRecoveryCoolingEnergyModifierCurveName { get; set; } = "";
        

[Description(@"Enter the fractional electric consumption rate at the start of heat recovery mode. The electric consumption rate exponentially approaches the steady-state value according to the inputs for Heat Recovery Cooling Energy Modifier and Heat Recovery Cooling Energy Time Constant")]
[JsonProperty("initial_heat_recovery_cooling_energy_fraction")]
public System.Nullable<float> InitialHeatRecoveryCoolingEnergyFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Enter the time constant used to model the transition from cooling only mode to he" +
    "at recovery mode")]
[JsonProperty("heat_recovery_cooling_energy_time_constant")]
public System.Nullable<float> HeatRecoveryCoolingEnergyTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the name of a performance curve which represents the change in heating capa" +
    "city when heat recovery is active A default constant of 1.1 is used if this inpu" +
    "t is blank")]
[JsonProperty("heat_recovery_heating_capacity_modifier_curve_name")]
public string HeatRecoveryHeatingCapacityModifierCurveName { get; set; } = "";
        

[Description("Enter the fractional capacity available at the start of heat recovery mode. The c" +
    "apacity exponentially approaches the steady-state value according to the inputs " +
    "for Heat Recovery Heating Capacity Modifier and Heat Recovery Heating Capacity T" +
    "ime Constant")]
[JsonProperty("initial_heat_recovery_heating_capacity_fraction")]
public System.Nullable<float> InitialHeatRecoveryHeatingCapacityFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Enter the time constant used to model the transition from cooling only mode to he" +
    "at recovery mode")]
[JsonProperty("heat_recovery_heating_capacity_time_constant")]
public System.Nullable<float> HeatRecoveryHeatingCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0.15", CultureInfo.InvariantCulture);
        

[Description("Enter the name of a performance curve which represents the change in heating elec" +
    "tric consumption rate when heat recovery is active A default constant of 1.1 is " +
    "used if this input is blank")]
[JsonProperty("heat_recovery_heating_energy_modifier_curve_name")]
public string HeatRecoveryHeatingEnergyModifierCurveName { get; set; } = "";
        

[Description(@"Enter the fractional electric consumption rate at the start of heat recovery mode. The electric consumption rate exponentially approaches the steady-state value according to the inputs for Heat Recovery Cooling Energy Modifier and Heat Recovery Cooling Energy Time Constant")]
[JsonProperty("initial_heat_recovery_heating_energy_fraction")]
public System.Nullable<float> InitialHeatRecoveryHeatingEnergyFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Enter the time constant used to model the transition from cooling only mode to he" +
    "at recovery mode")]
[JsonProperty("heat_recovery_heating_energy_time_constant")]
public System.Nullable<float> HeatRecoveryHeatingEnergyTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}
