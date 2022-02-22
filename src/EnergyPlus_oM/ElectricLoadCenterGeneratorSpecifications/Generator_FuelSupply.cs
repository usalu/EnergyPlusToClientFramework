using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Used only with Generator:FuelCell and Generator:MicroCHP")]
    [JsonObject("Generator:FuelSupply")]
    public class Generator_FuelSupply : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("fuel_temperature_modeling_mode")]
        public Generator_FuelSupply_FuelTemperatureModelingMode FuelTemperatureModelingMode { get; set; } = (Generator_FuelSupply_FuelTemperatureModelingMode)Enum.Parse(typeof(Generator_FuelSupply_FuelTemperatureModelingMode), "Scheduled");
        

        [JsonProperty("fuel_temperature_reference_node_name")]
        public string FuelTemperatureReferenceNodeName { get; set; } = "";
        

        [JsonProperty("fuel_temperature_schedule_name")]
        public string FuelTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty("compressor_power_multiplier_function_of_fuel_rate_curve_name")]
        public string CompressorPowerMultiplierFunctionOfFuelRateCurveName { get; set; } = "";
        

        [JsonProperty("compressor_heat_loss_factor")]
        public System.Nullable<float> CompressorHeatLossFactor { get; set; } = null;
        

        [JsonProperty("fuel_type")]
        public Generator_FuelSupply_FuelType FuelType { get; set; } = (Generator_FuelSupply_FuelType)Enum.Parse(typeof(Generator_FuelSupply_FuelType), "GaseousConstituents");
        

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
        public Generator_FuelSupply_Constituent1Name Constituent1Name { get; set; } = (Generator_FuelSupply_Constituent1Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent1Name), "Argon");
        

        [JsonProperty("constituent_1_molar_fraction")]
        public System.Nullable<float> Constituent1MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_2_name")]
        public Generator_FuelSupply_Constituent2Name Constituent2Name { get; set; } = (Generator_FuelSupply_Constituent2Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent2Name), "Argon");
        

        [JsonProperty("constituent_2_molar_fraction")]
        public System.Nullable<float> Constituent2MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_3_name")]
        public Generator_FuelSupply_Constituent3Name Constituent3Name { get; set; } = (Generator_FuelSupply_Constituent3Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent3Name), "Argon");
        

        [JsonProperty("constituent_3_molar_fraction")]
        public System.Nullable<float> Constituent3MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_4_name")]
        public Generator_FuelSupply_Constituent4Name Constituent4Name { get; set; } = (Generator_FuelSupply_Constituent4Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent4Name), "Argon");
        

        [JsonProperty("constituent_4_molar_fraction")]
        public System.Nullable<float> Constituent4MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_5_name")]
        public Generator_FuelSupply_Constituent5Name Constituent5Name { get; set; } = (Generator_FuelSupply_Constituent5Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent5Name), "Argon");
        

        [JsonProperty("constituent_5_molar_fraction")]
        public System.Nullable<float> Constituent5MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_6_name")]
        public Generator_FuelSupply_Constituent6Name Constituent6Name { get; set; } = (Generator_FuelSupply_Constituent6Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent6Name), "Argon");
        

        [JsonProperty("constituent_6_molar_fraction")]
        public System.Nullable<float> Constituent6MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_7_name")]
        public Generator_FuelSupply_Constituent7Name Constituent7Name { get; set; } = (Generator_FuelSupply_Constituent7Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent7Name), "Butane");
        

        [JsonProperty("constituent_7_molar_fraction")]
        public System.Nullable<float> Constituent7MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_8_name")]
        public Generator_FuelSupply_Constituent8Name Constituent8Name { get; set; } = (Generator_FuelSupply_Constituent8Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent8Name), "Argon");
        

        [JsonProperty("constituent_8_molar_fraction")]
        public System.Nullable<float> Constituent8MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_9_name")]
        public Generator_FuelSupply_Constituent9Name Constituent9Name { get; set; } = (Generator_FuelSupply_Constituent9Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent9Name), "Argon");
        

        [JsonProperty("constituent_9_molar_fraction")]
        public System.Nullable<float> Constituent9MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_10_name")]
        public Generator_FuelSupply_Constituent10Name Constituent10Name { get; set; } = (Generator_FuelSupply_Constituent10Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent10Name), "Argon");
        

        [JsonProperty("constituent_10_molar_fraction")]
        public System.Nullable<float> Constituent10MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_11_name")]
        public Generator_FuelSupply_Constituent11Name Constituent11Name { get; set; } = (Generator_FuelSupply_Constituent11Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent11Name), "Argon");
        

        [JsonProperty("constituent_11_molar_fraction")]
        public System.Nullable<float> Constituent11MolarFraction { get; set; } = null;
        

        [JsonProperty("constituent_12_name")]
        public Generator_FuelSupply_Constituent12Name Constituent12Name { get; set; } = (Generator_FuelSupply_Constituent12Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent12Name), "Argon");
        

        [JsonProperty("constituent_12_molar_fraction")]
        public System.Nullable<float> Constituent12MolarFraction { get; set; } = null;
    }
}