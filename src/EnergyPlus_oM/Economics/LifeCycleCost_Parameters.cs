using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description(@"Provides inputs related to the overall life-cycle analysis. It establishes many of the assumptions used in computing the present value. It is important that when comparing the results of multiple simulations that the fields in the LifeCycleCost:Parameters objects are the same for all the simulations. When this object is present the tabular report file will contain the Life-Cycle Cost Report.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class LifeCycleCost_Parameters : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("The field specifies if the discounting of future costs should be computed as occu" +
                     "rring at the end of each year or the middle of each year or the beginning of eac" +
                     "h year. The most common discounting convention uses the end of each year.")]
        [JsonProperty("discounting_convention")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LifeCycleCost_Parameters_DiscountingConvention DiscountingConvention { get; set; } = (LifeCycleCost_Parameters_DiscountingConvention)Enum.Parse(typeof(LifeCycleCost_Parameters_DiscountingConvention), "EndOfYear");
        

        [Description(@"This field is used to determine if the analysis should use constant dollars or current dollars which is related to how inflation is treated. If ConstantDollar is selected then the Real Discount Rate input is used and it excludes the rate of inflation. If CurrentDollar is selected then the Nominal Discount Rate input is used and it includes the rate of inflation.")]
        [JsonProperty("inflation_approach")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LifeCycleCost_Parameters_InflationApproach InflationApproach { get; set; } = (LifeCycleCost_Parameters_InflationApproach)Enum.Parse(typeof(LifeCycleCost_Parameters_InflationApproach), "ConstantDollar");
        

        [Description(@"Enter the real discount rate as a decimal. For a 3% rate enter the value 0.03. This input is used when the Inflation Approach is ConstantDollar. The real discount rate reflects the interest rates needed to make current and future expenditures have comparable equivalent values when general inflation is ignored. When Inflation Approach is set to CurrentDollar this input is ignored.")]
        [JsonProperty("real_discount_rate")]
        public System.Nullable<float> RealDiscountRate { get; set; } = null;
        

        [Description(@"Enter the nominal discount rate as a decimal. For a 5% rate enter the value 0.05. This input is used when the Inflation Approach is CurrentDollar. The real discount rate reflects the interest rates needed to make current and future expenditures have comparable equivalent values when general inflation is included. When Inflation Approach is set to ConstantDollar this input is ignored.")]
        [JsonProperty("nominal_discount_rate")]
        public System.Nullable<float> NominalDiscountRate { get; set; } = null;
        

        [Description("Enter the rate of inflation for general goods and services as a decimal. For a 2%" +
                     " rate enter the value 0.02.")]
        [JsonProperty("inflation")]
        public System.Nullable<float> Inflation { get; set; } = null;
        

        [Description("Enter the month that is the beginning of study period also known as the beginning" +
                     " of the base period.")]
        [JsonProperty("base_date_month")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LifeCycleCost_Parameters_BaseDateMonth BaseDateMonth { get; set; } = (LifeCycleCost_Parameters_BaseDateMonth)Enum.Parse(typeof(LifeCycleCost_Parameters_BaseDateMonth), "January");
        

        [Description("Enter the four digit year that is the beginning of study period such as 2010. The" +
                     " study period is also known as the base period.")]
        [JsonProperty("base_date_year")]
        public System.Nullable<float> BaseDateYear { get; set; } = null;
        

        [Description(@"Enter the month that is the beginning of building occupancy. Energy costs computed by EnergyPlus are assumed to occur during the year following the service date. The service date must be the same or later than the Base Date. This field could also be referred to as part of beneficial occupancy date.")]
        [JsonProperty("service_date_month")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LifeCycleCost_Parameters_ServiceDateMonth ServiceDateMonth { get; set; } = (LifeCycleCost_Parameters_ServiceDateMonth)Enum.Parse(typeof(LifeCycleCost_Parameters_ServiceDateMonth), "January");
        

        [Description("Enter the four digit year that is the beginning of occupancy such as 2010.")]
        [JsonProperty("service_date_year")]
        public System.Nullable<float> ServiceDateYear { get; set; } = null;
        

        [Description("Enter the number of years of the study period. It is the number of years that the" +
                     " study continues based on the start at the base date. The default value is 25 ye" +
                     "ars. Only integers may be used indicating whole years.")]
        [JsonProperty("length_of_study_period_in_years")]
        public System.Nullable<float> LengthOfStudyPeriodInYears { get; set; } = null;
        

        [Description(@"Enter the overall marginal tax rate for the project costs. This does not include energy or water taxes. The tax rate entered should be based on the marginal tax rate for the entity and not the average tax rate. Enter the tax rate results in present value calculations after taxes. Most analyses do not factor in the impact of taxes and assume that all options under consideration have roughly the same tax impact. Due to this many times the tax rate can be left to default to zero and the present value results before taxes are used to make decisions. The value should be entered as a decimal value. For 15% enter 0.15. For an analysis that does not include tax impacts enter 0.0.")]
        [JsonProperty("tax_rate")]
        public System.Nullable<float> TaxRate { get; set; } = null;
        

        [Description("For an analysis that includes income tax impacts this entry describes how capital" +
                     " costs are depreciated. Only one depreciation method may be used for an analysis" +
                     " and is applied to all capital expenditures.")]
        [JsonProperty("depreciation_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LifeCycleCost_Parameters_DepreciationMethod DepreciationMethod { get; set; } = (LifeCycleCost_Parameters_DepreciationMethod)Enum.Parse(typeof(LifeCycleCost_Parameters_DepreciationMethod), "None");
    }
}