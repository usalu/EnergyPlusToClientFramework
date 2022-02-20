using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("Determines the availability of a loop or system: whether it is on or off. Dependi" +
                 "ng on zone temperatures, overrides Schedules and forces system Fans on.")]
    [JsonObject("AvailabilityManager:NightCycle")]
    public class AvailabilityManager_NightCycle : BHoMObject
    {
        

        [JsonProperty("applicability_schedule_name")]
        public string ApplicabilityScheduleName { get; set; } = "";
        

        [JsonProperty("fan_schedule_name")]
        public string FanScheduleName { get; set; } = "";
        

        [Description("When AvailabilityManager:NightCycle is used in the zone component availability ma" +
                     "nager assignment list, the key choices for Control Type would only be StayOff an" +
                     "d CycleOnControlZone")]
        [JsonProperty("control_type")]
        public EmptyNoYes ControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "StayOff");
        

        [JsonProperty("thermostat_tolerance")]
        public System.Nullable<float> ThermostatTolerance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("cycling_run_time_control_type")]
        public EmptyNoYes CyclingRunTimeControlType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "FixedRunTime");
        

        [JsonProperty("cycling_run_time")]
        public System.Nullable<float> CyclingRunTime { get; set; } = (System.Nullable<float>)Single.Parse("3600", CultureInfo.InvariantCulture);
        

        [Description("When AvailabilityManager:NightCycle is used in the zone component availability ma" +
                     "nager assignment list, the Control Zone Name should be the name of the zone in w" +
                     "hich the zone component is.")]
        [JsonProperty("control_zone_or_zone_list_name")]
        public string ControlZoneOrZoneListName { get; set; } = "";
        

        [JsonProperty("cooling_control_zone_or_zone_list_name")]
        public string CoolingControlZoneOrZoneListName { get; set; } = "";
        

        [JsonProperty("heating_control_zone_or_zone_list_name")]
        public string HeatingControlZoneOrZoneListName { get; set; } = "";
        

        [JsonProperty("heating_zone_fans_only_zone_or_zone_list_name")]
        public string HeatingZoneFansOnlyZoneOrZoneListName { get; set; } = "";
    }
}