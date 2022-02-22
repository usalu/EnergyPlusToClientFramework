using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description("Used to perform various modifications to the construction costs to arrive at an e" +
                 "stimate for total project costs. This object allows extending the line item mode" +
                 "l so that the overall costs of the project will reflect various profit and fees." +
                 "")]
    [JsonObject("ComponentCost:Adjustments")]
    public class ComponentCost_Adjustments : BHoMObject, IEnergyPlusClass
    {
        

        [Description("based on conditioned floor area for cost not accounted for in current line item c" +
                     "ost model")]
        [JsonProperty("miscellaneous_cost_per_conditioned_area")]
        public System.Nullable<float> MiscellaneousCostPerConditionedArea { get; set; } = null;
        

        [JsonProperty("design_and_engineering_fees")]
        public System.Nullable<float> DesignAndEngineeringFees { get; set; } = null;
        

        [JsonProperty("contractor_fee")]
        public System.Nullable<float> ContractorFee { get; set; } = null;
        

        [JsonProperty("contingency")]
        public System.Nullable<float> Contingency { get; set; } = null;
        

        [JsonProperty("permits_bonding_and_insurance")]
        public System.Nullable<float> PermitsBondingAndInsurance { get; set; } = null;
        

        [JsonProperty("commissioning_fee")]
        public System.Nullable<float> CommissioningFee { get; set; } = null;
        

        [Description("for use with average data in line item and Misc cost models")]
        [JsonProperty("regional_adjustment_factor")]
        public System.Nullable<float> RegionalAdjustmentFactor { get; set; } = null;
    }
}