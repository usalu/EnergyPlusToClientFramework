using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    [Description(@"This is a key object in the new physics based VRF model applicable for Fluid Temperature Control It describes the Variable Refrigerant Flow system excluding the performance of indoor units Indoor units are modeled separately, see ZoneHVAC:TerminalUnit:VariableRefrigerantFlow")]
    [JsonObject("AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl")]
    public class AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl : BHoMObject
    {
        

        [Description("Enter a unique name for this variable refrigerant flow heat pump")]
        [JsonProperty("heat_pump_name")]
        public string HeatPumpName { get; set; } = "";
        

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
        [JsonProperty("minimum_outdoor_air_temperature_in_cooling_mode")]
        public System.Nullable<float> MinimumOutdoorAirTemperatureInCoolingMode { get; set; } = (System.Nullable<float>)Single.Parse("-6", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature allowed for cooling operation Cooling is di" +
                     "sabled above this temperature")]
        [JsonProperty("maximum_outdoor_air_temperature_in_cooling_mode")]
        public System.Nullable<float> MaximumOutdoorAirTemperatureInCoolingMode { get; set; } = (System.Nullable<float>)Single.Parse("43", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum outdoor temperature allowed for heating operation Heating is di" +
                     "sabled below this temperature")]
        [JsonProperty("minimum_outdoor_air_temperature_in_heating_mode")]
        public System.Nullable<float> MinimumOutdoorAirTemperatureInHeatingMode { get; set; } = (System.Nullable<float>)Single.Parse("-20", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature allowed for heating operation Heating is di" +
                     "sabled below this temperature")]
        [JsonProperty("maximum_outdoor_air_temperature_in_heating_mode")]
        public System.Nullable<float> MaximumOutdoorAirTemperatureInHeatingMode { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty("reference_outdoor_unit_superheating")]
        public System.Nullable<float> ReferenceOutdoorUnitSuperheating { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty("reference_outdoor_unit_subcooling")]
        public System.Nullable<float> ReferenceOutdoorUnitSubcooling { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty("refrigerant_temperature_control_algorithm_for_indoor_unit")]
        public EmptyNoYes RefrigerantTemperatureControlAlgorithmForIndoorUnit { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "VariableTemp");
        

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
        

        [Description("Enter the outdoor unit fan power per Watt of rated evaporative capacity [W/W]")]
        [JsonProperty("outdoor_unit_fan_power_per_unit_of_rated_evaporative_capacity")]
        public System.Nullable<float> OutdoorUnitFanPowerPerUnitOfRatedEvaporativeCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0.00425", CultureInfo.InvariantCulture);
        

        [Description("This field is only used if the previous is set to autocalculate and performance i" +
                     "nput method is NominalCapacity")]
        [JsonProperty("outdoor_unit_fan_flow_rate_per_unit_of_rated_evaporative_capacity")]
        public System.Nullable<float> OutdoorUnitFanFlowRatePerUnitOfRatedEvaporativeCapacity { get; set; } = (System.Nullable<float>)Single.Parse("7.5E-05", CultureInfo.InvariantCulture);
        

        [JsonProperty("outdoor_unit_evaporating_temperature_function_of_superheating_curve_name")]
        public string OutdoorUnitEvaporatingTemperatureFunctionOfSuperheatingCurveName { get; set; } = "";
        

        [JsonProperty("outdoor_unit_condensing_temperature_function_of_subcooling_curve_name")]
        public string OutdoorUnitCondensingTemperatureFunctionOfSubcoolingCurveName { get; set; } = "";
        

        [Description("used to calculate the piping loss")]
        [JsonProperty("diameter_of_main_pipe_connecting_outdoor_unit_to_the_first_branch_joint")]
        public System.Nullable<float> DiameterOfMainPipeConnectingOutdoorUnitToTheFirstBranchJoint { get; set; } = (System.Nullable<float>)Single.Parse("0.0762", CultureInfo.InvariantCulture);
        

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
        public EmptyNoYes DefrostStrategy { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Resistive");
        

        [Description("Choose a defrost control type Either use a fixed Timed defrost period or select O" +
                     "nDemand to defrost only when necessary")]
        [JsonProperty("defrost_control")]
        public EmptyNoYes DefrostControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Timed");
        

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
        

        [JsonProperty("compressor_maximum_delta_pressure")]
        public System.Nullable<float> CompressorMaximumDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("4500000", CultureInfo.InvariantCulture);
        

        [Description("First index represents minimal capacity operation Last index represents full capa" +
                     "city operation")]
        [JsonProperty("number_of_compressor_loading_index_entries")]
        public System.Nullable<float> NumberOfCompressorLoadingIndexEntries { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [JsonProperty("loading_indices")]
        public string LoadingIndices { get; set; } = "";
    }
}