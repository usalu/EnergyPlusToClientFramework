using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("The UCSD model for Displacement Ventilation")]
    public class RoomAirSettings_ThreeNodeDisplacementVentilation : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Name of Zone being described. Any existing zone name")]
        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Distribution of the convective heat gains between the occupied and mixed zones. 0" +
                     "<= Accepted Value <= 1. In the DV model 1 means all convective gains in the lowe" +
                     "r layer.")]
        [JsonProperty("gain_distribution_schedule_name")]
        public string GainDistributionScheduleName { get; set; } = "";
        

        [Description("Used only in the UCSD displacement ventilation model. Effective number of separat" +
                     "e plumes per occupant in the occupied zone. Plumes that merge together in the oc" +
                     "cupied zone count as one.")]
        [JsonProperty("number_of_plumes_per_occupant")]
        public System.Nullable<float> NumberOfPlumesPerOccupant { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Height of thermostat/temperature control sensor above floor")]
        [JsonProperty("thermostat_height")]
        public System.Nullable<float> ThermostatHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

        [Description("Height at which air temperature is calculated for comfort purposes")]
        [JsonProperty("comfort_height")]
        public System.Nullable<float> ComfortHeight { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

        [Description(@"Minimum temperature difference between predicted upper and lower layer temperatures above which DV auxiliary outputs are calculated. These outputs are 'DV Transition Height', 'DV Fraction Min Recommended Flow Rate' 'DV Average Temp Gradient' and 'DV Maximum Temp Gradient'. They are set to negative values when the temperature difference is less than the threshold and the output 'DV Zone Is Mixed' is set to 1")]
        [JsonProperty("temperature_difference_threshold_for_reporting")]
        public System.Nullable<float> TemperatureDifferenceThresholdForReporting { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
    }
}