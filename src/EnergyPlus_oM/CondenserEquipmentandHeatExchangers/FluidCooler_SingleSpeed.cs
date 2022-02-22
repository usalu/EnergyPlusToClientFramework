using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("The fluid cooler is modeled as a cross flow heat exchanger (both streams unmixed)" +
                 " with single-speed fans (induced draft configuration).")]
    public class FluidCooler_SingleSpeed : BHoMObject, IEnergyPlusClass
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FluidCooler_SingleSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (FluidCooler_SingleSpeed_PerformanceInputMethod)Enum.Parse(typeof(FluidCooler_SingleSpeed_PerformanceInputMethod), "NominalCapacity");
        

        [Description("Leave field blank if fluid cooler Performance Input Method is NominalCapacity")]
        [JsonProperty("design_air_flow_rate_u_factor_times_area_value")]
        public string DesignAirFlowRateUFactorTimesAreaValue { get; set; } = "";
        

        [Description("Nominal fluid cooler capacity")]
        [JsonProperty("nominal_capacity")]
        public System.Nullable<float> NominalCapacity { get; set; } = null;
        

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
        [JsonProperty("design_entering_air_wetbulb_temperature")]
        public System.Nullable<float> DesignEnteringAirWetbulbTemperature { get; set; } = null;
        

        [JsonProperty("design_water_flow_rate")]
        public string DesignWaterFlowRate { get; set; } = "";
        

        [JsonProperty("design_air_flow_rate")]
        public string DesignAirFlowRate { get; set; } = "";
        

        [Description("This is the fan motor electric input power")]
        [JsonProperty("design_air_flow_rate_fan_power")]
        public string DesignAirFlowRateFanPower { get; set; } = "";
        

        [Description("Enter the name of an outdoor air node")]
        [JsonProperty("outdoor_air_inlet_node_name")]
        public string OutdoorAirInletNodeName { get; set; } = "";
    }
}