using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description(@"Defines a distribution pattern for the air temperatures adjacent to individual surfaces. This allows controlling the adjacent air temperature on a surface-by-surface basis rather than by height. This allows modeling different adjacent air temperatures on the opposite sides of the zone. Used in combination with RoomAir:TemperaturePattern:UserDefined.")]
    [JsonObject("RoomAir:TemperaturePattern:SurfaceMapping")]
    public class RoomAir_TemperaturePattern_SurfaceMapping : BHoMObject, IEnergyPlusClass
    {
        

        [Description("reference this entry in schedule")]
        [JsonProperty("control_integer_for_pattern_control_schedule_name")]
        public System.Nullable<float> ControlIntegerForPatternControlScheduleName { get; set; } = null;
        

        [Description("= (Temp at thermostat- Mean Air Temp)")]
        [JsonProperty("thermostat_offset")]
        public System.Nullable<float> ThermostatOffset { get; set; } = null;
        

        [Description("= (Tleaving - Mean Air Temp ) deg C")]
        [JsonProperty("return_air_offset")]
        public System.Nullable<float> ReturnAirOffset { get; set; } = null;
        

        [Description("= (Texhaust - Mean Air Temp) deg C")]
        [JsonProperty("exhaust_air_offset")]
        public System.Nullable<float> ExhaustAirOffset { get; set; } = null;
        

        [JsonProperty("surface_deltas")]
        public string SurfaceDeltas { get; set; } = "";
    }
}