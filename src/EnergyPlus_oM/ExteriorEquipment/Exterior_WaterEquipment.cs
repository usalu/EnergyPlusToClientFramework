using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExteriorEquipment
{
    [Description("only used for Meter type reporting, does not affect building loads")]
    [JsonObject("Exterior:WaterEquipment")]
    public class Exterior_WaterEquipment : BHoMObject
    {
        

        [JsonProperty("fuel_use_type")]
        public EmptyNoYes FuelUseType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Water");
        

        [Description("units in Schedule should be fraction applied to capacity of the exterior water eq" +
                     "uipment, generally (0.0 - 1.0)")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [JsonProperty("design_level")]
        public System.Nullable<float> DesignLevel { get; set; } = null;
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}