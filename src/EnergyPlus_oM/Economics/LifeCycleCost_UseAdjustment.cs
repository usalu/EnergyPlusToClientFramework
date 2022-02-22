using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description(@"Used by advanced users to adjust the energy or water use costs for future years. This should not be used for compensating for inflation but should only be used to increase the costs of energy or water based on assumed changes to the actual usage, such as anticipated changes in the future function of the building. The adjustments begin at the start of the service period.")]
    public class LifeCycleCost_UseAdjustment : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("resource")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LifeCycleCost_UseAdjustment_Resource Resource { get; set; } = (LifeCycleCost_UseAdjustment_Resource)Enum.Parse(typeof(LifeCycleCost_UseAdjustment_Resource), "Coal");
        

        [JsonProperty("multipliers")]
        public string Multipliers { get; set; } = "";
    }
}