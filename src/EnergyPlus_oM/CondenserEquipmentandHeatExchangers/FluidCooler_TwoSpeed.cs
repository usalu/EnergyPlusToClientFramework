using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("The fluid cooler is modeled as a cross flow heat exchanger (both streams unmixed)" +
                 " with two-speed fans (induced draft configuration).")]
    [JsonObject("FluidCooler:TwoSpeed")]
    public class FluidCooler_TwoSpeed : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Name of fluid cooler water inlet node")]
        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [Description("Name of fluid cooler water outlet node")]
        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [Description("User can define fluid cooler thermal performance by specifying the fluid cooler U" +
                     "A and the Design Water Flow Rate, or by specifying the fluid cooler nominal capa" +
                     "city")]
        [JsonProperty("performance_input_method")]
        public FluidCooler_TwoSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (FluidCooler_TwoSpeed_PerformanceInputMethod)Enum.Parse(typeof(FluidCooler_TwoSpeed_PerformanceInputMethod), "NominalCapacity");
        

        [Description("Leave field blank if fluid cooler Performance Input Method is NominalCapacity")]
        [JsonProperty("high_fan_speed_u_factor_times_area_value")]
        public string HighFanSpeedUFactorTimesAreaValue { get; set; } = "";
        

        [Description("Leave field blank if fluid cooler Performance Input Method is NominalCapacity Low" +
                     " speed fluid cooler UA must be less than high speed fluid cooler UA Low speed fl" +
                     "uid cooler UA must be greater than free convection fluid cooler UA")]
        [JsonProperty("low_fan_speed_u_factor_times_area_value")]
        public string LowFanSpeedUFactorTimesAreaValue { get; set; } = "";
        

        [Description("This field is only used if the previous field is set to autocalculate and the Per" +
                     "formance Input Method is UFactorTimesAreaAndDesignWaterFlowRate")]
        [JsonProperty("low_fan_speed_u_factor_times_area_sizing_factor")]
        public System.Nullable<float> LowFanSpeedUFactorTimesAreaSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.6", CultureInfo.InvariantCulture);
        

        [Description("Nominal fluid cooler capacity at high fan speed")]
        [JsonProperty("high_speed_nominal_capacity")]
        public System.Nullable<float> HighSpeedNominalCapacity { get; set; } = null;
        

        [Description("Nominal fluid cooler capacity at low fan speed")]
        [JsonProperty("low_speed_nominal_capacity")]
        public string LowSpeedNominalCapacity { get; set; } = "";
        

        [Description("This field is only used if the previous field is set to autocalculate and the Per" +
                     "formance Input Method is NominalCapacity")]
        [JsonProperty("low_speed_nominal_capacity_sizing_factor")]
        public System.Nullable<float> LowSpeedNominalCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Design Entering Water Temperature must be specified for both the performance inpu" +
                     "t methods and its value must be greater than Design Entering Air Temperature.")]
        [JsonProperty("design_entering_water_temperature")]
        public System.Nullable<float> DesignEnteringWaterTemperature { get; set; } = null;
        

        [Description("Design Entering Air Temperature must be specified for both the performance input " +
                     "methods and its value must be greater than Design Entering Air Wet-bulb Temperat" +
                     "ure.")]
        [JsonProperty("design_entering_air_temperature")]
        public System.Nullable<float> DesignEnteringAirTemperature { get; set; } = null;
        

        [Description("Design Entering Air Wet-bulb Temperature must be specified for both the performan" +
                     "ce input methods and its value must be less than Design Entering Air Temperature" +
                     ".")]
        [JsonProperty("design_entering_air_wet_bulb_temperature")]
        public System.Nullable<float> DesignEnteringAirWetBulbTemperature { get; set; } = null;
        

        [JsonProperty("design_water_flow_rate")]
        public string DesignWaterFlowRate { get; set; } = "";
        

        [Description("Air Flow Rate at High Fan Speed must be greater than Air Flow Rate at Low Fan Spe" +
                     "ed")]
        [JsonProperty("high_fan_speed_air_flow_rate")]
        public string HighFanSpeedAirFlowRate { get; set; } = "";
        

        [Description("This is the fan motor electric input power at high speed")]
        [JsonProperty("high_fan_speed_fan_power")]
        public string HighFanSpeedFanPower { get; set; } = "";
        

        [Description("Air Flow Rate at Low Fan Speed must be less than Air Flow Rate at High Fan Speed")]
        [JsonProperty("low_fan_speed_air_flow_rate")]
        public string LowFanSpeedAirFlowRate { get; set; } = "";
        

        [Description("This field is only used if the previous field is set to autocalculate.")]
        [JsonProperty("low_fan_speed_air_flow_rate_sizing_factor")]
        public System.Nullable<float> LowFanSpeedAirFlowRateSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("This is the fan motor electric input power at low speed")]
        [JsonProperty("low_fan_speed_fan_power")]
        public string LowFanSpeedFanPower { get; set; } = "";
        

        [Description("This field is only used if the previous field is set to autocalculate.")]
        [JsonProperty("low_fan_speed_fan_power_sizing_factor")]
        public System.Nullable<float> LowFanSpeedFanPowerSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.16", CultureInfo.InvariantCulture);
        

        [JsonProperty("outdoor_air_inlet_node_name")]
        public string OutdoorAirInletNodeName { get; set; } = "";
    }
}