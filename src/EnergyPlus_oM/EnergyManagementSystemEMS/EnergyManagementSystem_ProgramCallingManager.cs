using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("Input EMS program. a program needs a name a description of when it should be call" +
                 "ed and then lines of program code for EMS Runtime language")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_ProgramCallingManager : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("energyplus_model_calling_point")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint EnergyplusModelCallingPoint { get; set; } = (EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint)Enum.Parse(typeof(EnergyManagementSystem_ProgramCallingManager_EnergyplusModelCallingPoint), "AfterComponentInputReadIn");
        

        [JsonProperty("programs")]
        public string Programs { get; set; } = "";
    }
}