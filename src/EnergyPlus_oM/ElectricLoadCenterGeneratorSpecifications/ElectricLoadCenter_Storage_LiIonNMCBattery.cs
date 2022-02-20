using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Uses Lithium Ion NMC model to simulate rechargeable battery banks in an electrical load center. The battery bank is a collection of one or more individual battery modules. Given the surplus or deficit power from the electrical system and the state of charge from the previous time step, this object can model the voltage, current, and energy losses with charging and discharging during each time step. The cumulative battery damage can be also modeled and reported at the end of each simulation run.")]
    [JsonObject("ElectricLoadCenter:Storage:LiIonNMCBattery")]
    public class ElectricLoadCenter_Storage_LiIonNMCBattery : BHoMObject
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
        

        [JsonProperty("lifetime_model")]
        public EmptyNoYes LifetimeModel { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "KandlerSmith");
        

        [Description("Battery voltage is calculated by multiplying this field by the nominal cell volta" +
                     "ge (N13, default 3.342V)")]
        [JsonProperty("number_of_cells_in_series")]
        public System.Nullable<float> NumberOfCellsInSeries { get; set; } = null;
        

        [Description("Capacity (Ah) is determined by multiplying this field by the cell capacity (N14, " +
                     "default 3.2 Ah)")]
        [JsonProperty("number_of_strings_in_parallel")]
        public System.Nullable<float> NumberOfStringsInParallel { get; set; } = null;
        

        [Description("The state of charge is evaluated based on the maximum capacity defined in the nex" +
                     "t field.")]
        [JsonProperty("initial_fractional_state_of_charge")]
        public System.Nullable<float> InitialFractionalStateOfCharge { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("dc_to_dc_charging_efficiency")]
        public System.Nullable<float> DcToDcChargingEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.95", CultureInfo.InvariantCulture);
        

        [JsonProperty("battery_mass")]
        public System.Nullable<float> BatteryMass { get; set; } = null;
        

        [JsonProperty("battery_surface_area")]
        public System.Nullable<float> BatterySurfaceArea { get; set; } = null;
        

        [JsonProperty("battery_specific_heat_capacity")]
        public System.Nullable<float> BatterySpecificHeatCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1500", CultureInfo.InvariantCulture);
        

        [JsonProperty("heat_transfer_coefficient_between_battery_and_ambient")]
        public System.Nullable<float> HeatTransferCoefficientBetweenBatteryAndAmbient { get; set; } = (System.Nullable<float>)Single.Parse("7.5", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty("fully_charged_cell_voltage")]
        public System.Nullable<float> FullyChargedCellVoltage { get; set; } = (System.Nullable<float>)Single.Parse("4.2", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty("cell_voltage_at_end_of_exponential_zone")]
        public System.Nullable<float> CellVoltageAtEndOfExponentialZone { get; set; } = (System.Nullable<float>)Single.Parse("3.53", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty("cell_voltage_at_end_of_nominal_zone")]
        public System.Nullable<float> CellVoltageAtEndOfNominalZone { get; set; } = (System.Nullable<float>)Single.Parse("3.342", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty("default_nominal_cell_voltage")]
        public System.Nullable<float> DefaultNominalCellVoltage { get; set; } = (System.Nullable<float>)Single.Parse("3.342", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty("fully_charged_cell_capacity")]
        public System.Nullable<float> FullyChargedCellCapacity { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty("fraction_of_cell_capacity_removed_at_the_end_of_exponential_zone")]
        public System.Nullable<float> FractionOfCellCapacityRemovedAtTheEndOfExponentialZone { get; set; } = (System.Nullable<float>)Single.Parse("0.8075", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty("fraction_of_cell_capacity_removed_at_the_end_of_nominal_zone")]
        public System.Nullable<float> FractionOfCellCapacityRemovedAtTheEndOfNominalZone { get; set; } = (System.Nullable<float>)Single.Parse("0.976875", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty("charge_rate_at_which_voltage_vs_capacity_curve_was_generated")]
        public System.Nullable<float> ChargeRateAtWhichVoltageVsCapacityCurveWasGenerated { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("for a single cell Most users should not need to change this value.")]
        [JsonProperty("battery_cell_internal_electrical_resistance")]
        public System.Nullable<float> BatteryCellInternalElectricalResistance { get; set; } = (System.Nullable<float>)Single.Parse("0.09", CultureInfo.InvariantCulture);
    }
}