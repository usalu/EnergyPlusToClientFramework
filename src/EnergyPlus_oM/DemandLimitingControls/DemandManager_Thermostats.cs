using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    [Description("used for demand limiting ZoneControl:Thermostat objects.")]
    [JsonObject("DemandManager:Thermostats")]
    public class DemandManager_Thermostats : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("reset_control")]
        public EmptyNoYes ResetControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty("minimum_reset_duration")]
        public System.Nullable<float> MinimumResetDuration { get; set; } = null;
        

        [JsonProperty("maximum_heating_setpoint_reset")]
        public System.Nullable<float> MaximumHeatingSetpointReset { get; set; } = null;
        

        [JsonProperty("maximum_cooling_setpoint_reset")]
        public System.Nullable<float> MaximumCoolingSetpointReset { get; set; } = null;
        

        [Description("Not yet implemented")]
        [JsonProperty("reset_step_change")]
        public System.Nullable<float> ResetStepChange { get; set; } = null;
        

        [JsonProperty("selection_control")]
        public EmptyNoYes SelectionControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty("rotation_duration")]
        public System.Nullable<float> RotationDuration { get; set; } = null;
        

        [JsonProperty("thermostats")]
        public string Thermostats { get; set; } = "";
    }
}