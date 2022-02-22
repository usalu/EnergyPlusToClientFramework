using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description("Recurring costs are costs that repeat over time on a regular schedule during the " +
                 "study period. If costs associated with equipment do repeat but not on a regular " +
                 "schedule, use LifeCycleCost:NonrecurringCost objects instead.")]
    [JsonObject("LifeCycleCost:RecurringCosts")]
    public class LifeCycleCost_RecurringCosts : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("category")]
        public LifeCycleCost_RecurringCosts_Category Category { get; set; } = (LifeCycleCost_RecurringCosts_Category)Enum.Parse(typeof(LifeCycleCost_RecurringCosts_Category), "Maintenance");
        

        [Description("Enter the cost in dollars (or the appropriate monetary unit) for the recurring co" +
                     "sts. Enter the cost for each time it occurs. For example if the annual maintenan" +
                     "ce cost is 500 dollars enter 500 here.")]
        [JsonProperty("cost")]
        public System.Nullable<float> Cost { get; set; } = null;
        

        [Description("Enter when the costs start. The First Year of Cost is based on the number of year" +
                     "s past the Start of Costs. For most maintenance costs the Start of Costs should " +
                     "be Service Period.")]
        [JsonProperty("start_of_costs")]
        public LifeCycleCost_RecurringCosts_StartOfCosts StartOfCosts { get; set; } = (LifeCycleCost_RecurringCosts_StartOfCosts)Enum.Parse(typeof(LifeCycleCost_RecurringCosts_StartOfCosts), "ServicePeriod");
        

        [Description(@"This field and the Months From Start field together represent the time from either the start of the Service Period on the service month and year or start of the Base Period on the base month and year (depending on the Start of Costs field) that the costs start to occur. Only integers should be entered representing whole years.")]
        [JsonProperty("years_from_start")]
        public System.Nullable<float> YearsFromStart { get; set; } = null;
        

        [Description(@"This field and the Years From Start field together represent the time from either the start of the Service Period on the service month and year or start of the Base Period on the base month and year (depending on the Start of Costs field) that the costs start to occur. Only integers should be entered representing whole months. The Years From Start (times 12) and Months From Start are added together.")]
        [JsonProperty("months_from_start")]
        public System.Nullable<float> MonthsFromStart { get; set; } = null;
        

        [Description(@"This field and the Repeat Period Months field indicate how much time elapses between re-occurrences of the cost. For costs that occur every year such the Repeat Period Years should be 1 and Repeat Period Months should be 0. Only integers should be entered representing whole years.")]
        [JsonProperty("repeat_period_years")]
        public System.Nullable<float> RepeatPeriodYears { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This field and the Repeat Period Years field indicate how much time elapses betwe" +
                     "en re-occurrences of the cost. Only integers should be entered representing whol" +
                     "e years. The Repeat Period Years (times 12) and Repeat Period Months are added t" +
                     "ogether.")]
        [JsonProperty("repeat_period_months")]
        public System.Nullable<float> RepeatPeriodMonths { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the annual escalation rate as a decimal. For a 1% rate enter the value 0.01" +
                     ". This input is used when the Inflation Approach is CurrentDollar. When Inflatio" +
                     "n Approach is set to ConstantDollar this input is ignored.")]
        [JsonProperty("annual_escalation_rate")]
        public System.Nullable<float> AnnualEscalationRate { get; set; } = null;
    }
}