using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description("Infiltration is specified as effective leakage area at 4 Pa, schedule fraction, s" +
                 "tack and wind coefficients, and is a function of temperature difference and wind" +
                 " speed: Infiltration=FSchedule * (AL /1000) SQRT(Cs*|(Tzone-Todb)| +  Cw*WindSpd" +
                 "**2 )")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneInfiltration_EffectiveLeakageArea : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description("\"AL\" in Equation units are cm2 (square centimeters)")]
        [JsonProperty("effective_air_leakage_area")]
        public System.Nullable<float> EffectiveAirLeakageArea { get; set; } = null;
        

        [Description("\"Cs\" in Equation")]
        [JsonProperty("stack_coefficient")]
        public System.Nullable<float> StackCoefficient { get; set; } = null;
        

        [Description("\"Cw\" in Equation")]
        [JsonProperty("wind_coefficient")]
        public System.Nullable<float> WindCoefficient { get; set; } = null;
    }
}