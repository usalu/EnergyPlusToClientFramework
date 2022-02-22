using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    [Description(@"Specifies an alternate set of performance parameters for a fan. These alternate parameters are used when a system manager (such as AvailabilityManager:NightVentilation) sets a specified flow rate. May be used with Fan:ConstantVolume, Fan:VariableVolume and Fan:ComponentModel. If the fan model senses that a fixed flow rate has been set, it will use these alternate performance parameters. It is assumed that the fan will run at a fixed speed in the alternate mode.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FanPerformance_NightVentilation : BHoMObject
    {
        

        [JsonProperty("fan_name")]
        public string FanName { get; set; } = "";
        

        [JsonProperty("fan_total_efficiency")]
        public System.Nullable<float> FanTotalEfficiency { get; set; } = null;
        

        [JsonProperty("pressure_rise")]
        public System.Nullable<float> PressureRise { get; set; } = null;
        

        [JsonProperty("maximum_flow_rate")]
        public string MaximumFlowRate { get; set; } = "";
        

        [JsonProperty("motor_efficiency")]
        public System.Nullable<float> MotorEfficiency { get; set; } = null;
        

        [Description("0.0 means fan motor outside of airstream 1.0 means fan motor inside of airstream")]
        [JsonProperty("motor_in_airstream_fraction")]
        public System.Nullable<float> MotorInAirstreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
}