using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    [Description("This object sets up an EnergyPlus output variable from a Python Plugin variable")]
    [JsonObject("PythonPlugin:OutputVariable")]
    public class PythonPlugin_OutputVariable : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Must be listed in the PythonPlugin:Variables object")]
        [JsonProperty("python_plugin_variable_name")]
        public string PythonPluginVariableName { get; set; } = "";
        

        [Description("If Metered is selected, the variable is automatically set to a \"Summed\" type, and" +
                     " the Resource Type, Group Type, and End-Use Subcategory fields on this object ar" +
                     "e required")]
        [JsonProperty("type_of_data_in_variable")]
        public PythonPlugin_OutputVariable_TypeOfDataInVariable TypeOfDataInVariable { get; set; } = (PythonPlugin_OutputVariable_TypeOfDataInVariable)Enum.Parse(typeof(PythonPlugin_OutputVariable_TypeOfDataInVariable), "Averaged");
        

        [JsonProperty("update_frequency")]
        public PythonPlugin_OutputVariable_UpdateFrequency UpdateFrequency { get; set; } = (PythonPlugin_OutputVariable_UpdateFrequency)Enum.Parse(typeof(PythonPlugin_OutputVariable_UpdateFrequency), "SystemTimestep");
        

        [Description("optional but will result in dimensionless units for blank EnergyPlus units are st" +
                     "andard SI units")]
        [JsonProperty("units")]
        public string Units { get; set; } = "";
        

        [Description(@"This field is optional for regular output variables with ""Type of Data in Variable"" set to either Averaged or Summed. For Metered variables, this field is required. Choose the type of fuel, water, electricity, pollution or heat rate that should be metered.")]
        [JsonProperty("resource_type")]
        public PythonPlugin_OutputVariable_ResourceType ResourceType { get; set; } = (PythonPlugin_OutputVariable_ResourceType)Enum.Parse(typeof(PythonPlugin_OutputVariable_ResourceType), "Coal");
        

        [Description(@"This field is optional for regular output variables with ""Type of Data in Variable"" set to either Averaged or Summed. For Metered variables, this field is required. Choose a general classification, building (internal services), HVAC (air systems), or plant (hydronic systems), or system")]
        [JsonProperty("group_type")]
        public PythonPlugin_OutputVariable_GroupType GroupType { get; set; } = (PythonPlugin_OutputVariable_GroupType)Enum.Parse(typeof(PythonPlugin_OutputVariable_GroupType), "Building");
        

        [Description("This field is optional for regular output variables with \"Type of Data in Variabl" +
                     "e\" set to either Averaged or Summed. For Metered variables, this field is requir" +
                     "ed. Choose how the metered output should be classified for end-use category")]
        [JsonProperty("end_use_category")]
        public PythonPlugin_OutputVariable_EndUseCategory EndUseCategory { get; set; } = (PythonPlugin_OutputVariable_EndUseCategory)Enum.Parse(typeof(PythonPlugin_OutputVariable_EndUseCategory), "Baseboard");
        

        [Description(@"This field is always optional. For regular output variables with ""Type of Data in Variable"" set to either Averaged or Summed, this field is completely ignored. For Metered variables, this field is optional, but allows custom categorization of the end-uses in the ABUPS End Uses by Subcategory table. Enter a user-defined subcategory for this metered output")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = "";
    }
}