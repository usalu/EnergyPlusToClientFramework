using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("Compact definition for Schedule:Day:List")]
    public class Schedule_Week_Compact : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("data")]
        public string Data { get; set; } = "";
    }
}