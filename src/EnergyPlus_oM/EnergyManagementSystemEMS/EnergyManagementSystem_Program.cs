using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("This input defines an Erl program Each field after the name is a line of EMS Runt" +
                 "ime Language")]
    [JsonObject("EnergyManagementSystem:Program")]
    public class EnergyManagementSystem_Program : BHoMObject
    {
        

        [JsonProperty("lines")]
        public string Lines { get; set; } = "";
    }
}