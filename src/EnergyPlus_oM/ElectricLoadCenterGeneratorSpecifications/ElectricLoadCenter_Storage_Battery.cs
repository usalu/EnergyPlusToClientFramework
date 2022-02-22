using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Uses the kinetic battery model (KiBaM) to simulate rechargeable battery banks in an electrical load center. The battery bank is a collection of one or more individual battery modules. Given the surplus or deficit power from the electrical system and the state of charge from the previous time step, this object can model the voltage, current, and energy losses with charging and discharging during each time step. The cumulative battery damage can be also modeled and reported at the end of each simulation run.")]
    public class ElectricLoadCenter_Storage_Battery : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter name of zone to receive electrical storage losses as heat if blank then ele" +
                     "ctrical storage losses are dissipated to outdoors")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("radiative_fraction")]
        public System.Nullable<float> RadiativeFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("A module usually consists of several cells. The total number of modules in the ba" +
                     "ttery bank is equal to number of modules in parallel times number of modules in " +
                     "series.")]
        [JsonProperty("number_of_battery_modules_in_parallel")]
        public System.Nullable<float> NumberOfBatteryModulesInParallel { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("A module usually consists of several cells. The total number of modules in the ba" +
                     "ttery bank is equal to number of modules in parallel times number of modules in " +
                     "series.")]
        [JsonProperty("number_of_battery_modules_in_series")]
        public System.Nullable<float> NumberOfBatteryModulesInSeries { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The capacity is for each module. A model parameter from manufacturer\'s data or te" +
                     "st data.")]
        [JsonProperty("maximum_module_capacity")]
        public System.Nullable<float> MaximumModuleCapacity { get; set; } = null;
        

        [Description("The state of charge is evaluated based on the maximum capacity defined in the nex" +
                     "t field.")]
        [JsonProperty("initial_fractional_state_of_charge")]
        public System.Nullable<float> InitialFractionalStateOfCharge { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("A model parameter usually derived from test data by curve fitting.")]
        [JsonProperty("fraction_of_available_charge_capacity")]
        public System.Nullable<float> FractionOfAvailableChargeCapacity { get; set; } = null;
        

        [Description("A model parameter usually derived from test data by curve fitting.")]
        [JsonProperty("change_rate_from_bound_charge_to_available_charge")]
        public System.Nullable<float> ChangeRateFromBoundChargeToAvailableCharge { get; set; } = null;
        

        [Description("The voltage is for each battery module.")]
        [JsonProperty("fully_charged_module_open_circuit_voltage")]
        public System.Nullable<float> FullyChargedModuleOpenCircuitVoltage { get; set; } = null;
        

        [Description("The voltage is for each battery module.")]
        [JsonProperty("fully_discharged_module_open_circuit_voltage")]
        public System.Nullable<float> FullyDischargedModuleOpenCircuitVoltage { get; set; } = null;
        

        [Description("Determines how the open circuit voltage change with state of charge relative to t" +
                     "he fully discharged state.")]
        [JsonProperty("voltage_change_curve_name_for_charging")]
        public string VoltageChangeCurveNameForCharging { get; set; } = "";
        

        [Description("Determines how the open circuit voltage change with state of charge relative to t" +
                     "he fully charged state.")]
        [JsonProperty("voltage_change_curve_name_for_discharging")]
        public string VoltageChangeCurveNameForDischarging { get; set; } = "";
        

        [Description("A model parameter from manufacture or derived from test data. Internal resistance" +
                     " is assumed to be constant. The internal resistance is for each battery module.")]
        [JsonProperty("module_internal_electrical_resistance")]
        public System.Nullable<float> ModuleInternalElectricalResistance { get; set; } = null;
        

        [Description("The constraint on discharging current is for each battery module.")]
        [JsonProperty("maximum_module_discharging_current")]
        public System.Nullable<float> MaximumModuleDischargingCurrent { get; set; } = null;
        

        [Description("The voltage constraint is for each battery module.")]
        [JsonProperty("module_cut_off_voltage")]
        public System.Nullable<float> ModuleCutOffVoltage { get; set; } = null;
        

        [Description("units 1/hr Charge rate limit is the division between charging current the remaini" +
                     "ng capacity. The constraint on charging current is for each module.")]
        [JsonProperty("module_charge_rate_limit")]
        public System.Nullable<float> ModuleChargeRateLimit { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("battery_life_calculation")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes BatteryLifeCalculation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Only required when battery life calculation is activated")]
        [JsonProperty("number_of_cycle_bins")]
        public System.Nullable<float> NumberOfCycleBins { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Determines the number of cycles to failure in relation to cycle range. Only requi" +
                     "red when battery life calculation is activated.")]
        [JsonProperty("battery_life_curve_name")]
        public string BatteryLifeCurveName { get; set; } = "";
    }
}