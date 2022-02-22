using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("Used to model room air with a fixed temperature gradient in the vertical directio" +
                 "n. Used in combination with RoomAir:TemperaturePattern:UserDefined.")]
    [JsonObject("RoomAir:TemperaturePattern:ConstantGradient")]
    public class RoomAir_TemperaturePattern_ConstantGradient : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("room_air_temperature_pattern_constant_gradient_name")]
        public string RoomAirTemperaturePatternConstantGradientName { get; set; } = "";
        

        [Description("reference this entry in Schedule Name")]
        [JsonProperty("control_integer_for_pattern_control_schedule_name")]
        public System.Nullable<float> ControlIntegerForPatternControlScheduleName { get; set; } = null;
        

        [Description("= (Temp at thermostat- Mean Air Temp)")]
        [JsonProperty("thermostat_offset")]
        public System.Nullable<float> ThermostatOffset { get; set; } = null;
        

        [Description("= (Tleaving - Mean Air Temp )")]
        [JsonProperty("return_air_offset")]
        public System.Nullable<float> ReturnAirOffset { get; set; } = null;
        

        [Description("= (Texhaust - Mean Air Temp) deg C")]
        [JsonProperty("exhaust_air_offset")]
        public System.Nullable<float> ExhaustAirOffset { get; set; } = null;
        

        [Description("Slope of temperature change in vertical direction")]
        [JsonProperty("temperature_gradient")]
        public System.Nullable<float> TemperatureGradient { get; set; } = null;
    }
}