using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("Determines the availability of a loop or system: only controls the turn on action" +
                 ". Schedule overrides fan/pump schedule.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AvailabilityManager_ScheduledOn : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
    }
}