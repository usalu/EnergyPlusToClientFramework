using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description(@"Refrigeration Door Mixing is used for an opening between two zones that are at the same elevation but have different air temperatures. In this case, the mixing air flow between the two zones is determined by the density difference between the two zones. This would typically be used between two zones in a refrigerated warehouse that are controlled at different temperatures. It could also be used to model a door to a walk-in refrigerated space if that space were modeled as a zone instead of using the object Refrigeration:WalkIn.")]
    [JsonObject("ZoneRefrigerationDoorMixing")]
    public class ZoneRefrigerationDoorMixing : BHoMObject
    {
        

        [JsonProperty("zone_1_name")]
        public string Zone1Name { get; set; } = "";
        

        [JsonProperty("zone_2_name")]
        public string Zone2Name { get; set; } = "";
        

        [Description(@"This schedule defines the fraction of the time the refrigeration door is open For example, if the warehouse is closed at night and there are no door openings between two zones, the value for that time period would be 0. If doors were propped open, the value  over that time period would be 1.0 If the doors were open about 20% of the time, the value over that period would be 0.2 Schedule values must lie between 0 and 1.0")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [JsonProperty("door_height")]
        public System.Nullable<float> DoorHeight { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty("door_area")]
        public System.Nullable<float> DoorArea { get; set; } = (System.Nullable<float>)Single.Parse("9", CultureInfo.InvariantCulture);
        

        [Description("Door protection can reduce the air flow through a refrigeration door The default " +
                     "value is \"None\" Choices: \"None\", \"AirCurtain\", and \"StripCurtain\" A strip curtai" +
                     "n reduces the air flow more than an air curtain")]
        [JsonProperty("door_protection_type")]
        public EmptyNoYes DoorProtectionType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "None");
    }
}