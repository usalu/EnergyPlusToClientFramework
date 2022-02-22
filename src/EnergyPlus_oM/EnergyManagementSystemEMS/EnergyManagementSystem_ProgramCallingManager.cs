using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("Input EMS program. a program needs a name a description of when it should be call" +
                 "ed and then lines of program code for EMS Runtime language")]
    [JsonObject("EnergyManagementSystem:ProgramCallingManager")]
    public class EnergyManagementSystem_ProgramCallingManager : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("energyplus_model_calling_point")]
        public EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint EnergyplusModelCallingPoint { get; set; } = (EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint)Enum.Parse(typeof(EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint), "AfterComponentInputReadIn");
        

        [JsonProperty("programs")]
        public string Programs { get; set; } = "";
    }
}