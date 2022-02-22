using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("Determines the availability of a loop or system: only controls the turn off actio" +
                 "n. Schedule overrides fan/pump schedule.")]
    public class AvailabilityManager_ScheduledOff : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
    }
}