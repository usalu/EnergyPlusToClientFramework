using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("This object sets up an EnergyPlus output variable from an Erl variable")]
    [JsonObject("EnergyManagementSystem:OutputVariable")]
    public class EnergyManagementSystem_OutputVariable : BHoMObject, IEnergyPlusClass
    {
        

        [Description("must be an acceptable EMS variable")]
        [JsonProperty("ems_variable_name")]
        public string EmsVariableName { get; set; } = "";
        

        [JsonProperty("type_of_data_in_variable")]
        public EnergyManagementSystem_OutputVariable_TypeOfDataInVariable TypeOfDataInVariable { get; set; } = (EnergyManagementSystem_OutputVariable_TypeOfDataInVariable)Enum.Parse(typeof(EnergyManagementSystem_OutputVariable_TypeOfDataInVariable), "Averaged");
        

        [JsonProperty("update_frequency")]
        public EnergyManagementSystem_OutputVariable_UpdateFrequency UpdateFrequency { get; set; } = (EnergyManagementSystem_OutputVariable_UpdateFrequency)Enum.Parse(typeof(EnergyManagementSystem_OutputVariable_UpdateFrequency), "SystemTimestep");
        

        [Description("optional for global scope variables, required for local scope variables")]
        [JsonProperty("ems_program_or_subroutine_name")]
        public string EmsProgramOrSubroutineName { get; set; } = "";
        

        [Description("optional but will result in dimensionless units for blank EnergyPlus units are st" +
                     "andard SI units")]
        [JsonProperty("units")]
        public string Units { get; set; } = "";
    }
}