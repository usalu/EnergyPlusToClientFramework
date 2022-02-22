using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    [Description("Constant volume fan that is intended to operate continuously based on a time sche" +
                 "dule. This fan will not cycle on and off based on cooling/heating load or other " +
                 "control signals.")]
    public class Fan_ConstantVolume : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty("availability_schedule_name")]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty("fan_total_efficiency")]
        public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty("pressure_rise")]
        public System.Nullable<float> PressureRise { get; set; } = null;
        

        [JsonProperty("maximum_flow_rate")]
        public string MaximumFlowRate { get; set; } = "";
        

        [JsonProperty("motor_efficiency")]
        public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("0.0 means fan motor outside of air stream, 1.0 means motor inside of air stream")]
        [JsonProperty("motor_in_airstream_fraction")]
        public System.Nullable<float> MotorInAirstreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("air_inlet_node_name")]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty("air_outlet_node_name")]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}