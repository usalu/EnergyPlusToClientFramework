using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description(@"Applicable to exterior spaces that are served by an underfloor air distribution system. The dominant sources of heat gain should be from people, equipment, and other localized sources located in the occupied part of the room, as well as convective gain coming from a warm window. Used with RoomAirModelType = CrossVentilation.")]
    public class RoomAirSettings_UnderFloorAirDistributionExterior : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Name of Zone being described. Any existing zone name")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("number_of_diffusers_per_zone")]
        public string NumberOfDiffusersPerZone { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("power_per_plume")]
        public string PowerPerPlume { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("design_effective_area_of_diffuser")]
        public string DesignEffectiveAreaOfDiffuser { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("diffuser_slot_angle_from_vertical")]
        public string DiffuserSlotAngleFromVertical { get; set; } = (System.String)"Autocalculate";
        

        [Description("Height of thermostat/temperature control sensor above floor")]
        [JsonProperty("thermostat_height")]
        public System.Nullable<float> ThermostatHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.2", CultureInfo.InvariantCulture);
        

        [Description("Height at which Air temperature is calculated for comfort purposes")]
        [JsonProperty("comfort_height")]
        public System.Nullable<float> ComfortHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

        [Description(@"Minimum temperature difference between upper and lower layer temperatures above which UFAD auxiliary outputs are calculated. These outputs are 'UF Transition Height' and 'UF Average Temp Gradient'. They are set to zero values when the temperature difference is less than the threshold and the output 'UF Zone Is Mixed' is set to 1")]
        [JsonProperty("temperature_difference_threshold_for_reporting")]
        public System.Nullable<float> TemperatureDifferenceThresholdForReporting { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("floor_diffuser_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoomAirSettings_UnderFloorAirDistributionExterior_FloorDiffuserType FloorDiffuserType { get; set; } = (RoomAirSettings_UnderFloorAirDistributionExterior_FloorDiffuserType)Enum.Parse(typeof(RoomAirSettings_UnderFloorAirDistributionExterior_FloorDiffuserType), "Swirl");
        

        [Description("User-specified height above floor of boundary between occupied and upper subzones" +
                     "")]
        [JsonProperty("transition_height")]
        public string TransitionHeight { get; set; } = (System.String)"1.7";
        

        [Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
        [JsonProperty("coefficient_a_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2")]
        public string CoefficientAInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = (System.String)"Autocalculate";
        

        [Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
        [JsonProperty("coefficient_b_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2")]
        public string CoefficientBInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = (System.String)"Autocalculate";
        

        [Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
        [JsonProperty("coefficient_c_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2")]
        public string CoefficientCInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = (System.String)"Autocalculate";
        

        [Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
        [JsonProperty("coefficient_d_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2")]
        public string CoefficientDInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = (System.String)"Autocalculate";
        

        [Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
        [JsonProperty("coefficient_e_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2")]
        public string CoefficientEInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = (System.String)"Autocalculate";
    }
}