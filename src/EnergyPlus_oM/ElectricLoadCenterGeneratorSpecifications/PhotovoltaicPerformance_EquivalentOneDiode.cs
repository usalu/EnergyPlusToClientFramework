using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Describes the performance characteristics of Photovoltaic (PV) modules to be mode" +
                 "led using an equivalent one-diode circuit. This model is also known as the 4- or" +
                 " 5-parameter TRNSYS model for photovoltaics.")]
    public class PhotovoltaicPerformance_EquivalentOneDiode : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("cell_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PhotovoltaicPerformance_EquivalentOneDiode_CellType CellType { get; set; } = (PhotovoltaicPerformance_EquivalentOneDiode_CellType)Enum.Parse(typeof(PhotovoltaicPerformance_EquivalentOneDiode_CellType), "AmorphousSilicon");
        

        [JsonProperty("number_of_cells_in_series")]
        public System.Nullable<float> NumberOfCellsInSeries { get; set; } = (System.Nullable<float>)Single.Parse("36", CultureInfo.InvariantCulture);
        

        [Description("The total power output of the array is determined by the number of modules (see a" +
                     "bove). The Active Area is only used to calculate the PV Array Efficiency output " +
                     "variable.")]
        [JsonProperty("active_area")]
        public System.Nullable<float> ActiveArea { get; set; } = (System.Nullable<float>)Single.Parse("0.89", CultureInfo.InvariantCulture);
        

        [JsonProperty("transmittance_absorptance_product")]
        public System.Nullable<float> TransmittanceAbsorptanceProduct { get; set; } = (System.Nullable<float>)Single.Parse("0.95", CultureInfo.InvariantCulture);
        

        [JsonProperty("semiconductor_bandgap")]
        public System.Nullable<float> SemiconductorBandgap { get; set; } = (System.Nullable<float>)Single.Parse("1.12", CultureInfo.InvariantCulture);
        

        [JsonProperty("shunt_resistance")]
        public System.Nullable<float> ShuntResistance { get; set; } = (System.Nullable<float>)Single.Parse("1000000", CultureInfo.InvariantCulture);
        

        [JsonProperty("short_circuit_current")]
        public System.Nullable<float> ShortCircuitCurrent { get; set; } = (System.Nullable<float>)Single.Parse("6.5", CultureInfo.InvariantCulture);
        

        [JsonProperty("open_circuit_voltage")]
        public System.Nullable<float> OpenCircuitVoltage { get; set; } = (System.Nullable<float>)Single.Parse("21.6", CultureInfo.InvariantCulture);
        

        [JsonProperty("reference_temperature")]
        public System.Nullable<float> ReferenceTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25", CultureInfo.InvariantCulture);
        

        [JsonProperty("reference_insolation")]
        public System.Nullable<float> ReferenceInsolation { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

        [Description("Single module current at the maximum power point and reference conditions. Module" +
                     " Current, Module Voltage, Number of Modules in Parallel and Number of Modules in" +
                     " Series determine the maximum power output of the array.")]
        [JsonProperty("module_current_at_maximum_power")]
        public System.Nullable<float> ModuleCurrentAtMaximumPower { get; set; } = (System.Nullable<float>)Single.Parse("5.9", CultureInfo.InvariantCulture);
        

        [Description("Single module voltage at the maximum power point and reference conditions. Module" +
                     " Current, Module Voltage, Number of Modules in Parallel and Number of Modules in" +
                     " Series determine the maximum power output of the array.")]
        [JsonProperty("module_voltage_at_maximum_power")]
        public System.Nullable<float> ModuleVoltageAtMaximumPower { get; set; } = (System.Nullable<float>)Single.Parse("17", CultureInfo.InvariantCulture);
        

        [JsonProperty("temperature_coefficient_of_short_circuit_current")]
        public System.Nullable<float> TemperatureCoefficientOfShortCircuitCurrent { get; set; } = (System.Nullable<float>)Single.Parse("0.02", CultureInfo.InvariantCulture);
        

        [JsonProperty("temperature_coefficient_of_open_circuit_voltage")]
        public System.Nullable<float> TemperatureCoefficientOfOpenCircuitVoltage { get; set; } = (System.Nullable<float>)Single.Parse("-0.079", CultureInfo.InvariantCulture);
        

        [JsonProperty("nominal_operating_cell_temperature_test_ambient_temperature")]
        public System.Nullable<float> NominalOperatingCellTemperatureTestAmbientTemperature { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

        [JsonProperty("nominal_operating_cell_temperature_test_cell_temperature")]
        public System.Nullable<float> NominalOperatingCellTemperatureTestCellTemperature { get; set; } = (System.Nullable<float>)Single.Parse("40", CultureInfo.InvariantCulture);
        

        [JsonProperty("nominal_operating_cell_temperature_test_insolation")]
        public System.Nullable<float> NominalOperatingCellTemperatureTestInsolation { get; set; } = (System.Nullable<float>)Single.Parse("800", CultureInfo.InvariantCulture);
        

        [JsonProperty("module_heat_loss_coefficient")]
        public System.Nullable<float> ModuleHeatLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

        [JsonProperty("total_heat_capacity")]
        public System.Nullable<float> TotalHeatCapacity { get; set; } = (System.Nullable<float>)Single.Parse("50000", CultureInfo.InvariantCulture);
    }
}