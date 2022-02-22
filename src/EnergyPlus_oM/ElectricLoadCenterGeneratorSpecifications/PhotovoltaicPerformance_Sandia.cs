using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Describes performance input data needed for specific makes and models of producti" +
                 "on PV panels using the empirical coefficients assembled by Sandia National Labor" +
                 "atory.")]
    public class PhotovoltaicPerformance_Sandia : BHoMObject, IEnergyPlusClass
    {
        

        [Description("(m2, single module)")]
        [JsonProperty("active_area")]
        public System.Nullable<float> ActiveArea { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("number_of_cells_in_series")]
        public System.Nullable<float> NumberOfCellsInSeries { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("number_of_cells_in_parallel")]
        public System.Nullable<float> NumberOfCellsInParallel { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("(Amps)")]
        [JsonProperty("short_circuit_current")]
        public System.Nullable<float> ShortCircuitCurrent { get; set; } = null;
        

        [Description("(Volts)")]
        [JsonProperty("open_circuit_voltage")]
        public System.Nullable<float> OpenCircuitVoltage { get; set; } = null;
        

        [Description("(Amps)")]
        [JsonProperty("current_at_maximum_power_point")]
        public System.Nullable<float> CurrentAtMaximumPowerPoint { get; set; } = null;
        

        [Description("(Volts)")]
        [JsonProperty("voltage_at_maximum_power_point")]
        public System.Nullable<float> VoltageAtMaximumPowerPoint { get; set; } = null;
        

        [Description("(1/degC)")]
        [JsonProperty("sandia_database_parameter_aisc")]
        public System.Nullable<float> SandiaDatabaseParameterAisc { get; set; } = null;
        

        [Description("(1/degC)")]
        [JsonProperty("sandia_database_parameter_aimp")]
        public System.Nullable<float> SandiaDatabaseParameterAimp { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_c0")]
        public System.Nullable<float> SandiaDatabaseParameterC0 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_c1")]
        public System.Nullable<float> SandiaDatabaseParameterC1 { get; set; } = null;
        

        [Description("(Volts/degC)")]
        [JsonProperty("sandia_database_parameter_bvoc0")]
        public System.Nullable<float> SandiaDatabaseParameterBvoc0 { get; set; } = null;
        

        [Description("(Volts/degC)")]
        [JsonProperty("sandia_database_parameter_mbvoc")]
        public System.Nullable<float> SandiaDatabaseParameterMbvoc { get; set; } = null;
        

        [Description("(Volts/degC)")]
        [JsonProperty("sandia_database_parameter_bvmp0")]
        public System.Nullable<float> SandiaDatabaseParameterBvmp0 { get; set; } = null;
        

        [Description("(Volts/degC)")]
        [JsonProperty("sandia_database_parameter_mbvmp")]
        public System.Nullable<float> SandiaDatabaseParameterMbvmp { get; set; } = null;
        

        [JsonProperty("diode_factor")]
        public System.Nullable<float> DiodeFactor { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_c2")]
        public System.Nullable<float> SandiaDatabaseParameterC2 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_c3")]
        public System.Nullable<float> SandiaDatabaseParameterC3 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_a0")]
        public System.Nullable<float> SandiaDatabaseParameterA0 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_a1")]
        public System.Nullable<float> SandiaDatabaseParameterA1 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_a2")]
        public System.Nullable<float> SandiaDatabaseParameterA2 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_a3")]
        public System.Nullable<float> SandiaDatabaseParameterA3 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_a4")]
        public System.Nullable<float> SandiaDatabaseParameterA4 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_b0")]
        public System.Nullable<float> SandiaDatabaseParameterB0 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_b1")]
        public System.Nullable<float> SandiaDatabaseParameterB1 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_b2")]
        public System.Nullable<float> SandiaDatabaseParameterB2 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_b3")]
        public System.Nullable<float> SandiaDatabaseParameterB3 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_b4")]
        public System.Nullable<float> SandiaDatabaseParameterB4 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_b5")]
        public System.Nullable<float> SandiaDatabaseParameterB5 { get; set; } = null;
        

        [Description("(deg C)")]
        [JsonProperty("sandia_database_parameter_delta_tc_")]
        public System.Nullable<float> SandiaDatabaseParameterDeltaTc { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_fd")]
        public System.Nullable<float> SandiaDatabaseParameterFd { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_a")]
        public System.Nullable<float> SandiaDatabaseParameterA { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_b")]
        public System.Nullable<float> SandiaDatabaseParameterB { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_c4")]
        public System.Nullable<float> SandiaDatabaseParameterC4 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_c5")]
        public System.Nullable<float> SandiaDatabaseParameterC5 { get; set; } = null;
        

        [Description("(Amps)")]
        [JsonProperty("sandia_database_parameter_ix0")]
        public System.Nullable<float> SandiaDatabaseParameterIx0 { get; set; } = null;
        

        [Description("(Amps)")]
        [JsonProperty("sandia_database_parameter_ixx0")]
        public System.Nullable<float> SandiaDatabaseParameterIxx0 { get; set; } = null;
        

        [JsonProperty("sandia_database_parameter_c6")]
        public System.Nullable<float> SandiaDatabaseParameterC6 { get; set; } = null;
        

        [Description("(non-dimensional)")]
        [JsonProperty("sandia_database_parameter_c7")]
        public System.Nullable<float> SandiaDatabaseParameterC7 { get; set; } = null;
    }
}