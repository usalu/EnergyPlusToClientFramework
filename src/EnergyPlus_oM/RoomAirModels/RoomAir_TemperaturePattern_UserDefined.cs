using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("Used to explicitly define temperature patterns that are to be applied to the mean" +
                 " air temperature within a thermal zone. Used with RoomAirModelType = UserDefined" +
                 ".")]
    [JsonObject("RoomAir:TemperaturePattern:UserDefined")]
    public class RoomAir_TemperaturePattern_UserDefined : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [Description("Availability schedule name for this model. Schedule value > 0 means the model is " +
                     "active. Schedule value = 0 means the model is inactive and the zone will be mode" +
                     "led as fully mixed (Mixing). If this field is blank, the model is always active." +
                     "")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("The schedule should contain integer values that correspond to unique Control Inte" +
                     "ger fields in one of the RoomAir:TemperaturePattern:* objects.")]
        [JsonProperty("pattern_control_schedule_name")]
        public string PatternControlScheduleName { get; set; } = "";
    }
}