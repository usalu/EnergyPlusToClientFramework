using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("depending on zone and outdoor conditions overrides fan schedule to do precooling " +
                 "with outdoor air")]
    [JsonObject("AvailabilityManager:NightVentilation")]
    public class AvailabilityManager_NightVentilation : BHoMObject
    {
        

        [JsonProperty("applicability_schedule_name")]
        public string ApplicabilityScheduleName { get; set; } = "";
        

        [JsonProperty("fan_schedule_name")]
        public string FanScheduleName { get; set; } = "";
        

        [Description("One zone temperature must be above this scheduled temperature for night ventilati" +
                     "on to be enabled")]
        [JsonProperty("ventilation_temperature_schedule_name")]
        public string VentilationTemperatureScheduleName { get; set; } = "";
        

        [Description("The outdoor air temperature minus the control zone temperature must be greater th" +
                     "an the ventilation delta T")]
        [JsonProperty("ventilation_temperature_difference")]
        public System.Nullable<float> VentilationTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Night ventilation is disabled if any conditioned zone served by the system falls " +
                     "below this temperature")]
        [JsonProperty("ventilation_temperature_low_limit")]
        public System.Nullable<float> VentilationTemperatureLowLimit { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

        [Description("the fraction (could be > 1) of the design system Flow Rate at which night ventila" +
                     "tion will be done")]
        [JsonProperty("night_venting_flow_fraction")]
        public System.Nullable<float> NightVentingFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("When AvailabilityManager:NightVentilation is used in the zone component availabil" +
                     "ity manager assignment list, the Control Zone Name should be the name of the zon" +
                     "e in which the zone component is.")]
        [JsonProperty("control_zone_name")]
        public string ControlZoneName { get; set; } = "";
    }
}