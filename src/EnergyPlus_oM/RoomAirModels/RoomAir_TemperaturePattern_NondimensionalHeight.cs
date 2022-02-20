using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description(@"Defines a distribution pattern for air temperatures relative to the current mean air temperature as a function of height. The height, referred to as Zeta, is nondimensional by normalizing with the zone ceiling height. Used in combination with RoomAir:TemperaturePattern:UserDefined.")]
    [JsonObject("RoomAir:TemperaturePattern:NondimensionalHeight")]
    public class RoomAir_TemperaturePattern_NondimensionalHeight : BHoMObject
    {
        

        [Description("this value should appear in as a schedule value")]
        [JsonProperty("control_integer_for_pattern_control_schedule_name")]
        public System.Nullable<float> ControlIntegerForPatternControlScheduleName { get; set; } = null;
        

        [Description("= (Temp at thermostat- Mean Air Temp)")]
        [JsonProperty("thermostat_offset")]
        public System.Nullable<float> ThermostatOffset { get; set; } = null;
        

        [Description("= (Temp leaving - Mean Air Temp ) deg C")]
        [JsonProperty("return_air_offset")]
        public System.Nullable<float> ReturnAirOffset { get; set; } = null;
        

        [Description(@"= (Temp exhaust - Mean Air Temp) deg C the remaining fields have pairs that describe the relative temperature pattern in the vertical direction of a zone Zeta is the nondimensional height (in z-direction). on [0..1] DeltaTai =  (Tai - MAT) in units of deg. C relative deg C on [-10.0 .. 20.0 ]")]
        [JsonProperty("exhaust_air_offset")]
        public System.Nullable<float> ExhaustAirOffset { get; set; } = null;
        

        [JsonProperty("pairs")]
        public string Pairs { get; set; } = "";
    }
}