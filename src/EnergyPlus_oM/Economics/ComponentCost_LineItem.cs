using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description("Each instance of this object creates a cost line item and will contribute to the " +
                 "total for a cost estimate.")]
    [JsonObject("ComponentCost:LineItem")]
    public class ComponentCost_LineItem : BHoMObject
    {
        

        [JsonProperty("type")]
        public string Type { get; set; } = "";
        

        [Description("extend choice-keys as Cases are added to code")]
        [JsonProperty("line_item_type")]
        public EmptyNoYes LineItemType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("wildcard \"*\" is acceptable for some components")]
        [JsonProperty("item_name")]
        public string ItemName { get; set; } = "";
        

        [Description("not yet used")]
        [JsonProperty("object_end_use_key")]
        public string ObjectEndUseKey { get; set; } = "";
        

        [JsonProperty("cost_per_each")]
        public System.Nullable<float> CostPerEach { get; set; } = null;
        

        [JsonProperty("cost_per_area")]
        public System.Nullable<float> CostPerArea { get; set; } = null;
        

        [JsonProperty("cost_per_unit_of_output_capacity")]
        public System.Nullable<float> CostPerUnitOfOutputCapacity { get; set; } = null;
        

        [Description("The value is per change in COP.")]
        [JsonProperty("cost_per_unit_of_output_capacity_per_cop")]
        public System.Nullable<float> CostPerUnitOfOutputCapacityPerCop { get; set; } = null;
        

        [JsonProperty("cost_per_volume")]
        public System.Nullable<float> CostPerVolume { get; set; } = null;
        

        [JsonProperty("cost_per_volume_rate")]
        public System.Nullable<float> CostPerVolumeRate { get; set; } = null;
        

        [Description("as in for use with UA sizing of Coils")]
        [JsonProperty("cost_per_energy_per_temperature_difference")]
        public System.Nullable<float> CostPerEnergyPerTemperatureDifference { get; set; } = null;
        

        [Description("optional for use with Cost per Each and \"General\" object Type")]
        [JsonProperty("quantity")]
        public System.Nullable<float> Quantity { get; set; } = null;
    }
}