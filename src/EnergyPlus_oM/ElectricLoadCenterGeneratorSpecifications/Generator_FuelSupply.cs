using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Used only with Generator:FuelCell and Generator:MicroCHP")]
    [JsonObject("Generator:FuelSupply")]
    public class Generator_FuelSupply : BHoMObject
    {
        

        [JsonProperty("fuel_temperature_modeling_mode")]
        public EmptyNoYes FuelTemperatureModelingMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("fuel_temperature_reference_node_name")]
        public string FuelTemperatureReferenceNodeName { get; set; } = "";
        

        [JsonProperty("fuel_temperature_schedule_name")]
        public string FuelTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("compressor_power_multiplier_function_of_fuel_rate_curve_name")]
        public string CompressorPowerMultiplierFunctionOfFuelRateCurveName { get; set; } = "";
        

        [JsonProperty("compressor_heat_loss_factor")]
        public System.Nullable<float> CompressorHeatLossFactor { get; set; } = null;
        

        [JsonProperty("fuel_type")]
        public EmptyNoYes FuelType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("liquid_generic_fuel_lower_heating_value")]
        public System.Nullable<float> LiquidGenericFuelLowerHeatingValue { get; set; } = null;
        

        [JsonProperty("liquid_generic_fuel_higher_heating_value")]
        public System.Nullable<float> LiquidGenericFuelHigherHeatingValue { get; set; } = null;
        

        [JsonProperty("liquid_generic_fuel_molecular_weight")]
        public System.Nullable<float> LiquidGenericFuelMolecularWeight { get; set; } = null;
        

        [JsonProperty("liquid_generic_fuel_co2_emission_factor")]
        public System.Nullable<float> LiquidGenericFuelCo2EmissionFactor { get; set; } = null;
        

        [JsonProperty("number_of_constituents_in_gaseous_constituent_fuel_supply")]
        public System.Nullable<float> NumberOfConstituentsInGaseousConstituentFuelSupply { get; set; } = null;
        

        [JsonProperty("constituent_1_name")]
        public EmptyNoYes Constituent1Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_1_molar_fraction")]
        public System.Nullable<float> Constituent1MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_2_name")]
        public EmptyNoYes Constituent2Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_2_molar_fraction")]
        public System.Nullable<float> Constituent2MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_3_name")]
        public EmptyNoYes Constituent3Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_3_molar_fraction")]
        public System.Nullable<float> Constituent3MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_4_name")]
        public EmptyNoYes Constituent4Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_4_molar_fraction")]
        public System.Nullable<float> Constituent4MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_5_name")]
        public EmptyNoYes Constituent5Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_5_molar_fraction")]
        public System.Nullable<float> Constituent5MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_6_name")]
        public EmptyNoYes Constituent6Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_6_molar_fraction")]
        public System.Nullable<float> Constituent6MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_7_name")]
        public EmptyNoYes Constituent7Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_7_molar_fraction")]
        public System.Nullable<float> Constituent7MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_8_name")]
        public EmptyNoYes Constituent8Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_8_molar_fraction")]
        public System.Nullable<float> Constituent8MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_9_name")]
        public EmptyNoYes Constituent9Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_9_molar_fraction")]
        public System.Nullable<float> Constituent9MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_10_name")]
        public EmptyNoYes Constituent10Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_10_molar_fraction")]
        public System.Nullable<float> Constituent10MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_11_name")]
        public EmptyNoYes Constituent11Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_11_molar_fraction")]
        public System.Nullable<float> Constituent11MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_12_name")]
        public EmptyNoYes Constituent12Name { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("constituent_12_molar_fraction")]
        public System.Nullable<float> Constituent12MolarFraction { get; set; } = null;
    }
}