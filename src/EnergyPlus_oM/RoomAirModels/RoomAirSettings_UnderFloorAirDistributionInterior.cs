using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description(@"This Room Air Model is applicable to interior spaces that are served by an underfloor air distribution system. The dominant sources of heat gain should be from people, equipment, and other localized sources located in the occupied part of the room. The model should be used with caution in zones which have large heat gains or losses through exterior walls or windows or which have considerable direct solar gain. Used with RoomAirModelType = UnderFloorAirDistributionInterior.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_UnderFloorAirDistributionInterior : BHoMObject
    {
        

        [Description("Name of Zone with underfloor air distribution")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Total number of diffusers in this zone")]
        [JsonProperty("number_of_diffusers")]
        public string NumberOfDiffusers { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("power_per_plume")]
        public string PowerPerPlume { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("design_effective_area_of_diffuser")]
        public string DesignEffectiveAreaOfDiffuser { get; set; } = (System.String)"Autocalculate";
        

        [JsonProperty("diffuser_slot_angle_from_vertical")]
        public string DiffuserSlotAngleFromVertical { get; set; } = (System.String)"Autocalculate";
        

        [Description("Height of thermostat/temperature control sensor above floor")]
        [JsonProperty("thermostat_height")]
        public System.Nullable<float> ThermostatHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.2", CultureInfo.InvariantCulture);
        

        [Description("Height at which air temperature is calculated for comfort purposes")]
        [JsonProperty("comfort_height")]
        public System.Nullable<float> ComfortHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

        [Description(@"Minimum temperature difference between predicted upper and lower layer temperatures above which UFAD auxiliary outputs are calculated. These outputs are 'UF Transition Height' and 'UF Average Temp Gradient'. They are set to zero values when the temperature difference is less than the threshold and the output 'UF Zone Is Mixed' is set to 1")]
        [JsonProperty("temperature_difference_threshold_for_reporting")]
        public System.Nullable<float> TemperatureDifferenceThresholdForReporting { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty("floor_diffuser_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoomAirSettings_UnderFloorAirDistributionInterior_FloorDiffuserType FloorDiffuserType { get; set; } = (RoomAirSettings_UnderFloorAirDistributionInterior_FloorDiffuserType)Enum.Parse(typeof(RoomAirSettings_UnderFloorAirDistributionInterior_FloorDiffuserType), "Swirl");
        

        [Description("user-specified height above floor of boundary between occupied and upper subzones" +
                     "")]
        [JsonProperty("transition_height")]
        public string TransitionHeight { get; set; } = (System.String)"1.7";
        

        [Description("Coefficient A in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
                     "ction of the total zone load attributable to the lower subzone")]
        [JsonProperty("coefficient_a")]
        public string CoefficientA { get; set; } = (System.String)"Autocalculate";
        

        [Description("Coefficient B in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
                     "ction of the total zone load attributable to the lower subzone")]
        [JsonProperty("coefficient_b")]
        public string CoefficientB { get; set; } = (System.String)"Autocalculate";
        

        [Description("Coefficient C in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
                     "ction of the total zone load attributable to the lower subzone")]
        [JsonProperty("coefficient_c")]
        public string CoefficientC { get; set; } = (System.String)"Autocalculate";
        

        [Description("Coefficient D in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
                     "ction of the total zone load attributable to the lower subzone")]
        [JsonProperty("coefficient_d")]
        public string CoefficientD { get; set; } = (System.String)"Autocalculate";
        

        [Description("Coefficient E in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
                     "ction of the total zone load attributable to the lower subzone")]
        [JsonProperty("coefficient_e")]
        public string CoefficientE { get; set; } = (System.String)"Autocalculate";
    }
}