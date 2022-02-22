using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("This object sets up an EnergyPlus output variable from an Erl variable")]
    [JsonObject("EnergyManagementSystem:MeteredOutputVariable")]
    public class EnergyManagementSystem_MeteredOutputVariable : BHoMObject, IEnergyPlusClass
    {
        

        [Description("must be an acceptable EMS variable, no spaces")]
        [JsonProperty("ems_variable_name")]
        public string EmsVariableName { get; set; } = "";
        

        [JsonProperty("update_frequency")]
        public EnergyManagementSystem_MeteredOutputVariable_UpdateFrequency UpdateFrequency { get; set; } = (EnergyManagementSystem_MeteredOutputVariable_UpdateFrequency)Enum.Parse(typeof(EnergyManagementSystem_MeteredOutputVariable_UpdateFrequency), "SystemTimestep");
        

        [Description("optional for global scope variables, required for local scope variables")]
        [JsonProperty("ems_program_or_subroutine_name")]
        public string EmsProgramOrSubroutineName { get; set; } = "";
        

        [Description("choose the type of fuel, water, electricity, pollution or heat rate that should b" +
                     "e metered.")]
        [JsonProperty("resource_type")]
        public EnergyManagementSystem_MeteredOutputVariable_ResourceType ResourceType { get; set; } = (EnergyManagementSystem_MeteredOutputVariable_ResourceType)Enum.Parse(typeof(EnergyManagementSystem_MeteredOutputVariable_ResourceType), "Coal");
        

        [Description("choose a general classification, building (internal services), HVAC (air systems)" +
                     ", or plant (hydronic systems), or system")]
        [JsonProperty("group_type")]
        public EnergyManagementSystem_MeteredOutputVariable_GroupType GroupType { get; set; } = (EnergyManagementSystem_MeteredOutputVariable_GroupType)Enum.Parse(typeof(EnergyManagementSystem_MeteredOutputVariable_GroupType), "Building");
        

        [Description("choose how the metered output should be classified for end-use category")]
        [JsonProperty("end_use_category")]
        public EnergyManagementSystem_MeteredOutputVariable_EndUseCategory EndUseCategory { get; set; } = (EnergyManagementSystem_MeteredOutputVariable_EndUseCategory)Enum.Parse(typeof(EnergyManagementSystem_MeteredOutputVariable_EndUseCategory), "Baseboard");
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table. enter a user-defined subcategory for this metered output")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = "";
        

        [Description("optional but will result in dimensionless units for blank EnergyPlus units are st" +
                     "andard SI units")]
        [JsonProperty("units")]
        public string Units { get; set; } = "";
    }
}