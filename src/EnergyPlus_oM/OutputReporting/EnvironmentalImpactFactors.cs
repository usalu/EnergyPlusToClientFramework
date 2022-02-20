using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Used to help convert district and ideal energy use to a fuel type and provide tot" +
                 "al carbon equivalent with coefficients Also used in Source=>Site conversions.")]
    [JsonObject("EnvironmentalImpactFactors")]
    public class EnvironmentalImpactFactors : BHoMObject
    {
        

        [Description("District heating efficiency used when converted to natural gas")]
        [JsonProperty("district_heating_efficiency")]
        public System.Nullable<float> DistrictHeatingEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

        [Description("District cooling COP used when converted to electricity")]
        [JsonProperty("district_cooling_cop")]
        public System.Nullable<float> DistrictCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Steam conversion efficiency used to convert steam usage to natural gas")]
        [JsonProperty("steam_conversion_efficiency")]
        public System.Nullable<float> SteamConversionEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

        [JsonProperty("total_carbon_equivalent_emission_factor_from_n2o")]
        public System.Nullable<float> TotalCarbonEquivalentEmissionFactorFromN2o { get; set; } = (System.Nullable<float>)Single.Parse("80.7272", CultureInfo.InvariantCulture);
        

        [JsonProperty("total_carbon_equivalent_emission_factor_from_ch4")]
        public System.Nullable<float> TotalCarbonEquivalentEmissionFactorFromCh4 { get; set; } = (System.Nullable<float>)Single.Parse("6.2727", CultureInfo.InvariantCulture);
        

        [JsonProperty("total_carbon_equivalent_emission_factor_from_co2")]
        public System.Nullable<float> TotalCarbonEquivalentEmissionFactorFromCo2 { get; set; } = (System.Nullable<float>)Single.Parse("0.2727", CultureInfo.InvariantCulture);
    }
}