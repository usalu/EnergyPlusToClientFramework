using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    [Description("used for demand limiting ElectricEquipment objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DemandManager_ElectricEquipment : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("limit_control")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DemandManager_ElectricEquipment_LimitControl LimitControl { get; set; } = (DemandManager_ElectricEquipment_LimitControl)Enum.Parse(typeof(DemandManager_ElectricEquipment_LimitControl), "Fixed");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty("minimum_limit_duration")]
        public System.Nullable<float> MinimumLimitDuration { get; set; } = null;
        

        [JsonProperty("maximum_limit_fraction")]
        public System.Nullable<float> MaximumLimitFraction { get; set; } = null;
        

        [Description("Not yet implemented")]
        [JsonProperty("limit_step_change")]
        public System.Nullable<float> LimitStepChange { get; set; } = null;
        

        [JsonProperty("selection_control")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DemandManager_ElectricEquipment_SelectionControl SelectionControl { get; set; } = (DemandManager_ElectricEquipment_SelectionControl)Enum.Parse(typeof(DemandManager_ElectricEquipment_SelectionControl), "All");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty("rotation_duration")]
        public System.Nullable<float> RotationDuration { get; set; } = null;
        

        [JsonProperty("equipment")]
        public string Equipment { get; set; } = "";
    }
}