using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description("This object is used to describe zone air distribution in terms of air distributio" +
                 "n effectiveness and secondary recirculation fraction. It is referenced by Sizing" +
                 ":Zone and Controller:MechanicalVentilation objects")]
    [JsonObject("DesignSpecification:ZoneAirDistribution")]
    public class DesignSpecification_ZoneAirDistribution : BHoMObject
    {
        

        [JsonProperty("zone_air_distribution_effectiveness_in_cooling_mode")]
        public System.Nullable<float> ZoneAirDistributionEffectivenessInCoolingMode { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("zone_air_distribution_effectiveness_in_heating_mode")]
        public System.Nullable<float> ZoneAirDistributionEffectivenessInHeatingMode { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("optionally used to replace Zone Air Distribution Effectiveness in Cooling and Hea" +
                     "ting Mode")]
        [JsonProperty("zone_air_distribution_effectiveness_schedule_name")]
        public string ZoneAirDistributionEffectivenessScheduleName { get; set; } = "";
        

        [JsonProperty("zone_secondary_recirculation_fraction")]
        public System.Nullable<float> ZoneSecondaryRecirculationFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("minimum_zone_ventilation_efficiency")]
        public System.Nullable<float> MinimumZoneVentilationEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
}