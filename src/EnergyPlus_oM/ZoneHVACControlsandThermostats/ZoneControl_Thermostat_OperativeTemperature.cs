using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("This object can be used with the ZoneList option on a thermostat or with one of t" +
                 "he zones on that list (but you won\'t be able to use the object list to pick only" +
                 " one of those zones. Thermostat names are <Zone Name> <global Thermostat name> i" +
                 "nternally.")]
    [JsonObject("ZoneControl:Thermostat:OperativeTemperature")]
    public class ZoneControl_Thermostat_OperativeTemperature : BHoMObject
    {
        

        [Description("Enter the name of a ZoneControl:Thermostat object. This object modifies a ZoneCon" +
                     "trol:Thermostat object to add a radiative fraction.")]
        [JsonProperty("thermostat_name")]
        public string ThermostatName { get; set; } = "";
        

        [JsonProperty("radiative_fraction_input_mode")]
        public EmptyNoYes RadiativeFractionInputMode { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [JsonProperty("fixed_radiative_fraction")]
        public System.Nullable<float> FixedRadiativeFraction { get; set; } = null;
        

        [Description("Schedule values of 0.0 indicate no operative temperature control")]
        [JsonProperty("radiative_fraction_schedule_name")]
        public string RadiativeFractionScheduleName { get; set; } = "";
        

        [Description("the cooling setpoint temperature schedule of the referenced thermostat will be ad" +
                     "justed based on the selected adaptive comfort model type")]
        [JsonProperty("adaptive_comfort_model_type")]
        public EmptyNoYes AdaptiveComfortModelType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
    }
}