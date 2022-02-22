using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Calculations of the time that setpoints are not met use a tolerance of 0.2C. This" +
                 " object allows changing the tolerance used to determine when setpoints are being" +
                 " met.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutputControl_ReportingTolerances : BHoMObject
    {
        

        [Description(@"If the zone temperature is below the heating setpoint by more than this value, the following output variables will increment as appropriate Zone Heating Setpoint Not Met Time Zone Heating Setpoint Not Met While Occupied Time This also impacts table report ""Annual Building Utility Performance Summary"" subtable ""Comfort and Setpoint Not Met Summary""")]
        [JsonProperty("tolerance_for_time_heating_setpoint_not_met")]
        public System.Nullable<float> ToleranceForTimeHeatingSetpointNotMet { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description(@"If the zone temperature is above the cooling setpoint by more than this value, the following output variables will increment as appropriate Zone Cooling Setpoint Not Met Time Zone Cooling Setpoint Not Met While Occupied Time This also impacts table report ""Annual Building Utility Performance Summary"" subtable ""Comfort and Setpoint Not Met Summary""")]
        [JsonProperty("tolerance_for_time_cooling_setpoint_not_met")]
        public System.Nullable<float> ToleranceForTimeCoolingSetpointNotMet { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
    }
}