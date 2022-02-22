using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    [Description("used for demand limiting Controller:OutdoorAir objects.")]
    [JsonObject("DemandManager:Ventilation")]
    public class DemandManager_Ventilation : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this demand manager. Schedule value > 0 means the " +
                     "demand manager is available. If this field is blank, the DR is always available." +
                     "")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("limit_control")]
        public DemandManager_Ventilation_LimitControl LimitControl { get; set; } = (DemandManager_Ventilation_LimitControl)Enum.Parse(typeof(DemandManager_Ventilation_LimitControl), "FixedRate");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty("minimum_limit_duration")]
        public System.Nullable<float> MinimumLimitDuration { get; set; } = null;
        

        [Description("Used in case when Limit strategy is set to FixedRate")]
        [JsonProperty("fixed_rate")]
        public System.Nullable<float> FixedRate { get; set; } = null;
        

        [Description("Used in case when Limit Control is set to ReductionRatio")]
        [JsonProperty("reduction_ratio")]
        public System.Nullable<float> ReductionRatio { get; set; } = null;
        

        [Description("Not yet implemented")]
        [JsonProperty("limit_step_change")]
        public System.Nullable<float> LimitStepChange { get; set; } = null;
        

        [JsonProperty("selection_control")]
        public DemandManager_Ventilation_SelectionControl SelectionControl { get; set; } = (DemandManager_Ventilation_SelectionControl)Enum.Parse(typeof(DemandManager_Ventilation_SelectionControl), "All");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty("rotation_duration")]
        public System.Nullable<float> RotationDuration { get; set; } = null;
        

        [JsonProperty("controllers")]
        public string Controllers { get; set; } = "";
    }
}