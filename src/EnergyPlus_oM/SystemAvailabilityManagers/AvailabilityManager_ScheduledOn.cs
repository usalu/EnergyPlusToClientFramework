using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("Determines the availability of a loop or system: only controls the turn on action" +
                 ". Schedule overrides fan/pump schedule.")]
    public class AvailabilityManager_ScheduledOn : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
    }
}