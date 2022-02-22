using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("A ExternalInterface:Schedule contains only one value, which is used during the wa" +
                 "rm-up period and the system sizing.")]
    [JsonObject("ExternalInterface:Schedule")]
    public class ExternalInterface_Schedule : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("schedule_type_limits_name")]
        public string ScheduleTypeLimitsName { get; set; } = "";
        

        [Description("Used during warm-up and system sizing.")]
        [JsonProperty("initial_value")]
        public System.Nullable<float> InitialValue { get; set; } = null;
    }
}