using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    [Description("Variable air volume fan where the electric power input varies according to a perf" +
                 "ormance curve as a function of flow fraction.")]
    [JsonObject("Fan:VariableVolume")]
    public class Fan_VariableVolume : BHoMObject, IEnergyPlusClass
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
        

        [JsonProperty("fan_power_minimum_flow_rate_input_method")]
        public Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod FanPowerMinimumFlowRateInputMethod { get; set; } = (Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod)Enum.Parse(typeof(Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod), "Fraction");
        

        [JsonProperty("fan_power_minimum_flow_fraction")]
        public System.Nullable<float> FanPowerMinimumFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

        [JsonProperty("fan_power_minimum_air_flow_rate")]
        public System.Nullable<float> FanPowerMinimumAirFlowRate { get; set; } = null;
        

        [JsonProperty("motor_efficiency")]
        public System.Nullable<float> MotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("0.0 means fan motor outside of air stream, 1.0 means motor inside of air stream")]
        [JsonProperty("motor_in_airstream_fraction")]
        public System.Nullable<float> MotorInAirstreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("all Fan Power Coefficients should not be 0.0 or no fan power will be consumed. Fa" +
                     "n Power Coefficents are specified as function of full flow rate/power Equation:")]
        [JsonProperty("fan_power_coefficient_1")]
        public System.Nullable<float> FanPowerCoefficient1 { get; set; } = null;
        

        [JsonProperty("fan_power_coefficient_2")]
        public System.Nullable<float> FanPowerCoefficient2 { get; set; } = null;
        

        [JsonProperty("fan_power_coefficient_3")]
        public System.Nullable<float> FanPowerCoefficient3 { get; set; } = null;
        

        [JsonProperty("fan_power_coefficient_4")]
        public System.Nullable<float> FanPowerCoefficient4 { get; set; } = null;
        

        [JsonProperty("fan_power_coefficient_5")]
        public System.Nullable<float> FanPowerCoefficient5 { get; set; } = null;
        

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