using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description("Infiltration is specified as flow coefficient, schedule fraction, stack and wind " +
                 "coefficients, and is a function of temperature difference and wind speed: Infilt" +
                 "ration=FSchedule * SQRT( (c * Cs*|(Tzone-Todb)|**n)**2 + (c* Cw*(s * WindSpd)**2" +
                 "n)**2 )")]
    [JsonObject("ZoneInfiltration:FlowCoefficient")]
    public class ZoneInfiltration_FlowCoefficient : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_name")]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description("\"c\" in Equation")]
        [JsonProperty("flow_coefficient")]
        public System.Nullable<float> FlowCoefficient { get; set; } = null;
        

        [Description("\"Cs\" in Equation")]
        [JsonProperty("stack_coefficient")]
        public System.Nullable<float> StackCoefficient { get; set; } = null;
        

        [Description("\"n\" in Equation")]
        [JsonProperty("pressure_exponent")]
        public System.Nullable<float> PressureExponent { get; set; } = (System.Nullable<float>)Single.Parse("0.67", CultureInfo.InvariantCulture);
        

        [Description("\"Cw\" in Equation")]
        [JsonProperty("wind_coefficient")]
        public System.Nullable<float> WindCoefficient { get; set; } = null;
        

        [Description("\"s\" in Equation")]
        [JsonProperty("shelter_factor")]
        public System.Nullable<float> ShelterFactor { get; set; } = null;
    }
}