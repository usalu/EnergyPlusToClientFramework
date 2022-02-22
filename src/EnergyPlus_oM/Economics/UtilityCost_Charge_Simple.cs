using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description(@"UtilityCost:Charge:Simple is one of the most often used objects for tariff calculation. It is used to compute energy and demand charges that are very simple. It may also be used for taxes, surcharges and any other charges that occur on a utility bill. Multiple UtilityCost:Charge:Simple objects may be defined for a single tariff and they will be added together.")]
    [JsonObject("UtilityCost:Charge:Simple")]
    public class UtilityCost_Charge_Simple : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"Charge Variable Name This is the name associated with the UtilityCost:Charge:Simple object and will appear in the report. In addition the results of the UtilityCost:Charge:Simple calculation are stored in a variable with the same name. That way the results may be used for further calculation. Spaces are not significant in Charge variable names. They are removed during the utility bill calculation process.")]
        [JsonProperty("utility_cost_charge_simple_name")]
        public string UtilityCostChargeSimpleName { get; set; } = "";
        

        [Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Charg" +
                     "e:Simple.")]
        [JsonProperty("tariff_name")]
        public string TariffName { get; set; } = "";
        

        [Description(@"The name of the source used by the UtilityCost:Charge:Simple. This is usually the name of the variable holding the energy or demand but may also be the name of any variable including the subtotal or basis if other charges are based on those. Typical values include totalEnergy totalDemand EnergyCharges DemandCharges ServiceCharges Basis Adjustments Surcharges Subtotal Taxes and Total. If it is a time-of-use rate then peakEnergy peakDemand shoulderEnergy shoulderDemand offPeakEnergy offPeakDemand midPeakEnergy and midPeakDemand. In addition see the Tariff Report to see other native variables that may be available. Also you can create additional user defined variables to model complex tariffs.")]
        [JsonProperty("source_variable")]
        public string SourceVariable { get; set; } = "";
        

        [Description("If this is set to annual the calculations are performed for the UtilityCost:Charg" +
                     "e:Simple for the entire year (all months) otherwise it is calculated only for th" +
                     "ose months in the season defined.")]
        [JsonProperty("season")]
        public UtilityCost_Charge_Simple_Season Season { get; set; } = (UtilityCost_Charge_Simple_Season)Enum.Parse(typeof(UtilityCost_Charge_Simple_Season), "Annual");
        

        [Description("This field shows where the charge should be added. The reason to enter this field" +
                     " appropriately is so that the charge gets reported in a reasonable category. The" +
                     " charge automatically gets added to the variable that is the category.")]
        [JsonProperty("category_variable_name")]
        public UtilityCost_Charge_Simple_CategoryVariableName CategoryVariableName { get; set; } = (UtilityCost_Charge_Simple_CategoryVariableName)Enum.Parse(typeof(UtilityCost_Charge_Simple_CategoryVariableName), "Adjustment");
        

        [Description(@"This field contains either a single number or the name of a variable. The number is multiplied with all of the energy or demand or other source that is specified in the source field. If a variable is used then the monthly values of the variable are multiplied against the variable specified in the source field. This field makes it easy to include a simple charge without specifying block sizes. This is a good way to include a tax or cost adjustment.")]
        [JsonProperty("cost_per_unit_value_or_variable_name")]
        public string CostPerUnitValueOrVariableName { get; set; } = "";
    }
}