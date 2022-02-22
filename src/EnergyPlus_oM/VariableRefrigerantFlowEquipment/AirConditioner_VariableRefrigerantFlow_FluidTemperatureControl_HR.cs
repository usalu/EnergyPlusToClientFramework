using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    [Description(@"This is a key object in the new physics based VRF Heat Recovery (HR) model applicable for Fluid Temperature Control. It describes the VRF HR system excluding the performance of indoor units. Indoor units are modeled separately in the ZoneHVAC:TerminalUnit:VariableRefrigerantFlow object")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of a schedule that defines the availability of the unit Schedule v" +
                     "alues of 0 denote the unit is off. All other values denote the unit is available" +
                     " If this field is left blank, the unit is available the entire simulation")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter the name of a ZoneTerminalUnitList. This list connects zone terminal units " +
                     "to this heat pump")]
        [JsonProperty("zone_terminal_unit_list_name")]
        public string ZoneTerminalUnitListName { get; set; } = "";
        

        [JsonProperty("refrigerant_type")]
        public string RefrigerantType { get; set; } = (System.String)"R410A";
        

        [Description(@"Enter the total evaporative capacity in watts at rated conditions This is the capacity corresponding to the max compressor speed at rated conditions The actual evaporative capacity is obtained by multiplying the rated capacity with the modification factor calculated by Evaporative Capacity Multiplier Function of Temperature Curve")]
        [JsonProperty("rated_evaporative_capacity")]
        public string RatedEvaporativeCapacity { get; set; } = (System.String)"40000";
        

        [Description(@"Enter the rated compressor power per Watt of rated evaporative capacity [W/W] Rated compressor power corresponds to the max compressor speed at rated conditions The actual compressor power is obtained by multiplying the rated power with the modification factor calculated by Compressor Power Multiplier Function of Temperature Curve")]
        [JsonProperty("rated_compressor_power_per_unit_of_rated_evaporative_capacity")]
        public System.Nullable<float> RatedCompressorPowerPerUnitOfRatedEvaporativeCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0.35", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum outdoor temperature allowed for cooling operation Cooling is di" +
                     "sabled below this temperature")]
        [JsonProperty("minimum_outdoor_air_temperature_in_cooling_only_mode")]
        public System.Nullable<float> MinimumOutdoorAirTemperatureInCoolingOnlyMode { get; set; } = (System.Nullable<float>)Single.Parse("-6", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature allowed for cooling operation Cooling is di" +
                     "sabled above this temperature")]
        [JsonProperty("maximum_outdoor_air_temperature_in_cooling_only_mode")]
        public System.Nullable<float> MaximumOutdoorAirTemperatureInCoolingOnlyMode { get; set; } = (System.Nullable<float>)Single.Parse("43", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum outdoor temperature allowed for heating operation Heating is di" +
                     "sabled below this temperature")]
        [JsonProperty("minimum_outdoor_air_temperature_in_heating_only_mode")]
        public System.Nullable<float> MinimumOutdoorAirTemperatureInHeatingOnlyMode { get; set; } = (System.Nullable<float>)Single.Parse("-20", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature allowed for heating operation Heating is di" +
                     "sabled below this temperature")]
        [JsonProperty("maximum_outdoor_air_temperature_in_heating_only_mode")]
        public System.Nullable<float> MaximumOutdoorAirTemperatureInHeatingOnlyMode { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [Description("The minimum outdoor temperature below which heat recovery mode will not operate.")]
        [JsonProperty("minimum_outdoor_temperature_in_heat_recovery_mode")]
        public System.Nullable<float> MinimumOutdoorTemperatureInHeatRecoveryMode { get; set; } = (System.Nullable<float>)Single.Parse("-20", CultureInfo.InvariantCulture);
        

        [Description("The maximum outdoor temperature above which heat recovery mode will not operate.")]
        [JsonProperty("maximum_outdoor_temperature_in_heat_recovery_mode")]
        public System.Nullable<float> MaximumOutdoorTemperatureInHeatRecoveryMode { get; set; } = (System.Nullable<float>)Single.Parse("43", CultureInfo.InvariantCulture);
        

        [JsonProperty("refrigerant_temperature_control_algorithm_for_indoor_unit")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_RefrigerantTemperatureControlAlgorithmForIndoorUnit RefrigerantTemperatureControlAlgorithmForIndoorUnit { get; set; } = (AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_RefrigerantTemperatureControlAlgorithmForIndoorUnit)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_RefrigerantTemperatureControlAlgorithmForIndoorUnit), "VariableTemp");
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is ConstantTemp E" +
                     "vaporating temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty("reference_evaporating_temperature_for_indoor_unit")]
        public System.Nullable<float> ReferenceEvaporatingTemperatureForIndoorUnit { get; set; } = (System.Nullable<float>)Single.Parse("6", CultureInfo.InvariantCulture);
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is ConstantTemp C" +
                     "ondensing temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty("reference_condensing_temperature_for_indoor_unit")]
        public System.Nullable<float> ReferenceCondensingTemperatureForIndoorUnit { get; set; } = (System.Nullable<float>)Single.Parse("44", CultureInfo.InvariantCulture);
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is VariableTemp E" +
                     "vaporating temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty("variable_evaporating_temperature_minimum_for_indoor_unit")]
        public System.Nullable<float> VariableEvaporatingTemperatureMinimumForIndoorUnit { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is VariableTemp E" +
                     "vaporating temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty("variable_evaporating_temperature_maximum_for_indoor_unit")]
        public System.Nullable<float> VariableEvaporatingTemperatureMaximumForIndoorUnit { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is VariableTemp C" +
                     "ondensing temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty("variable_condensing_temperature_minimum_for_indoor_unit")]
        public System.Nullable<float> VariableCondensingTemperatureMinimumForIndoorUnit { get; set; } = (System.Nullable<float>)Single.Parse("42", CultureInfo.InvariantCulture);
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is VariableTemp C" +
                     "ondensing temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty("variable_condensing_temperature_maximum_for_indoor_unit")]
        public System.Nullable<float> VariableCondensingTemperatureMaximumForIndoorUnit { get; set; } = (System.Nullable<float>)Single.Parse("46", CultureInfo.InvariantCulture);
        

        [JsonProperty("outdoor_unit_evaporator_reference_superheating")]
        public System.Nullable<float> OutdoorUnitEvaporatorReferenceSuperheating { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty("outdoor_unit_condenser_reference_subcooling")]
        public System.Nullable<float> OutdoorUnitCondenserReferenceSubcooling { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("outdoor_unit_evaporator_rated_bypass_factor")]
        public System.Nullable<float> OutdoorUnitEvaporatorRatedBypassFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("outdoor_unit_condenser_rated_bypass_factor")]
        public System.Nullable<float> OutdoorUnitCondenserRatedBypassFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty("difference_between_outdoor_unit_evaporating_temperature_and_outdoor_air_temperatu" +
                      "re_in_heat_recovery_mode")]
        public System.Nullable<float> DifferenceBetweenOutdoorUnitEvaporatingTemperatureAndOutdoorAirTemperatureInHeatRecoveryMode { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("Enter the rated capacity ratio between the main and supplementary outdoor unit he" +
                     "at exchangers [W/W]")]
        [JsonProperty("outdoor_unit_heat_exchanger_capacity_ratio")]
        public System.Nullable<float> OutdoorUnitHeatExchangerCapacityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor unit fan power per Watt of rated evaporative capacity [W/W]")]
        [JsonProperty("outdoor_unit_fan_power_per_unit_of_rated_evaporative_capacity")]
        public System.Nullable<float> OutdoorUnitFanPowerPerUnitOfRatedEvaporativeCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0.00425", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor unit fan flow rate per Watt of rated evaporative capacity [W/W]" +
                     "")]
        [JsonProperty("outdoor_unit_fan_flow_rate_per_unit_of_rated_evaporative_capacity")]
        public System.Nullable<float> OutdoorUnitFanFlowRatePerUnitOfRatedEvaporativeCapacity { get; set; } = (System.Nullable<float>)Single.Parse("7.5E-05", CultureInfo.InvariantCulture);
        

        [JsonProperty("outdoor_unit_evaporating_temperature_function_of_superheating_curve_name")]
        public string OutdoorUnitEvaporatingTemperatureFunctionOfSuperheatingCurveName { get; set; } = "";
        

        [JsonProperty("outdoor_unit_condensing_temperature_function_of_subcooling_curve_name")]
        public string OutdoorUnitCondensingTemperatureFunctionOfSubcoolingCurveName { get; set; } = "";
        

        [Description("used to calculate the piping loss")]
        [JsonProperty("diameter_of_main_pipe_for_suction_gas")]
        public System.Nullable<float> DiameterOfMainPipeForSuctionGas { get; set; } = (System.Nullable<float>)Single.Parse("0.0762", CultureInfo.InvariantCulture);
        

        [Description("used to calculate the piping loss")]
        [JsonProperty("diameter_of_main_pipe_for_discharge_gas")]
        public System.Nullable<float> DiameterOfMainPipeForDischargeGas { get; set; } = (System.Nullable<float>)Single.Parse("0.0762", CultureInfo.InvariantCulture);
        

        [Description("used to calculate the heat loss of the main pipe")]
        [JsonProperty("length_of_main_pipe_connecting_outdoor_unit_to_the_first_branch_joint")]
        public System.Nullable<float> LengthOfMainPipeConnectingOutdoorUnitToTheFirstBranchJoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("used to calculate the refrigerant pressure drop of the main pipe")]
        [JsonProperty("equivalent_length_of_main_pipe_connecting_outdoor_unit_to_the_first_branch_joint")]
        public System.Nullable<float> EquivalentLengthOfMainPipeConnectingOutdoorUnitToTheFirstBranchJoint { get; set; } = (System.Nullable<float>)Single.Parse("36", CultureInfo.InvariantCulture);
        

        [Description("Difference between outdoor unit height and indoor unit height Positive means outd" +
                     "oor unit is higher than indoor unit Negative means outdoor unit is lower than in" +
                     "door unit")]
        [JsonProperty("height_difference_between_outdoor_unit_and_indoor_units")]
        public System.Nullable<float> HeightDifferenceBetweenOutdoorUnitAndIndoorUnits { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("main_pipe_insulation_thickness")]
        public System.Nullable<float> MainPipeInsulationThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.02", CultureInfo.InvariantCulture);
        

        [JsonProperty("main_pipe_insulation_thermal_conductivity")]
        public System.Nullable<float> MainPipeInsulationThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.032", CultureInfo.InvariantCulture);
        

        [Description("Enter the value of the resistive heater located in the compressor(s). This heater" +
                     " is used to warm the refrigerant and oil when the compressor is off")]
        [JsonProperty("crankcase_heater_power_per_compressor")]
        public System.Nullable<float> CrankcaseHeaterPowerPerCompressor { get; set; } = (System.Nullable<float>)Single.Parse("33", CultureInfo.InvariantCulture);
        

        [Description("Enter the total number of compressor. This input is used only for crankcase heate" +
                     "r calculations.")]
        [JsonProperty("number_of_compressors")]
        public System.Nullable<float> NumberOfCompressors { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Enter the ratio of the first stage compressor to total compressor capacity All ot" +
                     "her compressors are assumed to be equally sized. This inputs is used only for cr" +
                     "ankcase heater calculations")]
        [JsonProperty("ratio_of_compressor_size_to_total_compressor_capacity")]
        public System.Nullable<float> RatioOfCompressorSizeToTotalCompressorCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature above which the crankcase heaters are disab" +
                     "led")]
        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeater { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("Select a defrost strategy. Reverse cycle reverses the operating mode from heating" +
                     " to cooling to melt frost formation on the condenser coil The resistive strategy" +
                     " uses a resistive heater to melt the frost.")]
        [JsonProperty("defrost_strategy")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostStrategy DefrostStrategy { get; set; } = (AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostStrategy)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostStrategy), "Resistive");
        

        [Description("Choose a defrost control type Either use a fixed Timed defrost period or select O" +
                     "nDemand to defrost only when necessary")]
        [JsonProperty("defrost_control")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostControl DefrostControl { get; set; } = (AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostControl)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostControl), "Timed");
        

        [Description("A valid performance curve must be used if ReverseCycle defrost strategy is select" +
                     "ed")]
        [JsonProperty("defrost_energy_input_ratio_modifier_function_of_temperature_curve_name")]
        public string DefrostEnergyInputRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Fraction of time in defrost mode Only applicable if timed defrost control is spec" +
                     "ified")]
        [JsonProperty("defrost_time_period_fraction")]
        public System.Nullable<float> DefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [Description("Enter the size of the resistive defrost heating element Only applicable if resist" +
                     "ive defrost strategy is specified")]
        [JsonProperty("resistive_defrost_heater_capacity")]
        public string ResistiveDefrostHeaterCapacity { get; set; } = (System.String)"0";
        

        [Description("Enter the maximum outdoor temperature above which the defrost operation is disabl" +
                     "ed")]
        [JsonProperty("maximum_outdoor_dry_bulb_temperature_for_defrost_operation")]
        public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForDefrostOperation { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [Description(@"This is used to describe the transition from Cooling Only mode to Heat Recovery mode Enter the fractional capacity available at the start of heat recovery mode. The capacity exponentially approaches the steady-state value according to the inputs for Heat Recovery Cooling Capacity Modifier and Heat Recovery Cooling Capacity Time Constant")]
        [JsonProperty("initial_heat_recovery_cooling_capacity_fraction")]
        public System.Nullable<float> InitialHeatRecoveryCoolingCapacityFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This is used to describe the transition from Cooling Only mode to Heat Recovery m" +
                     "ode Enter the time constant used to model the transition from cooling only mode " +
                     "to heat recovery mode")]
        [JsonProperty("heat_recovery_cooling_capacity_time_constant")]
        public System.Nullable<float> HeatRecoveryCoolingCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"This is used to describe the transition from Cooling Only mode to Heat Recovery mode Enter the fractional electric consumption rate at the start of heat recovery mode. The electric consumption rate exponentially approaches the steady-state value according to the inputs for Heat Recovery Cooling Energy Modifier and Heat Recovery Cooling Energy Time Constant")]
        [JsonProperty("initial_heat_recovery_cooling_energy_fraction")]
        public System.Nullable<float> InitialHeatRecoveryCoolingEnergyFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This is used to describe the transition from Cooling Only mode to Heat Recovery m" +
                     "ode Enter the time constant used to model the transition from cooling only mode " +
                     "to heat recovery mode")]
        [JsonProperty("heat_recovery_cooling_energy_time_constant")]
        public System.Nullable<float> HeatRecoveryCoolingEnergyTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"This is used to describe the transition from Heating Only mode to Heat Recovery mode Enter the fractional capacity available at the start of heat recovery mode. The capacity exponentially approaches the steady-state value according to the inputs for Heat Recovery Heating Capacity Modifier and Heat Recovery Heating Capacity Time Constant")]
        [JsonProperty("initial_heat_recovery_heating_capacity_fraction")]
        public System.Nullable<float> InitialHeatRecoveryHeatingCapacityFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This is used to describe the transition from Heating Only mode to Heat Recovery m" +
                     "ode Enter the time constant used to model the transition from cooling only mode " +
                     "to heat recovery mode")]
        [JsonProperty("heat_recovery_heating_capacity_time_constant")]
        public System.Nullable<float> HeatRecoveryHeatingCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"This is used to describe the transition from Heating Only mode to Heat Recovery mode Enter the fractional electric consumption rate at the start of heat recovery mode. The electric consumption rate exponentially approaches the steady-state value according to the inputs for Heat Recovery Cooling Energy Modifier and Heat Recovery Cooling Energy Time Constant")]
        [JsonProperty("initial_heat_recovery_heating_energy_fraction")]
        public System.Nullable<float> InitialHeatRecoveryHeatingEnergyFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This is used to describe the transition from Heating Only mode to Heat Recovery m" +
                     "ode Enter the time constant used to model the transition from cooling only mode " +
                     "to heat recovery mode")]
        [JsonProperty("heat_recovery_heating_energy_time_constant")]
        public System.Nullable<float> HeatRecoveryHeatingEnergyTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("compressor_maximum_delta_pressure")]
        public System.Nullable<float> CompressorMaximumDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("4500000", CultureInfo.InvariantCulture);
        

        [Description("Efficiency of the compressor inverter")]
        [JsonProperty("compressor_inverter_efficiency")]
        public System.Nullable<float> CompressorInverterEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.95", CultureInfo.InvariantCulture);
        

        [Description("Describe the evaporative capacity difference because of system configuration diff" +
                     "erence between test bed and real system.")]
        [JsonProperty("compressor_evaporative_capacity_correction_factor")]
        public System.Nullable<float> CompressorEvaporativeCapacityCorrectionFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Load index describe the compressor operational state, either a single compressor " +
                     "or multiple compressors, at different load levels. First index represents minima" +
                     "l capacity operation Last index represents full capacity operation")]
        [JsonProperty("number_of_compressor_loading_index_entries")]
        public System.Nullable<float> NumberOfCompressorLoadingIndexEntries { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [JsonProperty("loading_indices")]
        public string LoadingIndices { get; set; } = "";
    }
}