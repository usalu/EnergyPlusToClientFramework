using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    [Description("used for demand limiting Exterior:Lights objects.")]
    [JsonObject("DemandManager:ExteriorLights")]
    public class DemandManager_ExteriorLights : BHoMObject
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("limit_control")]
        public EmptyNoYes LimitControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty("minimum_limit_duration")]
        public System.Nullable<float> MinimumLimitDuration { get; set; } = null;
        

        [JsonProperty("maximum_limit_fraction")]
        public System.Nullable<float> MaximumLimitFraction { get; set; } = null;
        

        [Description("Not yet implemented")]
        [JsonProperty("limit_step_change")]
        public System.Nullable<float> LimitStepChange { get; set; } = null;
        

        [JsonProperty("selection_control")]
        public EmptyNoYes SelectionControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty("rotation_duration")]
        public System.Nullable<float> RotationDuration { get; set; } = null;
        

        [JsonProperty("lights")]
        public string Lights { get; set; } = "";
    }
}