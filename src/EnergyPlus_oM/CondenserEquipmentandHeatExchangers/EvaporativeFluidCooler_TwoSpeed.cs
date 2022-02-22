using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("This model is based on Merkel\'s theory, which is also the basis for the cooling t" +
                 "ower model in EnergyPlus. The Evaporative fluid cooler is modeled as a counter f" +
                 "low heat exchanger.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EvaporativeFluidCooler_TwoSpeed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [Description("Name of fluid cooler water inlet node")]
        [JsonProperty("water_inlet_node_name")]
        public string WaterInletNodeName { get; set; } = "";
        

        [Description("Name of fluid cooler water outlet node")]
        [JsonProperty("water_outlet_node_name")]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("high_fan_speed_air_flow_rate")]
        public string HighFanSpeedAirFlowRate { get; set; } = "";
        

        [Description("This is the fan motor electric input power at high speed")]
        [JsonProperty("high_fan_speed_fan_power")]
        public string HighFanSpeedFanPower { get; set; } = "";
        

        [Description("Low speed air flow rate must be less than high speed air flow rate")]
        [JsonProperty("low_fan_speed_air_flow_rate")]
        public string LowFanSpeedAirFlowRate { get; set; } = "";
        

        [Description("This field is only used if the previous field is set to autocalculate")]
        [JsonProperty("low_fan_speed_air_flow_rate_sizing_factor")]
        public System.Nullable<float> LowFanSpeedAirFlowRateSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("This is the fan motor electric input power at low speed")]
        [JsonProperty("low_fan_speed_fan_power")]
        public string LowFanSpeedFanPower { get; set; } = "";
        

        [Description("This field is only used if the previous field is set to autocalculate.")]
        [JsonProperty("low_fan_speed_fan_power_sizing_factor")]
        public System.Nullable<float> LowFanSpeedFanPowerSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.16", CultureInfo.InvariantCulture);
        

        [JsonProperty("design_spray_water_flow_rate")]
        public System.Nullable<float> DesignSprayWaterFlowRate { get; set; } = null;
        

        [Description("User can define fluid cooler thermal performance by specifying the fluid cooler U" +
                     "A and the Design Water Flow Rate, or by specifying the fluid cooler Standard Des" +
                     "ign Capacity or by specifying Design Capacity for Non standard conditions.")]
        [JsonProperty("performance_input_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EvaporativeFluidCooler_TwoSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (EvaporativeFluidCooler_TwoSpeed_PerformanceInputMethod)Enum.Parse(typeof(EvaporativeFluidCooler_TwoSpeed_PerformanceInputMethod), "StandardDesignCapacity");
        

        [Description("Enter the name of an outdoor air node")]
        [JsonProperty("outdoor_air_inlet_node_name")]
        public string OutdoorAirInletNodeName { get; set; } = "";
        

        [JsonProperty("heat_rejection_capacity_and_nominal_capacity_sizing_ratio")]
        public System.Nullable<float> HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"Standard design capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt (3 gpm/ton). Standard design capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25) gives the actual fluid cooler heat rejection at these operating conditions. Only used for Performance Input Method = StandardDesignCapacity; for other input methods, this field is ignored. The standard conditions mentioned above for Standard design capacity are already specified in the EnergyPlus. So the input fields such as design entering water temp., design entering air wet-bulb and dry-bulb temp. and design water flow rate, if provided in the input, will be ignored for the StandardDesignCapacity performance input method. Also, the standard conditions are for water as a fluid type so this performance input method can only be used with water as a fluid type (as specified in CondenserLoop object).")]
        [JsonProperty("high_speed_standard_design_capacity")]
        public System.Nullable<float> HighSpeedStandardDesignCapacity { get; set; } = null;
        

        [Description(@"Standard design capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt (3 gpm/ton). Standard design capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25) gives the actual fluid cooler heat rejection at these operating conditions. Only used for Performance Input Method = StandardDesignCapacity; for other input methods, this field is ignored. The standard conditions mentioned above for Standard design capacity are already specified in the EnergyPlus. So the input fields such as design entering water temp., design entering air wet-bulb and dry-bulb temp. and design water flow rate, if provided in the input, will be ignored for the StandardDesignCapacity performance input method. Also, the standard conditions are for water as a fluid type so this performance input method can only be used with water as a fluid type (as specified in CondenserLoop object).")]
        [JsonProperty("low_speed_standard_design_capacity")]
        public string LowSpeedStandardDesignCapacity { get; set; } = "";
        

        [Description("This field is only used if the previous field is set to autocalculate")]
        [JsonProperty("low_speed_standard_capacity_sizing_factor")]
        public System.Nullable<float> LowSpeedStandardCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Only used for Performance Input Method = UFactorTimesAreaAndDesignWaterFlowRate; " +
                     "for other Performance Input Methods, this field is ignored.")]
        [JsonProperty("high_fan_speed_u_factor_times_area_value")]
        public string HighFanSpeedUFactorTimesAreaValue { get; set; } = "";
        

        [Description("Only used for Performance Input Method = UFactorTimesAreaAndDesignWaterFlowRate; " +
                     "for other input methods, this field is ignored. Low speed fluid cooler UA must b" +
                     "e less than high speed fluid cooler UA")]
        [JsonProperty("low_fan_speed_u_factor_times_area_value")]
        public string LowFanSpeedUFactorTimesAreaValue { get; set; } = "";
        

        [Description("This field is only used if the previous field is set to autocalculate and the Per" +
                     "formance Input Method is UFactorTimesAreaAndDesignWaterFlowRate")]
        [JsonProperty("low_fan_speed_u_factor_times_area_sizing_factor")]
        public System.Nullable<float> LowFanSpeedUFactorTimesAreaSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.6", CultureInfo.InvariantCulture);
        

        [Description("Input value is ignored if fluid cooler Performance Input Method= StandardDesignCa" +
                     "pacity")]
        [JsonProperty("design_water_flow_rate")]
        public string DesignWaterFlowRate { get; set; } = "";
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored.")]
        [JsonProperty("high_speed_user_specified_design_capacity")]
        public System.Nullable<float> HighSpeedUserSpecifiedDesignCapacity { get; set; } = null;
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored.")]
        [JsonProperty("low_speed_user_specified_design_capacity")]
        public string LowSpeedUserSpecifiedDesignCapacity { get; set; } = "";
        

        [Description("This field is only used if the previous field is set to autocalculate")]
        [JsonProperty("low_speed_user_specified_design_capacity_sizing_factor")]
        public System.Nullable<float> LowSpeedUserSpecifiedDesignCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored. Design Entering Water Temperatu" +
                     "re must be greater than Design Entering Air Temperature.")]
        [JsonProperty("design_entering_water_temperature")]
        public System.Nullable<float> DesignEnteringWaterTemperature { get; set; } = null;
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored. Design Entering Air Temperature" +
                     " must be greater than Design Entering Air Wet-bulb Temperature.")]
        [JsonProperty("design_entering_air_temperature")]
        public System.Nullable<float> DesignEnteringAirTemperature { get; set; } = null;
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored. Design Entering Air Wet-bulb Te" +
                     "mperature must be less than Design Entering Air Temperature.")]
        [JsonProperty("design_entering_air_wet_bulb_temperature")]
        public System.Nullable<float> DesignEnteringAirWetBulbTemperature { get; set; } = null;
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("high_speed_sizing_factor")]
        public System.Nullable<float> HighSpeedSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty("evaporation_loss_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EvaporativeFluidCooler_TwoSpeed_EvaporationLossMode EvaporationLossMode { get; set; } = (EvaporativeFluidCooler_TwoSpeed_EvaporationLossMode)Enum.Parse(typeof(EvaporativeFluidCooler_TwoSpeed_EvaporationLossMode), "SaturatedExit");
        

        [Description("Rate of water evaporation from the Fluid Cooler and lost to the outdoor air [%/K]" +
                     " Empirical correlation is used to calculate default loss factor if it not explic" +
                     "itly provided.")]
        [JsonProperty("evaporation_loss_factor")]
        public System.Nullable<float> EvaporationLossFactor { get; set; } = null;
        

        [Description("Default value is under investigation. For now cooling tower\'s default value is ta" +
                     "ken.")]
        [JsonProperty("drift_loss_percent")]
        public System.Nullable<float> DriftLossPercent { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

        [JsonProperty("blowdown_calculation_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EvaporativeFluidCooler_TwoSpeed_BlowdownCalculationMode BlowdownCalculationMode { get; set; } = (EvaporativeFluidCooler_TwoSpeed_BlowdownCalculationMode)Enum.Parse(typeof(EvaporativeFluidCooler_TwoSpeed_BlowdownCalculationMode), "ConcentrationRatio");
        

        [Description(@"Characterizes the rate of blowdown in the Evaporative Fluid Cooler. Blowdown is water intentionally drained from the Evaporative Fluid Cooler in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. Default value is under investigation. For now cooling tower's default value is taken.")]
        [JsonProperty("blowdown_concentration_ratio")]
        public System.Nullable<float> BlowdownConcentrationRatio { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"Makeup water usage due to blowdown results from occasionally draining some amount of water in the Evaporative Fluid Cooler basin to purge scale or other contaminants to reduce their concentration in order to maintain an acceptable level of water quality. Schedule values should reflect water usage in m3/s.")]
        [JsonProperty("blowdown_makeup_water_usage_schedule_name")]
        public string BlowdownMakeupWaterUsageScheduleName { get; set; } = "";
        

        [JsonProperty("supply_water_storage_tank_name")]
        public string SupplyWaterStorageTankName { get; set; } = "";
    }
}