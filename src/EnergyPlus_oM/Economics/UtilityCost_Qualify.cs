using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description(@"The qualify object allows only tariffs to be selected based on limits which may apply such as maximum or minimum demand requirements. If the results of the simulation fall outside of the range of qualifications, that tariff is still calculated but the ""Qualified"" entry will say ""No"" and the UtilityCost:Qualify that caused its exclusion is shown. Multiple UtilityCost:Qualify objects can appear for the same tariff and they can be based on any variable.")]
    [JsonObject("UtilityCost:Qualify")]
    public class UtilityCost_Qualify : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Displayed in the report if the tariff does not qualify")]
        [JsonProperty("utility_cost_qualify_name")]
        public string UtilityCostQualifyName { get; set; } = "";
        

        [Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Quali" +
                     "fy.")]
        [JsonProperty("tariff_name")]
        public string TariffName { get; set; } = "";
        

        [Description("The name of the variable used. For energy and demand the automatically created va" +
                     "riables totalEnergy and totalDemand should be used respectively.")]
        [JsonProperty("variable_name")]
        public string VariableName { get; set; } = "";
        

        [JsonProperty("qualify_type")]
        public UtilityCost_Qualify_QualifyType QualifyType { get; set; } = (UtilityCost_Qualify_QualifyType)Enum.Parse(typeof(UtilityCost_Qualify_QualifyType), "Maximum");
        

        [Description(@"The minimum or maximum value for the qualify. If the variable has values that are less than this value when the qualify type is minimum then the tariff may be disqualified. If the variable has values that are greater than this value when the qualify type is maximum then the tariff may be disqualified.")]
        [JsonProperty("threshold_value_or_variable_name")]
        public string ThresholdValueOrVariableName { get; set; } = "";
        

        [Description("If the UtilityCost:Qualify only applies to a season enter the season name. If thi" +
                     "s field is left blank it defaults to Annual.")]
        [JsonProperty("season")]
        public UtilityCost_Qualify_Season Season { get; set; } = (UtilityCost_Qualify_Season)Enum.Parse(typeof(UtilityCost_Qualify_Season), "Annual");
        

        [Description(@"Uses the number in Number of Months in one of two different ways depending on the Threshold  Test. If the Threshold Test is set to Count then the qualification is based on the count of the total number of months per year. If the Threshold Test is set to consecutive then the qualification is based on a consecutive number of months.")]
        [JsonProperty("threshold_test")]
        public UtilityCost_Qualify_ThresholdTest ThresholdTest { get; set; } = (UtilityCost_Qualify_ThresholdTest)Enum.Parse(typeof(UtilityCost_Qualify_ThresholdTest), "Consecutive");
        

        [Description(@"A number from 1 to 12. If no value entered 12 is assumed when the qualify type is minimum and 1 when the qualify type is maximum. This is the number of months that the threshold test applies to determine if the rate qualifies or not. If the season is less than 12 months (if it is not annual) then the value is automatically reduced to the number of months of the season.")]
        [JsonProperty("number_of_months")]
        public System.Nullable<float> NumberOfMonths { get; set; } = null;
    }
}