using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Provides Fuel Factors for Emissions as well as Source=>Site conversions. OtherFue" +
                 "l1, OtherFuel2 provide options for users who want to create and use fuels that m" +
                 "ay not be mainstream (biomass, wood, pellets).")]
    [JsonObject("FuelFactors")]
    public class FuelFactors : BHoMObject
    {
        

        [JsonProperty("existing_fuel_resource_name")]
        public EmptyNoYes ExistingFuelResourceName { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("units_of_measure")]
        public string UnitsOfMeasure { get; set; } = "";
        

        [JsonProperty("energy_per_unit_factor")]
        public System.Nullable<float> EnergyPerUnitFactor { get; set; } = null;
        

        [JsonProperty("source_energy_factor")]
        public System.Nullable<float> SourceEnergyFactor { get; set; } = null;
        

        [JsonProperty("source_energy_schedule_name")]
        public string SourceEnergyScheduleName { get; set; } = "";
        

        [JsonProperty("co2_emission_factor")]
        public System.Nullable<float> Co2EmissionFactor { get; set; } = null;
        

        [JsonProperty("co2_emission_factor_schedule_name")]
        public string Co2EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("co_emission_factor")]
        public System.Nullable<float> CoEmissionFactor { get; set; } = null;
        

        [JsonProperty("co_emission_factor_schedule_name")]
        public string CoEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("ch4_emission_factor")]
        public System.Nullable<float> Ch4EmissionFactor { get; set; } = null;
        

        [JsonProperty("ch4_emission_factor_schedule_name")]
        public string Ch4EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("nox_emission_factor")]
        public System.Nullable<float> NoxEmissionFactor { get; set; } = null;
        

        [JsonProperty("nox_emission_factor_schedule_name")]
        public string NoxEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("n2o_emission_factor")]
        public System.Nullable<float> N2oEmissionFactor { get; set; } = null;
        

        [JsonProperty("n2o_emission_factor_schedule_name")]
        public string N2oEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("so2_emission_factor")]
        public System.Nullable<float> So2EmissionFactor { get; set; } = null;
        

        [JsonProperty("so2_emission_factor_schedule_name")]
        public string So2EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("pm_emission_factor")]
        public System.Nullable<float> PmEmissionFactor { get; set; } = null;
        

        [JsonProperty("pm_emission_factor_schedule_name")]
        public string PmEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("pm10_emission_factor")]
        public System.Nullable<float> Pm10EmissionFactor { get; set; } = null;
        

        [JsonProperty("pm10_emission_factor_schedule_name")]
        public string Pm10EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("pm2_5_emission_factor")]
        public System.Nullable<float> Pm25EmissionFactor { get; set; } = null;
        

        [JsonProperty("pm2_5_emission_factor_schedule_name")]
        public string Pm25EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("nh3_emission_factor")]
        public System.Nullable<float> Nh3EmissionFactor { get; set; } = null;
        

        [JsonProperty("nh3_emission_factor_schedule_name")]
        public string Nh3EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("nmvoc_emission_factor")]
        public System.Nullable<float> NmvocEmissionFactor { get; set; } = null;
        

        [JsonProperty("nmvoc_emission_factor_schedule_name")]
        public string NmvocEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("hg_emission_factor")]
        public System.Nullable<float> HgEmissionFactor { get; set; } = null;
        

        [JsonProperty("hg_emission_factor_schedule_name")]
        public string HgEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("pb_emission_factor")]
        public System.Nullable<float> PbEmissionFactor { get; set; } = null;
        

        [JsonProperty("pb_emission_factor_schedule_name")]
        public string PbEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("water_emission_factor")]
        public System.Nullable<float> WaterEmissionFactor { get; set; } = null;
        

        [JsonProperty("water_emission_factor_schedule_name")]
        public string WaterEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("nuclear_high_level_emission_factor")]
        public System.Nullable<float> NuclearHighLevelEmissionFactor { get; set; } = null;
        

        [JsonProperty("nuclear_high_level_emission_factor_schedule_name")]
        public string NuclearHighLevelEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty("nuclear_low_level_emission_factor")]
        public System.Nullable<float> NuclearLowLevelEmissionFactor { get; set; } = null;
        

        [JsonProperty("nuclear_low_level_emission_factor_schedule_name")]
        public string NuclearLowLevelEmissionFactorScheduleName { get; set; } = "";
    }
}